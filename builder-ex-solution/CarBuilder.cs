using System.Collections.Generic;

namespace builder_ex_solution
{
    public class CarBuilder : IBuilder
    {
        private List<string> partsList = new List<string>();
 
        public void BuildFrame()
        {
            partsList.Add("Frame");
        }

        public void BuildEngine()
        {
            partsList.Add("Engine");
        }

        public Product GetResult()
        {
            return new Product(string.Join(",", partsList));
        }

        private int seats;
        public int Seats
        {
            get
            {
                return seats;
            }
            set
            {
                seats = value;
            }
        }
    }

    public class MotocycleBuilder : IBuilder
    {
        private List<string> partsList = new List<string>();

        public void BuildFrame()
        {
            partsList.Add("Aluminum Frame");
        }

        public void BuildEngine()
        {
            partsList.Add("500cc Engine");
        }

        public Product GetResult()
        {
            return new Product(string.Join(",", partsList));
        }
    }
}
