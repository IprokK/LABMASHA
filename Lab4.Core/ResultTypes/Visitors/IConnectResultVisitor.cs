using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IConnectResultVisitor
{
    void Visit(ConnectResult.Success result);

    void Visit(ConnectResult.Failure result);
}