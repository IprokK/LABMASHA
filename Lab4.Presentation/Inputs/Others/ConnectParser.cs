using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.Iterators;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.Others;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Inputs.Others;

public class ConnectParser : BaseParser
{
    public override ICommand Handle(ITokenIterator iterator)
    {
        if (iterator.Current != "connect")
        {
            return CallNext(iterator);
        }

        iterator.MoveNext();
        string address = iterator.Current;
        string mode = "local";

        while (iterator.MoveNext())
        {
            if (iterator.Current != "-m") continue;
            iterator.MoveNext();
            mode = iterator.Current;
        }

        return new ConnectCommand(new FilePath(address), mode);
    }
}