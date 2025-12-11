using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record DeleteResult
{
    private DeleteResult() { }

    public abstract void Accept(IDeleteResultVisitor visitor);

    public sealed record Success : DeleteResult
    {
        public override void Accept(IDeleteResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : DeleteResult
    {
        public override void Accept(IDeleteResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}