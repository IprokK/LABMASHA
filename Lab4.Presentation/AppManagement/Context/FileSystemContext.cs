using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.States;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;

public class FileSystemContext : IFileSystemContext
{
    private IAppState _state;

    public FileSystemContext()
    {
        _state = new DisconnectState(this);
    }

    public void TransitionTo(IAppState state)
    {
        _state = state;
    }

    public void SetFileSystem(IFileSystem? fileSystem)
    { }

    public ConnectResult Connect(FilePath address, string mode)
    {
        return _state.Connect(address, mode);
    }

    public DisconnectResult Disconnect()
    {
        return _state.Disconnect();
    }

    public TreeListResult ListDirectory(int depth)
    {
        return _state.ListDirectory(depth);
    }

    public TreeGoToResult ChangeDirectory(FilePath path)
    {
        return _state.ChangeDirectory(path);
    }

    public ShowResult ShowFile(FilePath path)
    {
        return _state.ShowFile(path);
    }

    public MoveResult MoveFile(FilePath source, FilePath destination)
    {
        return _state.MoveFile(source, destination);
    }

    public CopyResult CopyFile(FilePath source, FilePath destination)
    {
        return _state.CopyFile(source, destination);
    }

    public DeleteResult DeleteFile(FilePath path)
    {
        return _state.DeleteFile(path);
    }

    public RenameResult RenameFile(FilePath path, string newName)
    {
        return _state.RenameFile(path, newName);
    }
}