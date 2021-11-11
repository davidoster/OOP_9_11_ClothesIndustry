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
            Size = size; 
            Fabrics = fabrics;
            Labour = labour;
            Tag = tag;

        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            SizeNames sizeNames = new SizeNames();

            StringBuilder sb = new StringBuilder();
            sb.Append(" Fabrics:");
            foreach (var item in Fabrics)
            {
                sb.Append(" ").Append("uses ").Append(item.Name).Append(" ").Append(item.Cost).Append(" ").Append(item.Size);
            }
            string sizeName = sizeNames.Names.ElementAt((int)Size).Key;
            return $"Cloth: Name-{Name}, Size-{sizeName},{sb.ToString()}, Labour-{Labour}, Tag-{Tag.Name}";
        }
    }
}
