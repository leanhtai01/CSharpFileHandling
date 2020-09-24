using System;
using System.IO;

namespace ReadingATextFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "myfile.txt";

            using (var sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }

                sr.Close();
            }
        }
    }
}
