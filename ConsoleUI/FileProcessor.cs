using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace ConsoleUI
{
    public static class FileProcessor
    {
        public static List<string> GetFileNames(string path)
        {
            List<string> fileNames = new List<string>();
            List<string> paths = GetFilePaths(path);

            foreach (var p in paths)
            {
                fileNames.Add(p.Substring(p.LastIndexOf('\\') + 1));
            }

            return fileNames;
        }

        public static bool SaveFileNamesToFile(List<string> fileNames, string path)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);

            foreach (var f in fileNames)
            {
                sw.WriteLine($"{f}, ");
            }

            FileStream fs = File.OpenWrite($"{path}\\registry.txt");
            StreamWriter stream = new StreamWriter(fs);
            stream.Write(sw.ToString());
            stream.Close();

            return true;
        }

        private static List<string> GetFilePaths(string path)
        {
            return System.IO.Directory.GetFiles(path).ToList();
        }

        public static string GetDirectoryPath()
        {
            return Console.ReadLine();
        }

    }
}
