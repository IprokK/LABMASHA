using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

public interface ITreeGoToResultVisitor
{
    void Visit(TreeGoToResult.Success result);

    void Visit(TreeGoToResult.Failure result);
}