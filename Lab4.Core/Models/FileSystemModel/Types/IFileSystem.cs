using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;

public interface IFileSystem
{
    TreeListResult ListDirectory(int depth);

    TreeGoToResult ChangeDirectory(FilePath path);

    CopyResult CopyFile(FilePath source, FilePath destination);

    DeleteResult DeleteFile(FilePath path);

    MoveResult MoveFile(FilePath source, FilePath destination);

    RenameResult RenameFile(FilePath path, string newName);

    ShowResult ShowFile(FilePath path);
}