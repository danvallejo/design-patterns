using System;

namespace template_ex_solution
{
    public abstract class Template
    {
        public abstract void DetermineCharacterPattern();

        public abstract void GenerateCodeTable();

        public void CompressFile()
        {
            Console.WriteLine("Compressing file...");
        }

        public void TemplateMethod()
        {
            DetermineCharacterPattern();
            GenerateCodeTable();
            CompressFile();
        }
    }

    public class PKZipTemplate : Template
    {

        public override void DetermineCharacterPattern()
        {
            Console.WriteLine("Determine Character Pattern");
        }

        public override void GenerateCodeTable()
        {
            Console.WriteLine("Generate Code Table");
        }
    }
}