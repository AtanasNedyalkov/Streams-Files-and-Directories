using System;
using System.IO;

namespace Streams__Files_and_Directories
{
    class Program
    {
        static void Main(string[] args)
        {
            var reader = new StreamReader("../../../input.txt");
            using (reader)
            {
                var write = new StreamWriter("../../../output.txt");
                using (write)
                {
                    int lineNum = 0;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                            break;
                        if (lineNum % 2 == 0)
                        {
                            write.WriteLine(line);
                        }
                        lineNum++;
                    }
                }
            }
        }
    }
}
