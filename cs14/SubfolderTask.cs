
namespace cs14
{
    class SubfolderTask
    {
        public void CopySubfolder(string path, string copyPath)
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
                if (true)
                {
                    foreach (var subDir in dirs)
                    {
                        string newDestinationDir = copyPath + @"\" + subDir.Name;
                        CopySubfolder(subDir.FullName, newDestinationDir);
                    }
                }
                Console.WriteLine("Folder copied successfully.");
            }
            else
            {
                Console.WriteLine("Original Folder does not exist.");
            }
        }

        public void MoveSubfolder(string path, string copyPath)
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
                if (true)
                {
                    foreach (var subDir in dirs)
                    {
                        string newDestinationDir = copyPath + @"\" + subDir.Name;
                        CopySubfolder(subDir.FullName, newDestinationDir);
                    }
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
