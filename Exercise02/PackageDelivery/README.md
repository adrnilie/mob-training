# Package Delivery

## 1. Description

In a package delivery system, an email has to be sent to an addressee whenever a package has been delivered. The
system also keeps track whether a package has been delivered on time.

## 2. Solitary tests

1. Open the files `DeliveryService.cs` and `DeliveryServiceTests.cs`.
2. Start with the first Solitary test from the list, following a Test-First approach ("Red, Green, Refactor").
    * Implement only a single test case at a time. Make sure that the test fails.
    * Provide the least amount of code to make the test pass.
    * Refactor, refactor, refactor!
    * Rinse & repeat.

## 3. Open questions

* How did you implement the `Add` method of the `DeliveryRepositoryStub`? Remember that a stub behaves the same as a
  dummy, except that it just returns values for query methods.
* Where did you implement the logic for the `OnTime` property of a `Delivery`? In the `DeliveryService` or the `Delivery`
  itself? If you chose the latter, did you use a test double for `Delivery` or not?
