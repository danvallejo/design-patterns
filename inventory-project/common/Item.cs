using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    public class Item
    {
        public int ItemNumber;
        public string Description;
        public float Price;
        public int Quantity;
        public float Cost;
        public float Value;

        public override string ToString()
        {
            return ItemNumber + " - " + Description;
        }
    }
}
