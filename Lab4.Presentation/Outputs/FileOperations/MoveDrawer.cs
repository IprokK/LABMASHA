using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

public class MoveDrawer : IMoveResultVisitor
{
    public void Visit(MoveResult.Success result)
    {
        Console.WriteLine("File moved successfully");
    }

    public void Visit(MoveResult.Failure result)
    {
        Console.WriteLine("Failed to move file");
    }
}