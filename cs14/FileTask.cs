
namespace cs14
{
    class FileTask
    {
        public void CopyFile(string path, string copyPath)
        {
            if (File.Exists(path))
            {
                string copyFilePath = copyPath + @"\" + path;
                File.Copy(path, copyFilePath, true);
                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
        public void MoveFile(string path, string copyPath)
        {
            if (File.Exists(path))
            {
                string copyFilePath = copyPath + @"\" + path;
                File.Move(path, copyFilePath, true);
                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
    }
}
