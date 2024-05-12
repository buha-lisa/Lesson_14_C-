
namespace cs14
{
    class FolderTask
    {
        public void CopyFolder(string path, string copyPath)
        {
            if (!Directory.Exists(copyPath))
            {
                Directory.CreateDirectory(copyPath);
            }
            if (Directory.Exists(path))
            {
                var dir = new DirectoryInfo(path);
                DirectoryInfo[] dirs = dir.GetDirectories();
                Directory.CreateDirectory(copyPath);
                foreach (var file in dir.GetFiles())
                {
                    var temp = copyPath + @"\" + file.Name;
                    file.CopyTo(temp);
                }
                Console.WriteLine("Folder copied successfully.");
            }
            else
            {
                Console.WriteLine("Original Folder does not exist.");
            }
        }

        public void MoveFolder(string path, string copyPath)
        {
            if (Directory.Exists(path))
            {
                var dir = new DirectoryInfo(path);
                DirectoryInfo[] dirs = dir.GetDirectories();
                Directory.CreateDirectory(copyPath);
                foreach (var file in dir.GetFiles())
                {
                    var temp = copyPath + @"\" + file.Name;
                    file.CopyTo(temp);
                }
                Directory.Delete(path, true);
                Console.WriteLine("Folder moved successfully.");
            }
            else
            {
                Console.WriteLine("Original Folder does not exist.");
            }
        }
    }
}
