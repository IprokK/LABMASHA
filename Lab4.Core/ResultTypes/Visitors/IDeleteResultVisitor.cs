using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IDeleteResultVisitor
{
    void Visit(DeleteResult.Success result);

    void Visit(DeleteResult.Failure result);
}