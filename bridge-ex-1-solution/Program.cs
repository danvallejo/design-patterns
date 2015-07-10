using System;

namespace bridge_ex_1_solution
{
    class Program
    {
        static void Main()
        {
            Abstraction abstraction = new MySmartTelevision();

            abstraction.Implementor = new CableTelevisionImpl();

            DoStuff(abstraction);

            // Use new LCD TV abstraction
            Abstraction lcdTv = new LCDTelevision();
            
            lcdTv.Implementor = new LCDTelevisionImpl();
         
            DoStuff(lcdTv);
        }

        static void DoStuff(Abstraction abstractTV)
        {
            Console.WriteLine(abstractTV.GetGuide());

            Console.WriteLine(abstractTV.PlayVideo());
        }
    }
}
