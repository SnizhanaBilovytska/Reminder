using System;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApplication1
{
    public class CalculateLinesOfCode
    {
        public static int Calculate(string path, string fileEnds)
        {
            
            List<string> allDirectories = new List<string>();
            List<string> allFiles = new List<string>();

            FindDirectories(path, allDirectories);
            //foreach (string directory in allDirectories)
            //    Console.WriteLine(directory);

            FindFilesInDirectories(allDirectories, allFiles);

            return  GetTotalLines(allFiles, fileEnds);
        }

        private static void FindDirectories(string baseDirectory, List<string> allDirectories)
        {
            IEnumerable<string> directories = Directory.EnumerateDirectories(baseDirectory);
            allDirectories.AddRange(directories);

            foreach (string directory in directories)
                FindDirectories(directory, allDirectories);
        }

        private static void FindFilesInDirectories(List<string> allDirectories, List<string> allFiles)
        {
            foreach (string directory in allDirectories)
                allFiles.AddRange(Directory.EnumerateFiles(directory));     
        }

        private static int LineInFile(string file)
        {
            int i = 0;
            using (StreamReader sr = new StreamReader(file))
            {
                String line;
                while ((line = sr.ReadLine()) != null) 
                {
                    i++;
                }
            }
            return i;
        }

        private static int GetTotalLines(List<string> allFiles, string fileEnds)
        {
            int totalCount = 0;

            foreach (string file in allFiles)
            {
                int count = 0;
                if (file.EndsWith(fileEnds))
                    count = LineInFile(file);

                //Console.WriteLine($"{count} lines in file {file}");
                totalCount += count;
            }
            Console.WriteLine($"{totalCount} {fileEnds}");
            return totalCount;
        }
    }
}
