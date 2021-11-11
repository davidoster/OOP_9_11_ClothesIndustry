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

        public override bool Equals(object obj)
        {
            return obj is Tag tag &&
                   //Name == tag.Name &&
                   Size == tag.Size;
                   //Cost == tag.Cost;
        }

        public override int GetHashCode()
        {
            int hashCode = 28320666;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Size.GetHashCode();
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            return sb.Append("Tag: ").Append($"Name-{Name}, Size-{Size}, Cost-{Cost}").ToString();
        }
    }
}
