using System.Diagnostics;
using System.Runtime.CompilerServices;
// Trace

// [Caller...] attributes

internal partial class Program
{
    private static void LogSourceDetails(
        bool condition,
        [CallerMemberName] string member = "",
        [CallerFilePath] string filepath = "",
        [CallerLineNumber] int line = 0,
        [CallerArgumentExpression(nameof(condition))]
        string expression = "")
    {
        Trace.WriteLine(string.Format(
            "[{0}]\n {1} on line {2}. Expression: {3}",
            filepath, member, line, expression));
    }
}