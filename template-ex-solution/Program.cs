using System;

namespace template_ex_solution
{
    class Program
    {
        static void Main()
        {
            var template = new PKZipTemplate();

            template.TemplateMethod();

            Console.ReadLine();
        }
    }
}
