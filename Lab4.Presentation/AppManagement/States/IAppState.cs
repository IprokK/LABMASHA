using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Presentation.AppManagement.States;

public interface IAppState
{
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