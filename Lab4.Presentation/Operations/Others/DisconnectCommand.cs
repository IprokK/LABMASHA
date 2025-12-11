using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.Others;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.Others;

public class DisconnectCommand : ICommand
{
    public void Execute(IFileSystemContext context)
    {
        CommandResult result = context.Disconnect();
        result.Accept(new DisconnectDrawer());
    }
}