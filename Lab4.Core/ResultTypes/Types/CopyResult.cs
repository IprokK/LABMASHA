using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record CopyResult
{
    private CopyResult() { }

    public abstract void Accept(ICopyResultVisitor visitor);

    public sealed record Success : CopyResult
    {
        public override void Accept(ICopyResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : CopyResult
    {
        public override void Accept(ICopyResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}