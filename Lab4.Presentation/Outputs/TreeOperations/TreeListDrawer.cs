using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.TreeOperations;

public class TreeListDrawer : ITreeListResultVisitor
{
    public void Visit(TreeListResult.Success result)
    {
        var treeVisitor = new TreeVisitor();
        result.Root.Apply(treeVisitor);
    }

    public void Visit(TreeListResult.Failure result)
    {
        Console.WriteLine("Failed to list directory");
    }
}