using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public class Fabric
    {
        public string Name { get; set; }

        //private FabricType _type; // use this only if you need to have custom code on the public property Type
        public FabricType Type { get; set; }

        private Unit _size;
        public Unit Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = SizeValidation(value, Unit.Meters);
            }
        }

        private double _cost;
        public double Cost
        {
            get
            {
                return _cost;
            }

            set
            {
                _cost = CostValidation(value, 10);
            }
        }

        public Fabric(string name, double cost, Unit size, FabricType type)
        {
            Name = name;
            Cost = CostValidation(cost, 10);
            Size = SizeValidation(size, Unit.Meters);
            Type = type;
        }

        private double CostValidation(double cost, double defaultCost)
        {
            if (cost <= 0)
            {
                return defaultCost;
            }
            return cost;
        }

        private Unit SizeValidation(Unit size, Unit defaultSize)
        {
            if (size <= 0)
            {
                return defaultSize;
            }
            else
            {
                return size;
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Fabric fabric &&
                   Name == fabric.Name &&
                   EqualityComparer<FabricType>.Default.Equals(Type, fabric.Type) &&
                   _size == fabric._size &&
                   Size == fabric.Size &&
                   _cost == fabric._cost &&
                   Cost == fabric.Cost;
        }

        public override int GetHashCode()
        {
            int hashCode = -1670995019;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + EqualityComparer<FabricType>.Default.GetHashCode(Type);
            hashCode = hashCode * -1521134295 + _size.GetHashCode();
            hashCode = hashCode * -1521134295 + Size.GetHashCode();
            hashCode = hashCode * -1521134295 + _cost.GetHashCode();
            hashCode = hashCode * -1521134295 + Cost.GetHashCode();
            return hashCode;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("Fabric:");
            sb.Append($"Name-{Name}, ");
            sb.Append($"Type-{Type}, ");
            sb.Append($"Cost-{Cost} Euros, ");
            sb.Append($"Size-{Size}");
            return sb.ToString();
        }
    }
}
