using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

public class ShowDrawer : IShowResultVisitor
{
    public void Visit(ShowResult.Success result)
    {
        Console.WriteLine(result.Content);
    }

    public void Visit(ShowResult.Failure result)
    {
        Console.WriteLine("Failed to read file");
    }
}