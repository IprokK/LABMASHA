using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Nodes;
using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.Iterators;
using Itmo.ObjectOrientedProgramming.Lab4.Core.Models.Navigation;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ResultTypes.Types;
using Itmo.ObjectOrientedProgramming.Lab4.Core.ValueObjects;

namespace Itmo.ObjectOrientedProgramming.Lab4.Core.Models.FileSystemModel.Types;

public class FileSystem : IFileSystem
{
    private readonly PathManager _navigator;
    private FilePath _workingDirectory;

    public FileSystem(string rootPath)
    {
        _navigator = new PathManager();
        _workingDirectory = new FilePath(rootPath);
    }

    public TreeListResult ListDirectory(int depth)
    {
        var dirInfo = new DirectoryInfo(_workingDirectory.Value);

        if (!dirInfo.Exists)
        {
            return new TreeListResult.Failure();
        }

        var scanner = new DirectoryScanner(dirInfo.FullName, depth, 0);
        return new TreeListResult.Success(new DirectoryNode(dirInfo.Name, scanner));
    }

    public TreeGoToResult ChangeDirectory(FilePath path)
    {
        FilePath targetPath = _navigator.Manage(_workingDirectory, path);

        if (!Directory.Exists(targetPath.Value)) return new TreeGoToResult.Failure();
        _workingDirectory = targetPath;
        return new TreeGoToResult.Success();
    }

    public CopyResult CopyFile(FilePath source, FilePath destination)
    {
        string src = GetAbsolutePath(source);
        string dest = GetAbsolutePath(destination);

        if (!File.Exists(src) || File.Exists(dest)) return new CopyResult.Failure();
        File.Copy(src, dest);
        return new CopyResult.Success();
    }

    public DeleteResult DeleteFile(FilePath path)
    {
        string target = GetAbsolutePath(path);

        if (!File.Exists(target))
        {
            return new DeleteResult.Failure();
        }

        File.Delete(target);
        return new DeleteResult.Success();
    }

    public MoveResult MoveFile(FilePath source, FilePath destination)
    {
        string srcPath = GetAbsolutePath(source);
        string destPath = GetAbsolutePath(destination);

        if (!File.Exists(srcPath) || File.Exists(destPath))
        {
            return new MoveResult.Failure();
        }

        try
        {
            File.Move(srcPath, destPath);
            return new MoveResult.Success();
        }
        catch
        {
            return new MoveResult.Failure();
        }
    }

    public RenameResult RenameFile(FilePath path, string newName)
    {
        var oldFile = new FileInfo(GetAbsolutePath(path));

        if (!oldFile.Exists || oldFile.DirectoryName == null)
        {
            return new RenameResult.Failure();
        }

        string newFullPath = Path.Combine(oldFile.DirectoryName, newName);

        if (File.Exists(newFullPath))
        {
            return new RenameResult.Failure();
        }

        oldFile.MoveTo(newFullPath);
        return new RenameResult.Success();
    }

    public ShowResult ShowFile(FilePath path)
    {
        string fullPath = GetAbsolutePath(path);
        var fileInfo = new FileInfo(fullPath);

        return fileInfo.Exists
            ? new ShowResult.Success(File.ReadAllText(fileInfo.FullName))
            : new ShowResult.Failure();
    }

    private string GetAbsolutePath(FilePath relativePath)
    {
        return _navigator.Manage(_workingDirectory, relativePath).Value;
    }
}