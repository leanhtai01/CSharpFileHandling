using System;
using System.IO;

namespace ReadingATextFileUsingTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "myfile.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }

                    sr.Close();
                }
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
