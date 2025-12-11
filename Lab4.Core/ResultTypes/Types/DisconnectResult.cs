using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record DisconnectResult
{
    private DisconnectResult() { }

    public abstract void Accept(IDisconnectResultVisitor visitor);

    public sealed record Success : DisconnectResult
    {
        public override void Accept(IDisconnectResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : DisconnectResult
    {
        public override void Accept(IDisconnectResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}