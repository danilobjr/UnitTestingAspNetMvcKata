Unit Testing Asp.NET MVC 4 Kata
===============================

Unit testing kata for an Asp.NET MVC 4 app.


### Frameworks and Libraries

- [NUnit](http://nunit.org/): Unit testing framework for all .Net languages.
- [NUnit Test Adapter](https://www.nuget.org/packages/NUnitTestAdapter/): Test runner.
- [FakeItEasy](http://fakeiteasy.github.io/): A .Net dynamic fake framework for creating all types of fake objects, mocks, stubs etc.
- [FluentMVCTesting](https://github.com/TestStack/TestStack.FluentMVCTesting): a fluent interface for creating terse and expressive tests against ASP.NET MVC controllers.


### SUT and Scenarios

The main target for this kata is the AccountController methods. The following list are some suggested scenarios for its methods.

1. Register
  - When model state is valid, returns default view
2. Delete (GET)
  - When user not found, throws NotFoundException
