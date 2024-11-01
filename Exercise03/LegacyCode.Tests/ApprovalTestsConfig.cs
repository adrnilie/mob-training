using System.Runtime.CompilerServices;

namespace PrincipalIT.LegacyCode.Tests;

public static class ApprovalTestsConfig
{
    [ModuleInitializer]
    public static void Init()
    {
        ClipboardAccept.Enable();
    }
}