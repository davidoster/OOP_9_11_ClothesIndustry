using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Services
{
    public class FabricTypeService
    {
        public List<FabricType> FabricTypes { get; set; }

        public FabricTypeService()
        {
            FabricTypes = new List<FabricType>();
            GenerateFabricTypes();
        }

        private int AddFabricType(FabricType type)
        {
            if(FabricTypes.Contains(type))
            {
                return 0;
            } 
            else
            {
                FabricTypes.Add(type);
                return 1;
            }
        }

        private void GenerateFabricTypes()
        {
            AddFabricType(new FabricType("Cotton"));
            AddFabricType(new FabricType("Wool"));
            AddFabricType(new FabricType("Linen"));
            AddFabricType(new FabricType("Silk"));
        }
    }
}
