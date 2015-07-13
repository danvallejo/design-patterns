using System;

namespace decorator_reports
{
   
    class Program
    {
        private static void PrintReport(ReportComponent report)
        {
            report.Print();
        }

        static void Main()
        {
            // Create a report
            ReportComponent report = new ReportBody();

            // Add the header
            report = new ReportHeader(report, "by John Doe");

            // Add the footer
            report = new ReportFooter(report, "-1-");

            // Add another header
            report = new ReportHeader(report, "My Report");

            PrintReport(report);

            Console.ReadLine();
        }
    }
}
