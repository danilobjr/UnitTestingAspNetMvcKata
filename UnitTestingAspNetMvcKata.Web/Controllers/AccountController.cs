using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using UnitTestingAspNetMvcKata.Web.Email;
using UnitTestingAspNetMvcKata.Web.Exceptions;
using UnitTestingAspNetMvcKata.Web.Models;
using UnitTestingAspNetMvcKata.Web.Repositories;
using UnitTestingAspNetMvcKata.Web.ViewModels;

namespace UnitTestingAspNetMvcKata.Web.Controllers
{
    public class AccountController : Controller
    {
        private UserRepository _userRepository;
        private Mailer _mailer;

        [HttpPost]
        public ActionResult Register(AccountRegisterViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var newUser = new User
                {
                    Email = viewModel.Email,
                    Password = viewModel.Password,
                    IsActive = true
                };

                _userRepository.Create(newUser);
                _mailer.Send("no@reply", newUser.Email, "Welcome", "Welcome email message");

                return RedirectToAction("Index", "Home");
            }

            return View(viewModel);
        }

        public ActionResult Delete(int id)
        {
            var user = _userRepository.FindById(id);

            if (user == null)
            {
                throw new NotFoundException("User not found");
            }

            var viewModel = new AccountDeleteViewModel
            {
                UserId = user.Id,
                Email = user.Email
            };

            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Delete(AccountDeleteViewModel viewModel)
        {
            var user = _userRepository.FindById(viewModel.UserId);

            if (user == null)
            {
                throw new NotFoundException("User not found");
            }

            if (user.IsActive)
            {
                TempData["Error"] = "Cannot delete a active user";
            }

            _userRepository.Delete(viewModel.UserId);

            return View("Index", "Home");
        }
    }
}
