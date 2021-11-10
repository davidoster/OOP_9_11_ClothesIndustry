using DataStructures.Models;
using DataStructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fabric fabric = new Fabric("Silk", 22, Unit.Meters, new FabricType("Silk"));
            //Console.WriteLine(fabric);

            //    FabricTypeService fabricTypeService = new FabricTypeService();

            //    FabricType cotton22 = new FabricType("Cotton");
            //    fabricTypeService.AddFabricType(cotton22); // add a new FabricType using a local variable
            //    fabricTypeService.AddFabricType(new FabricType("Cotton")); // add a new FabricType without a local variable

            //    fabricTypeService.FabricTypes.ForEach(Print);

            /*
             * 0. FabricTypes, create - FabricTypeService
             * 1. Fabrics,     create - FabricService
             * 2. Products,    create - ProductService
             * 3. Products, available for sell
             * 
             */


        }

        //static void Print(FabricType fabricType)
        //{
        //    Console.WriteLine(fabricType);
        //}
    }
}
