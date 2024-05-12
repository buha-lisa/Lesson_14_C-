

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
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string copyFilePath = copyPath + "\\" + fileName;
                    File.Copy(file, copyFilePath, true);
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
