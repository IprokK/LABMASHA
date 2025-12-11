using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.States;

public class ConnectState : IAppState
{
    private readonly IFileSystemContext _context;

    private readonly IFileSystem _fileSystem;

    public ConnectState(IFileSystemContext context, IFileSystem fileSystem)
    {
        _context = context;
        _fileSystem = fileSystem;
    }

    public ConnectResult Connect(FilePath address, string mode)
    {
        return new ConnectResult.Failure();
    }

    public DisconnectResult Disconnect()
    {
        _context.SetFileSystem(null);
        _context.TransitionTo(new DisconnectState(_context));
        return new DisconnectResult.Success();
    }

    public TreeListResult ListDirectory(int depth)
    {
        return _fileSystem.ListDirectory(depth);
    }

    public TreeGoToResult ChangeDirectory(FilePath path)
    {
        return _fileSystem.ChangeDirectory(path);
    }

    public ShowResult ShowFile(FilePath path)
    {
        return _fileSystem.ShowFile(path);
    }

    public MoveResult MoveFile(FilePath source, FilePath destination)
    {
        return _fileSystem.MoveFile(source, destination);
    }

    public CopyResult CopyFile(FilePath source, FilePath destination)
    {
        return _fileSystem.CopyFile(source, destination);
    }

    public DeleteResult DeleteFile(FilePath path)
    {
        return _fileSystem.DeleteFile(path);
    }

    public RenameResult RenameFile(FilePath path, string newName)
    {
        return _fileSystem.RenameFile(path, newName);
    }
}