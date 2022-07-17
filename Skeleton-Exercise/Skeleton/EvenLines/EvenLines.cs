namespace EvenLines
{
    using System;
    using System.IO;
    using System.Linq;

    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            ProcessLines(inputFilePath);
        }

        public static void ProcessLines(string inputFilePath)
        {
            string filePath = @"C:\Users\Admin\Desktop\text.txt";
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                int counter = 0;
                while (line != null)
                {
                    if (counter % 2 == 0)
                    {
                        line = Replace(line);
                        line = Reverse(line);
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = reader.ReadLine();
                }
            }
        }

        private static string Reverse(string line)
        {
            return string.Join(" ", line.Split().Reverse());
        }

        private static string Replace(string line)
        {
            return line.Replace("-", "@")
                        .Replace(",", "@")
                        .Replace(".", "@")
                        .Replace("!", "@")
                        .Replace("?", "@");
        }
    }
}
    

