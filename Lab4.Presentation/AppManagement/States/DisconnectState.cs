using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Factories;
using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.States;

public class DisconnectState : IAppState
{
    private readonly IFileSystemContext _context;
    private readonly IEnumerable<IFileSystemFactory> _factories;

    public DisconnectState(IFileSystemContext context)
    {
        _context = context;
        _factories = new List<IFileSystemFactory> { new FileSystemFactory() };
    }

    public ConnectResult Connect(FilePath address, string mode)
    {
        IFileSystemFactory? factory = _factories.FirstOrDefault(f => f.Scheme == mode);

        if (factory is null)
        {
            return new ConnectResult.Failure();
        }

        IFileSystem fileSystem = factory.Create(address.Value);

        _context.SetFileSystem(fileSystem);
        _context.TransitionTo(new ConnectState(_context, fileSystem));

        return new ConnectResult.Success();
    }

    public DisconnectResult Disconnect()
    {
        return new DisconnectResult.Failure();
    }

    public TreeListResult ListDirectory(int depth)
    {
        return new TreeListResult.Failure();
    }

    public TreeGoToResult ChangeDirectory(FilePath path)
    {
        return new TreeGoToResult.Failure();
    }

    public ShowResult ShowFile(FilePath path)
    {
        return new ShowResult.Failure();
    }

    public MoveResult MoveFile(FilePath source, FilePath destination)
    {
        return new MoveResult.Failure();
    }

    public CopyResult CopyFile(FilePath source, FilePath destination)
    {
        return new CopyResult.Failure();
    }

    public DeleteResult DeleteFile(FilePath path)
    {
        return new DeleteResult.Failure();
    }

    public RenameResult RenameFile(FilePath path, string newName)
    {
        return new RenameResult.Failure();
    }
}