using System.Runtime.CompilerServices;

namespace GildedRose.Tests;

public static class ApprovalTestsConfig
{
    [ModuleInitializer]
    public static void Init()
    {
        ClipboardAccept.Enable();  
    }
}