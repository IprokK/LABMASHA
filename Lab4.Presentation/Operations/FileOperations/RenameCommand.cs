using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.FileOperations;

public class RenameCommand : ICommand
{
    private readonly FilePath _path;
    private readonly string _newName;

    public RenameCommand(FilePath path, string newName)
    {
        _path = path;
        _newName = newName;
    }

    public void Execute(IFileSystemContext context)
    {
        CommandResult result = context.RenameFile(_path, _newName);
        result.Accept(new RenameDrawer());
    }
}