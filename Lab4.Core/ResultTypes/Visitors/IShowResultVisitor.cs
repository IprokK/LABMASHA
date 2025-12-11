using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IShowResultVisitor
{
    void Visit(ShowResult.Success result);

    void Visit(ShowResult.Failure result);
}