using System.Collections.Generic;

namespace builder
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
}
