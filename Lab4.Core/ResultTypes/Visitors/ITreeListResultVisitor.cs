using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface ITreeListResultVisitor
{
    void Visit(TreeListResult.Success result);

    void Visit(TreeListResult.Failure result);
}