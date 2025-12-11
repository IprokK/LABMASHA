using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.Iterators;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.TreeOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Inputs.TreeOperations;

public class TreeListParser : BaseParser
{
    public override ICommand Handle(ITokenIterator iterator)
    {
        if (iterator.Current != "list")
        {
            return CallNext(iterator);
        }

        int depth = 1;
        while (iterator.MoveNext())
        {
            if (iterator.Current != "-d") continue;
            iterator.MoveNext();
            depth = int.Parse(iterator.Current);
        }

        return new TreeListCommand(depth);
    }
}