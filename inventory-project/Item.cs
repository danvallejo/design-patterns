using System;

namespace programming_project_i
{
    [Serializable]
    public class Item
    {
        public int ItemNumber { get; set; }

        public string Description { get; set; }

        public float Price { get; set; }

        public int Quantity { get; set; }

        public override string ToString()
        {
            return string.Format("{0,4} - {1} {2:c}", ItemNumber, Description, Price);
        }
    }
}
