using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations;

public interface ICommand
{
    void Execute(IFileSystemContext context);
}