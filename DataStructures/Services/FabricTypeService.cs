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
        }

        public int AddFabricType(FabricType type)
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
    }
}
