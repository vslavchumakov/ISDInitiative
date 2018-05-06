using System;
using System.IO;


namespace Task_1
{
    #region Hometask_10_1
    //
    // Author: Shemet Viktoriya
    //
    // Description: 
    // Create 100 directories on the disk with the names from Folder_0 to Folder_99, then delete them.
    //
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            int number = 100; // number of folders

            DirectoryInfo dir = new DirectoryInfo(@"D:\");
            dir.CreateSubdirectory("TestDir");
            for (int i = 0; i < number; i++) dir.CreateSubdirectory(string.Format($@"TestDir\Folder_{i}"));
            Console.WriteLine(@"100 folders were created in D:\TestDir.");

            Console.WriteLine("Press any key to delete created folders.");
            Console.ReadKey();
            for (int i = 0; i < number; i++) Directory.Delete(string.Format($@"D:\TestDir\Folder_{i}"));

            Console.WriteLine(@"Press any key to delete folder TestDir.");
            Console.ReadKey();
            Directory.Delete(@"D:\TestDir");

            // Delay
            Console.ReadKey();
        }
    }
}
