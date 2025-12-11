using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.FileOperations;

public class DeleteCommand : ICommand
{
    private readonly FilePath _path;

    public DeleteCommand(FilePath path)
    {
        _path = path;
    }

    public void Execute(IFileSystemContext context)
    {
        CommandResult result = context.DeleteFile(_path);
        result.Accept(new DeleteDrawer());
    }
}