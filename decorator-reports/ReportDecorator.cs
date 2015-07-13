using System;

namespace decorator_reports
{
    public abstract class ReportDecorator : ReportComponent
    {
        private ReportComponent component;

        protected ReportDecorator(ReportComponent comp)
        {
            component = comp;
        }

        public override void Print()
        {
            component.Print();
        }
    }

    public class ReportHeader : ReportDecorator
    {
        private string title;

        public ReportHeader(ReportComponent comp, string title)
            : base(comp)
        {
            this.title = title;
        }

        public override void Print()
        {
            Console.WriteLine(title);
            base.Print();
        }
    }

    public class ReportFooter : ReportDecorator
    {
        private string title;
        public ReportFooter(ReportComponent comp, string title)
            : base(comp)
        {
            this.title = title;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine(title);
        }
    }

}