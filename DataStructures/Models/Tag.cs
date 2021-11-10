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

        public Tag(string name, Size size)
        {
            Name = name;
            Size = size;
        }

        public override string ToString()
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            result = sb.Append("Tag: ").Append($"Name-{Name}, Size-{Size}").ToString();
            return result;
        }
    }
}
