using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public static class AppProcessor
    {
        public static void AskForPath()
        {
            Console.WriteLine("Type path of directory to make a registry of files:");
        }

        public static void DisplayFileNames(List<string> fileNames)
        {
            foreach (var f in fileNames)
            {
                Console.WriteLine(fileNames);
            }
        }

        public static void EndApp()
        {
            Console.ReadLine();
        }
    }
}
