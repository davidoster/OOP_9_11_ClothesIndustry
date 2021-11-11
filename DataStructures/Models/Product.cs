using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public abstract class Product : IProduct
    {
        public string Name { get; set; }
        public Size Size { get; set; }
        public List<Fabric> Fabrics { get; set; }
        public double Labour { get; set; }
        public Tag Tag { get; set; }

        public abstract void GenerateProduct(string name, Size size, List<Fabric> fabrics, double labour, Tag tag);
    }
}
