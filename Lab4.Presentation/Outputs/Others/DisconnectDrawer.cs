using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.Others;

public class DisconnectDrawer : IDisconnectResultVisitor
{
    public void Visit(DisconnectResult.Success result)
    {
        Console.WriteLine("Disconnected successfully");
    }

    public void Visit(DisconnectResult.Failure result)
    {
        Console.WriteLine("Failed to disconnect (maybe not connected?)");
    }
}