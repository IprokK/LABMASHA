using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.Others;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.Others;

public class ConnectCommand : ICommand
{
    private readonly FilePath _address;
    private readonly string _mode;

    public ConnectCommand(FilePath address, string mode)
    {
        _address = address;
        _mode = mode;
    }

    public void Execute(IFileSystemContext context)
    {
        ConnectResult result = context.Connect(_address, _mode);
        result.Accept(new ConnectDrawer());
    }
}