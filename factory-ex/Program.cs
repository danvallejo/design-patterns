using System;

namespace factory_ex
{
    class Program
    {
        static void Main()
        {
            var wordDocument = Creators.CreateWordDocument("Word.docx");

            var excelDocument = Creators.CreateExcelDocument("Excel.xls");

            Console.ReadLine();
        }
    }
}
