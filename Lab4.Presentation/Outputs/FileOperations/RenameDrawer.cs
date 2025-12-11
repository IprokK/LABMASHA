using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

public class RenameDrawer : IRenameResultVisitor
{
    public void Visit(RenameResult.Success result)
    {
        Console.WriteLine("File renamed successfully");
    }

    public void Visit(RenameResult.Failure result)
    {
        Console.WriteLine("Failed to rename file");
    }
}