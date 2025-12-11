using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record MoveResult
{
    private MoveResult() { }

    public abstract void Accept(IMoveResultVisitor visitor);

    public sealed record Success : MoveResult
    {
        public override void Accept(IMoveResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : MoveResult
    {
        public override void Accept(IMoveResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}