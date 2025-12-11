using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Visitors;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

public class DeleteDrawer : IDeleteResultVisitor
{
    public void Visit(DeleteResult.Success result)
    {
        Console.WriteLine("File deleted successfully");
    }

    public void Visit(DeleteResult.Failure result)
    {
        Console.WriteLine("Failed to delete file");
    }
}