using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.TreeOperations;

public class TreeGoToDrawer : ITreeGoToResultVisitor
{
    public void Visit(TreeGoToResult.Success result)
    {
        Console.WriteLine("Directory changed successfully");
    }

    public void Visit(TreeGoToResult.Failure result)
    {
        Console.WriteLine("Failed to change directory (path not found)");
    }
}