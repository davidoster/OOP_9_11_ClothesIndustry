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
        public double Cost { 
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
            double result = defaultCost;
            if (cost <= 0)
            {
                Cost = 10;
            }
            return result;
        }

        private Unit SizeValidation(Unit size, Unit defaultSize)
        {
            Unit result = defaultSize;
            if (size == 0)
            {
                result = defaultSize;
            } else
            {
                result = size;
            }
            return result;
        }

        public override string ToString()
        {
            string result = "";
            StringBuilder sb = new StringBuilder();
            sb.Append("Fabric:");
            sb.Append($"Name-{Name}, ");
            sb.Append($"Type-{Type}, ");
            sb.Append($"Cost-{Cost} Euros, ");
            sb.Append($"Size-{Size}");
            result = sb.ToString();
            return result;
        }
    }
}
