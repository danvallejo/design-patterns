using System.Collections.Generic;

namespace builder_ex_solution
{
    public class CarBuilder : Builder
    {
        private List<string> partsList = new List<string>();
 
        public override void BuildFrame()
        {
            partsList.Add("Frame");
        }

        public override void BuildEngine()
        {
            partsList.Add("Engine");
        }

        public override Product GetResult()
        {
            return new Product(string.Join(",", partsList));
        }
    }

    public class MotocycleBuilder : Builder
    {
        private List<string> partsList = new List<string>();

        public override void BuildFrame()
        {
            partsList.Add("Aluminum Frame");
        }

        public override void BuildEngine()
        {
            partsList.Add("500cc Engine");
        }

        public override Product GetResult()
        {
            return new Product(string.Join(",", partsList));
        }
    }
}
