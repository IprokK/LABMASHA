using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record ConnectResult
{
    private ConnectResult() { }

    public abstract void Accept(IConnectResultVisitor visitor);

    public sealed record Success : ConnectResult
    {
        public override void Accept(IConnectResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : ConnectResult
    {
        public override void Accept(IConnectResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}