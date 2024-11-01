# Refactoring Legacy Code Guided By Approval Tests

## 1. The goal

We have a small business critical application for printing expense sheets. This application has been developed by an
unknown software developer who left the company 8 years ago. We inherited the source code from another team last week.

The finance department has expressed an urgent request to add a new feature to the application. The following requirement
has been stated:

```
The submitter of an expense sheet should be able to add a lunch expense. The expense limit for a lunch should be 2500.
```

## 2. Read the code

Find and open the file `ExpenseSheet.cs`. This file contains two classes and an enum. The bulk of the code is
implemented by the `Print` method of the `ExpenseSheet` class. Carefully read the code and write down the design smells
that you encounter. Notice that there are no automated tests.

## 3. Plan of attack

1. First we're going to add approval tests to cover every possible scenario that exists in the current implementation.
   This implies an Outside-In approach where only tests are being added. No production code gets changed or refactored at
   this stage. Using a code coverage tool can be helpful to determine whether we have missing test cases.

2. When we have all scenarios covered with approval tests, we can start our journey refactoring the production code.
   Try to keep an eye out for any opportunities to add small unit tests in the process. Refactor the approval tests 
   whenever needed. Remember to only take very small steps during this stage.

3. Add the new requested feature whenever you feel comfortable about the quality of the design of the code. Use
   Test-Driven Development to drive the design using very small iterations.

## 4. Execute

1. Find and open the file `ApprovalTests.cs`. Follow the steps as outlined in the comments.

2. At this point we have covered all scenarios with approval tests. Go to the file `ExpenseSheet.cs` and try to
   refactor the code. Make sure that the code becomes easier to test.

Make sure that you take small steps. Execute the approval tests frequently to make sure that nothing
breaks. Commit the code to your local repository after each small step. This makes it very easy to revert the code to a
previous state whenever something breaks.

Try to add small unit tests to `UnitTests.cs` whenever possible.

3. Implement the requested new feature using Test-Driven Development (Red, Green, Refactor). Add new test scenario(s)
   to `ApprovalTests.cs` to reflect the new feature. Make sure that the test fails. Add the necessary code until the
   output matches the expectations. Approve the test and make sure that it executes successfully from now on.
