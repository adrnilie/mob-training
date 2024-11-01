using System.Text.RegularExpressions;

namespace PrincipalIT.LegacyCode.Tests.Utils;

public static class DateScrubber
{
    public static string ScrubDateTime(String input)
    {
        const string pattern = "\\d{1,2}/\\d{1,2}/\\d{4} \\d{1,2}:\\d{1,2}:\\d{1,2}";
        return Regex.Replace(input, pattern, "[scrubbed_date_time]");
    }
}