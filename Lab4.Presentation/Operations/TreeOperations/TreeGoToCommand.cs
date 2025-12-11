using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.TreeOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.TreeOperations;

public class TreeGoToCommand : ICommand
{
    private readonly FilePath _path;

    public TreeGoToCommand(FilePath path)
    {
        _path = path;
    }

    public void Execute(IFileSystemContext context)
    {
        CommandResult result = context.ChangeDirectory(_path);
        result.Accept(new TreeGoToDrawer());
    }
}