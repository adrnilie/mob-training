namespace PrincipalIT.LegacyCode.Tests.Utils;

public class OutputCatcher
{
    private TextWriter _previousConsoleOut = null!;
    private StringWriter _newConsoleOut = null!;

    public void Start()
    {
        _previousConsoleOut = Console.Out;

        _newConsoleOut = new StringWriter();
        Console.SetOut(_newConsoleOut);
    }

    public void Stop()
    {
        Console.SetOut(_previousConsoleOut);
        _newConsoleOut.Close();
    }

    public string GetCapturedOutput()
    {
        var output = _newConsoleOut.ToString();
        _newConsoleOut.GetStringBuilder().Clear();
        return output;
    }
}