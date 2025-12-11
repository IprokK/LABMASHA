using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IMoveResultVisitor
{
    void Visit(MoveResult.Success result);

    void Visit(MoveResult.Failure result);
}