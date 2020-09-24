using System;
using System.IO;

namespace WritingToATextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "myfile.txt";

            using (var sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }

            // Reading from a file
            if (File.Exists(path))
            {
                using (var sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
        }
    }
}
