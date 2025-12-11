using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

public class CopyDrawer : ICopyResultVisitor
{
    public void Visit(CopyResult.Success result)
    {
        Console.WriteLine("File copied successfully");
    }

    public void Visit(CopyResult.Failure result)
    {
        Console.WriteLine("Failed to copy file");
    }
}