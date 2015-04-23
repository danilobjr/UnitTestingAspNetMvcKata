Unit Testing Asp.NET MVC 4 Kata
===============================

Unit testing kata for an Asp.NET MVC 4 app.


### Frameworks and Libraries

- [NUnit](http://nunit.org/): Unit testing framework for all .Net languages
- [NUnit Test Adapter](https://www.nuget.org/packages/NUnitTestAdapter/): Test runner
- [FakeItEasy](http://fakeiteasy.github.io/): A .Net dynamic fake framework for creating all types of fake objects, mocks, stubs etc
- [FluentMVCTesting](https://github.com/TestStack/TestStack.FluentMVCTesting): a fluent interface for creating terse and expressive tests against ASP.NET MVC controllers


### SUT and Scenarios

The main target for this kata is the **AccountController** methods. The following list are some *suggested* scenarios for its methods, including relevant and irrelevant ones.

1. Register
  - When model state is invalid, returns default view
  - When model state is valid, redirects to Index action of Home controller
  - When model state is valid, creates a new user
  - When model state is valid, sends email to user

2. Delete (GET)
  - When user not found, throws NotFoundException
  - When user exists, returns default view
  - Always call FindById method of UserRepository
  - Maps found user to view model correctly

3. Delete (POST)
  - Always call FindById method of UserRepository
  - When user not found, throws NotFoundException
  - When user exists, redirects to Index view of Home controller
  - When existing user is active, sends error message to view
  - When existing user is not active, removes user 
