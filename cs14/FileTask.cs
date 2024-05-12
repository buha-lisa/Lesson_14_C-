
namespace cs14
{
    class FileTask
    {
        public void CopyFile(string path, string copyPath)
        {
            if (File.Exists(path))
            {
                File.Copy(path, copyPath, true);
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
                File.Move(path, copyPath, true);
                Console.WriteLine("File copied successfully.");
            }
            else
            {
                Console.WriteLine("Original file does not exist.");
            }
        }
    }
}
