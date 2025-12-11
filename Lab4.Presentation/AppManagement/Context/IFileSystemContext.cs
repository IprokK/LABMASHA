using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;
using Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.States;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.Context;

public interface IFileSystemContext
{
    void TransitionTo(IAppState state);

    void SetFileSystem(IFileSystem? fileSystem);

    ConnectResult Connect(FilePath address, string mode);

    DisconnectResult Disconnect();

    TreeListResult ListDirectory(int depth);

    TreeGoToResult ChangeDirectory(FilePath path);

    ShowResult ShowFile(FilePath path);

    MoveResult MoveFile(FilePath source, FilePath destination);

    CopyResult CopyFile(FilePath source, FilePath destination);

    DeleteResult DeleteFile(FilePath path);

    RenameResult RenameFile(FilePath path, string newName);
}