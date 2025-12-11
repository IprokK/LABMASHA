using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.TreeOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.TreeOperations;

public class TreeListCommand : ICommand
{
    private readonly int _depth;

    public TreeListCommand(int depth)
    {
        _depth = depth;
    }

    public void Execute(IFileSystemContext context)
    {
        TreeListResult result = context.ListDirectory(_depth);
        result.Accept(new TreeListDrawer());
    }
}