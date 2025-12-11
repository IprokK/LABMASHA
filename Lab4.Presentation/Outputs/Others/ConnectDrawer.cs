using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.Others;

public class ConnectDrawer : IConnectResultVisitor
{
    public void Visit(ConnectResult.Success result)
    {
        Console.WriteLine("Connected successfully");
    }

    public void Visit(ConnectResult.Failure result)
    {
        Console.WriteLine("Failed to connect");
    }
}