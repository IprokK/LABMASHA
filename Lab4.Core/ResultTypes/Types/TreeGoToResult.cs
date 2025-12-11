using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record TreeGoToResult
{
    private TreeGoToResult() { }

    public abstract void Accept(ITreeGoToResultVisitor visitor);

    public sealed record Success : TreeGoToResult
    {
        public override void Accept(ITreeGoToResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : TreeGoToResult
    {
        public override void Accept(ITreeGoToResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}