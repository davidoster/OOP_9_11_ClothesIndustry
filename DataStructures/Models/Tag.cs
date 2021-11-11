using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public class Tag
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public double Cost { get; set; }

        public Tag(string name, Size size, double cost)
        {
            Name = name;
            Size = size;
            Cost = cost;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append("Tag: ").Append($"Name-{Name}, Size-{Size}, Cost-{Cost}").ToString();
        }
    }
}
