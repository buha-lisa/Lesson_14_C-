

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
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string copyFilePath = copyPath + "\\" + fileName;
                    File.Copy(file, copyFilePath, true);
                }

                string[] subDirectories = Directory.GetDirectories(path);
                foreach (string subDirectory in subDirectories)
                {
                    string directoryName = new DirectoryInfo(subDirectory).Name;
                    string copyDirectoryPath = copyPath + "\\" + directoryName;
                    CopySubfolder(subDirectory, copyDirectoryPath);
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
                Directory.Move(path, copyPath);
                Console.WriteLine("Folder copied successfully.");
            }
            else
            {
                Console.WriteLine("Original Folder does not exist.");
            }
        }
    }
}
