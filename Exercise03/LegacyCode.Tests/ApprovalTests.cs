using PrincipalIT.LegacyCode.Tests.Utils;

namespace PrincipalIT.LegacyCode.Tests;

public class ApprovalTests
{
    private OutputCatcher _outputCatcher = null!;
    private VerifySettings _verifySettings;

    [SetUp]
    public void SetUp()
    {
        //
        // Step 1: Uncomment this code
        //
        // Unfortunately, the `Print` method doesn't provide any return value. Instead, it directly calls
        // `Console.WriteLine`. This implies that we need to somehow capture the output being written to the console.
        // The `OutputCatcher` class enables this for us. Have a look at the implementation (see Utils folder) in order
        // to understand how it works.
        
        // _outputCatcher = new OutputCatcher();
        // _outputCatcher.Start();
        
        // _verifySettings = new VerifySettings();
        // _verifySettings.UseDirectory("Approvals");
    }
    
    [TearDown]
    public void TearDown()
    {
        //
        // Step 2 uncomment this code
        //
        
        // _outputCatcher.Stop();
    }
    
    //
    // Step 3: a first approval test
    //
    // Create an expense sheet for a single dinner expense with a fairly moderate amount. Use the `GetCapturedOutput`
    // method of the OutputCatcher to retrieve the output. After that the output can be verified by calling
    // `Verify`. Visually check the output in the "received" file (see Approvals folder). When the received
    // content matches the expectations, rename "received" to "approved" or sync the content to the "approved" file.
    //
    // Tip: Check the documentation: https://github.com/VerifyTests/Verify?tab=readme-ov-file#nunit
    //
    // Tip: Specify the `_verifySettings` to the `Verify` method so that the output files are written to the Approvals
    // folder.
    //
    // Tip: Make sure that the test passes after approval. If you run into a date/time related issue, have a look
    // at the `ScrubDateTime` method of the `DateScrubber` class (see Utils folder). For scrubbing date/time strings,
    // you can use `Verify(...).ScrubLinesWithReplace(...)`.
    // See https://github.com/VerifyTests/Verify/blob/main/docs/scrubbers.md#scrublineswithreplace for more information.
    //
    // Tip: An easy way to approve the received output is to open a terminal, paste the command that is currently 
    // on the clipboard (Windows: CTRL+V or Mac: CMD+V) and execute it.
    [Test]
    public Task PrintDinnerExpense()
    {
        return null;
    }
    
    // Step 4: a more comprehensive approval test
    //
    // One way to go forward is to write additional approval tests like the one in step 3 to cover every scenario for
    // the `Print` method. A more comprehensive way is to verify all scenarios in one go.
    //
    // Tip: Expand the `ExpenseScenarios` method for adding more scenarios.
    // Tip: Specify the `_verifySettings` to the `Verify` method so that the output files are written to the Approvals
    // folder.
    // Tip: For scrubbing date/time strings, you can use `Verify(...).ScrubLinesWithReplace(...)`.
    // Tip: Use a code coverage tool to verify whether all code paths have been executed through the implementation of
    // the `Print` method.
    [Test]
    public Task PrintExpenseScenarios()
    {
        var outputs = ExpenseScenarios().Select(expenses =>
        {
            //
            // TODO: call the `Print` method and return the captured output
            //
            return String.Empty;
        });
        
        // TODO: Verify the outputs
        return null;
    }
    
    private static IEnumerable<IEnumerable<Expense>> ExpenseScenarios() {

        var dinnerOf100 = new Expense
        {
            type = ExpenseType.Dinner,
            amount = 100
        };

        //
        // TODO: Create more `Expense` instances as needed
        //

        return
        [
            [dinnerOf100]
            //
            // TODO: Add a list of one or multiple expenses for each scenario.
            //
        ];
    }
    
    // Step 5: A combinatorial approval test
    //
    // Let's try a different approach compared to step 4. Another way would be to use a combination of parameters.
    // In our case we can create combinations of expense types and amounts. These combinations can be verified using
    // `CombinationApprovals.VerifyAllCombinations`.
    //
    // Tip: Although `CombinationApprovals.VerifyAllCombinations` doesn't support data scrubbing, you can still use
    // `DateScrubber.ScrubDateTime` inside the `DoPrint`method.
    // Tip: Use a code coverage tool to verify whether all code paths have been executed through the implementation of
    // the `print` method.
    [Test]
    public void PrintExpenseCombinations()
    {
        //
        // TODO: Provide the necessary expense types / amounts to be used to verify combinations.
        //
        var expenseTypes = Enumerable.Empty<ExpenseType>();
        var amounts = Enumerable.Empty<int>();
        
        Combination(settings:_verifySettings)
            .Verify(DoPrint, expenseTypes, amounts)
            .ScrubLinesWithReplace(DateScrubber.ScrubDateTime);
    }
    
    private string DoPrint(ExpenseType expenseType, int amount) {

        //
        // TODO: Create an `Expense` instance using the specified parameters, call the `Print` method on the `ExpenseSheet`
        // class and return the captured output.
        //
        return string.Empty;
    }
    
    // Step 6: Take some time to review the tests for step 4 and step 5. What are the differences between these tests?
    // Which approach is best suited in our case? Why?
}