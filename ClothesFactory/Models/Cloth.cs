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

        private double _totalCost;

        public double TotalCost
        {
            get { return _totalCost; }
            private set { _totalCost = value; }
        }

        public Cloth() { }

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
            CalculateCost();
        }

        private void CalculateCost()
        {
            double result;
            result = Labour + Tag.Cost; /// + fabrics Cost
            foreach(var item in Fabrics)
            {
                result += item.Cost;
            }
            TotalCost = result;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override string ToString()
        {
            SizeNames sizeNames = new SizeNames();
            string sizeName = sizeNames.Names.ElementAt((int)Size).Key;
            return $"Cloth: Name-{Name}, Size-{sizeName}, Tag-{Tag.Name}, Total Cost={TotalCost}";
        }


        protected string ExtendedToString()
        {
            SizeNames sizeNames = new SizeNames();

            StringBuilder sb = new StringBuilder();
            sb.Append(" Fabrics:");
            foreach (var item in Fabrics)
            {
                sb.Append(" ").Append("uses ").Append(item.Name).Append(" ").Append(item.Cost).Append(" ").Append(item.Size);
            }
            string sizeName = sizeNames.Names.ElementAt((int)Size).Key;
            return $"Cloth: Name-{Name}, Size-{sizeName},{sb.ToString()}, Labour-{Labour}, Tag-{Tag.Name}, Total Cost={TotalCost}";
        }
    }
}
