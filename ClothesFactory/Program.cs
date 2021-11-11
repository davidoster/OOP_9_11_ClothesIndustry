using ClothesFactory.Models;
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
            bool useDesigner = true;

            /*
             * 0. FabricTypes,  create - FabricTypeService
             * 1. Fabrics,      create - FabricService
             * 2. Tags,         create - TagService
             * 3. Products,     create - ProductService
             * 4. Products,     available for sell
             * 
             */

            if(useDesigner)
            {
                Designer designer = new Designer(useDesigner);
            }
            else
            {
                // We don't need to do 0 line above since this is included to 1!!!!
                // Item 0,1
                FabricService fabricService = new FabricService();
                fabricService.Fabrics.ForEach(Console.WriteLine);

                // Item 2
                TagService tagService = new TagService();
                tagService.Tags.ForEach(Console.WriteLine);

                // Item 3 Products
                ProductService productService = new ProductService();

                // Item 4 Products to Sell
                // ??? What to do here?
            }
        }
    }
}
