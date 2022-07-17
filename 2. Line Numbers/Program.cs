namespace LineNumbers
{
    using System.IO;
    public class LineNumbers
    {
        static void Main()
        {
            string inputPath = @"..\..\..\Files\input.txt";
            string outputPath = @"..\..\..\Files\output.txt";

            RewriteFileWithLineNumbers(inputPath, outputPath);
        }

        public static void RewriteFileWithLineNumbers(string inputFilePath, string outputFilePath)
        {
            var reader = new StreamReader(inputFilePath);
            using (reader)
            {
                var writer = new StreamWriter(outputFilePath);
                using (writer)
                {
                    int lineNum = 1;
                    while (true)
                    {
                        string line = reader.ReadLine();
                        if (line == null)
                            break;
                        writer.WriteLine(lineNum + ". " + line);
                        lineNum++;
                    }
                }
            }
        }
    }
}
