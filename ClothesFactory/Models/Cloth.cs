using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesFactory.Models
{
    public class Cloth : Product
    {
        public Cloth(string name, Size size, List<Fabric> fabrics, double labour, Tag tag)
        {
            GenerateProduct(name, size, fabrics, labour, tag);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override void GenerateProduct(string name, Size size, List<Fabric> fabrics, double labour, Tag tag)
        {
            Name = name;
            Size = Size; // is this correct???
            Fabrics = Fabrics; // is this correct???
            Labour = labour;
            Tag = tag; // is this correct???

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in Fabrics)
            {
                sb.Append("Fabrics:").Append(item.Name).Append(" + ").Append(item.Cost);
            }
            return $"Cloth: {Name}, {Size.ToString()}, {sb.ToString()}, {Labour}, {Tag.Name}";
        }
    }
}
