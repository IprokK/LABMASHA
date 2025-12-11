using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.Outputs.FileOperations;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.Operations.FileOperations;

public class ShowCommand : ICommand
{
    private readonly FilePath _path;
    private readonly string _mode;

    public ShowCommand(FilePath path, string mode)
    {
        _path = path;
        _mode = mode;
    }

    public void Execute(IFileSystemContext context)
    {
        ShowResult result = context.ShowFile(_path);
        if (_mode == "console")
        {
            result.Accept(new ShowDrawer());
        }
    }
}