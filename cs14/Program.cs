
namespace cs14
{
    internal class Program
    {
        static void Main()
        {
            while (true)
            {
                Console.Write("Choose number of task(1-6): ");
                int.TryParse(Console.ReadLine(), out int task);

                if (task == 0) break;

                Console.WriteLine("Enter the origin path:");
                var path = Console.ReadLine();
                Console.WriteLine("Enter the path to copy to:");
                var copyPath = Console.ReadLine();

                switch (task)
                {
                    case 1:
                        new FileTask().CopyFile(path, copyPath);
                        break;
                    case 2:
                        new FileTask().MoveFile(path, copyPath);
                        break;
                    case 3:
                        new FolderTask().CopyFolder(path, copyPath);
                        break;
                    case 4:
                        new SubfolderTask().CopySubfolder(path, copyPath);
                        break;
                    case 5:
                        new FolderTask().MoveFolder(path, copyPath);
                        break;
                    case 6:
                        new SubfolderTask().MoveSubfolder(path, copyPath);
                        break;
                }

            }



            //var test = @"testFolder";
            ////var path = @"C:\Users\user\source\C#\cs14\cs14\NewFolder\" + test; // Для переміщення
            //var path = @"C:\Users\user\source\C#\cs14\cs14";
            //if (!Directory.Exists(path))
            //{
            //    Directory.CreateDirectory(path);
            //}
            //if (!Directory.Exists(test)) 
            //{     
            //    Directory.CreateDirectory(test);
            //}

            //var res = Directory.GetCurrentDirectory();
            //Console.WriteLine(res);

            //var infos = new DirectoryInfo(path).GetFileSystemInfos();
            //foreach (var info in infos) 
            //{
            //    Console.WriteLine(info.Name);
            //}

            //// Пошук директорій
            //var dir = Directory.GetDirectories(path);
            //foreach (var direct in dir)
            //{
            //    Console.WriteLine(direct);
            //}

            //// Пошук файлів
            //var files = Directory.GetFiles(path);
            //foreach (var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            //Directory.Move(test, path);
            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path);//Не видаляє заповнену папку
            //}
            //if (Directory.Exists(path))
            //{
            //    Directory.Delete(path, recursive: true); //Видаляє заповнену папку
            //}
        }
    }
}
