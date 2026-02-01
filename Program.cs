namespace XlzCompareTool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputFile = @"C:\Users\v-Sannidhya.Singhal\Documents\srs-reports-XLF-de-DE#CVMXBGinput#.yml.txlf.xlz";
            string correlatedFile = @"C:\Users\v-Sannidhya.Singhal\Documents\srs-reports-XLF-de-DE#CVMXBGoutput#.yml.txlf.xlz";
            XlzCompare.Script(inputFile, correlatedFile, null);
            Console.WriteLine("10th line added in feature1 branch");
            Console.WriteLine("11th line in master branch");
            Console.WriteLine("12th line in master branch");
            Console.WriteLine("13th line in master branch");
            Console.WriteLine("14th line in master branch");
            Console.WriteLine("15th line in feature3 branch");
        }
    }
}
