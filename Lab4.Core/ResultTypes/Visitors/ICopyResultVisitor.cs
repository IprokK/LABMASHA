using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface ICopyResultVisitor
{
    void Visit(CopyResult.Success result);

    void Visit(CopyResult.Failure result);
}