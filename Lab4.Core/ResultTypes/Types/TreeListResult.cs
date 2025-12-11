using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Nodes;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;

public abstract record TreeListResult
{
    private TreeListResult() { }

    public abstract void Accept(ITreeListResultVisitor visitor);

    public sealed record Success(DirectoryNode Root) : TreeListResult
    {
        public override void Accept(ITreeListResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }

    public sealed record Failure : TreeListResult
    {
        public override void Accept(ITreeListResultVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}