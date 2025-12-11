using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.Iterators;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.FileOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Inputs.FileOperations;

public class ShowParser : BaseParser
{
    public override ICommand Handle(ITokenIterator iterator)
    {
        if (iterator.Current != "show")
        {
            return CallNext(iterator);
        }

        iterator.MoveNext();
        string path = iterator.Current;
        string mode = "console";

        while (iterator.MoveNext())
        {
            if (iterator.Current != "-m") continue;
            iterator.MoveNext();
            mode = iterator.Current;
        }

        return new ShowCommand(new FilePath(path), mode);
    }
}