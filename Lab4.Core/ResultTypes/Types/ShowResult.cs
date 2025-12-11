using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record ShowResult
{
    private ShowResult() { }

    public abstract void Accept(IShowResultVisitor visitor);

    public sealed record Success(string Content) : ShowResult
    {
        public override void Accept(IShowResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : ShowResult
    {
        public override void Accept(IShowResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}