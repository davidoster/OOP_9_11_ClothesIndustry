using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Services
{
    public class FabricService
    {
        public FabricTypeService FabricTypeService { get; set; }
        
        private List<Fabric> _fabrics;
        public List<Fabric> Fabrics { 
            get
            {
                return _fabrics;
            } 
            private set { } 
        }

        public FabricService()
        {
            FabricTypeService = new FabricTypeService();
            _fabrics = new List<Fabric>();
            GenerateFabrics();
        }

        private int AddFabric(Fabric fabric)
        {
            if(Fabrics.Contains(fabric))
            {
                return 0;
            }
            else
            {
                Fabrics.Add(fabric);
                return 1;
            }
        }

        private void GenerateFabrics()
        {
            int index = FabricTypeService.FabricTypes.IndexOf(new FabricType("Cotton"));
            AddFabric(new Fabric("Cotton Super Soft", 24, Unit.Meters, FabricTypeService.FabricTypes[index]));
            
            index = FabricTypeService.FabricTypes.IndexOf(new FabricType("Wool"));
            AddFabric(new Fabric("Wool Not So Soft", 18, Unit.Meters, FabricTypeService.FabricTypes[index]));

            index = FabricTypeService.FabricTypes.IndexOf(new FabricType("Linen"));
            AddFabric(new Fabric("Linen THE Soft Touch", 22, Unit.Meters, FabricTypeService.FabricTypes[index]));

            index = FabricTypeService.FabricTypes.IndexOf(new FabricType("Silk"));
            AddFabric(new Fabric("Silk THE ETHERAL TOUCH", 28, Unit.Meters, FabricTypeService.FabricTypes[index]));
        }
    }
}
