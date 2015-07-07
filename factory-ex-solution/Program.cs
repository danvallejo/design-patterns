using System;

namespace factory_ex_solution
{
    class Program
    {
        static void Main()
        {
            var wordFactory = new WordFactory();
            var wordDocument = wordFactory.Create("Word.docx");

            var excelFactory = new ExcelFactory();
            var excelDocument = excelFactory.Create("Excel.xls");

            Console.ReadLine();
        }
    }
}
