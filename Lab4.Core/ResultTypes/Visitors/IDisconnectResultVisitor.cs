using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IDisconnectResultVisitor
{
    void Visit(DisconnectResult.Success result);

    void Visit(DisconnectResult.Failure result);
}