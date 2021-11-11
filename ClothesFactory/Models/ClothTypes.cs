using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesFactory.Models
{
    public enum ClothTypes
    {
        COAT, TROUSERS_JEAN_WOMEN, TROUSERS_JEAN_MEN
    }

    public class ClothCosts
    {
        public string Id { get; set; }
        public List<ClothPrices> ClothPrices { get; set; }
        
        public ClothCosts(string id, List<ClothPrices> prices)
        {
            Id = id;
            ClothPrices = prices;
        }

    }

    // new ClothCosts("CoatSM", new List<ClothPrices>() { new ClothPrices()});

    public class ClothPrices
    {
        // ProductType, Size, FabricType, Cost
        public ClothTypes Types { get; set; }
        public FabricType Type { get; set; }
        public double Cost { get; set; }
        public Size Size { get; set; }
        
        
       
        /*
         * AddFabricType(new FabricType("Cotton"));
            AddFabricType(new FabricType("Wool"));
            AddFabricType(new FabricType("Linen"));
            AddFabricType(new FabricType("Silk"));
         * 
         * 
         */

        private ClothPrices()
        {

        }

        public ClothPrices(ClothTypes type, List<FabricCosts> fabricCosts, Size size)
        {
            Types = type;
            FabricCosts = fabricCosts;
            Size = size;
        }
    }

    
}
