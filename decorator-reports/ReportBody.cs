using System;

namespace decorator_reports
{
    public class ReportBody : ReportComponent
    {
        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Main body of the report");
            Console.WriteLine();
        }
    }
}