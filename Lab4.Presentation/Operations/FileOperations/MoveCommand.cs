using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.FileOperations;

public class MoveCommand : ICommand
{
    private readonly FilePath _source;
    private readonly FilePath _destination;

    public MoveCommand(FilePath source, FilePath destination)
    {
        _source = source;
        _destination = destination;
    }

    public void Execute(IFileSystemContext context)
    {
        MoveResult result = context.MoveFile(_source, _destination);
        result.Accept(new MoveDrawer());
    }
}