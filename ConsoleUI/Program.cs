using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
    class Program
    {

        static void Main(string[] args)
        {
            AppProcessor.AskForPath();

            string path = FileProcessor.GetDirectoryPath();
            List<string> fileNames = FileProcessor.GetFileNames(path);
            FileProcessor.SaveFileNamesToFile(fileNames, path);

            AppProcessor.DisplayFileNames(fileNames);

            AppProcessor.EndApp();
        }
    }
}
