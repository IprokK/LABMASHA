using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface IRenameResultVisitor
{
    void Visit(RenameResult.Success result);

    void Visit(RenameResult.Failure result);
}