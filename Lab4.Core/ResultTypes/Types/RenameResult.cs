using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record RenameResult
{
    private RenameResult() { }

    public abstract void Accept(IRenameResultVisitor visitor);

    public sealed record Success : RenameResult
    {
        public override void Accept(IRenameResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : RenameResult
    {
        public override void Accept(IRenameResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}