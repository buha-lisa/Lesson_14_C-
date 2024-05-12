
namespace cs14
{
    class FileTask
    {
        public void CopyFile(string path, string copyPath)
        {
            if (File.Exists(path))
            {
                var fileName = Path.GetFileName(path);
                var copyFilePath = copyPath + @"\" + fileName;
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
                var fileName = Path.GetFileName(path);
                var copyFilePath = copyPath + @"\" + fileName;
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
