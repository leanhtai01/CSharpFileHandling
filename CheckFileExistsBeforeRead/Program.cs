using System;
using System.IO;

namespace CheckFileExistsBeforeRead
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "myfile.txt";

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
            else
            {
                Console.WriteLine("File not exists!");
            }
        }
    }
}
