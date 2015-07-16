using System;

namespace autofac_console
{
    public class TodayWriter : IDateWriter
    {
        private readonly IOutput _output;

        public TodayWriter(IOutput output)
        {
            _output = output;
        }

        public void WriteDate()
        {
            _output.Write(DateTime.Today.ToShortDateString());
        }
    }
}