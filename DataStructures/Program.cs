using DataStructures.Models;
using DataStructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Fabric class
             * Cotton object Fabric
             * Wool object Fabric
             * Linen object Fabric
             * Silk object Fabric
             * Tag class
             * Products ????
             * Coat object Product??
             * Jeans Women object Product??
             * Jeans Men object Product??
             * Swim Suit Women ..
             * Swim Suit Men ..
             * Shirt Women ..
             * Shirt Men ..
             * Wholeshale ??
             * Retail ??
             * Size class Size.Name = UnitSize.XS, Size.Description = "Extra Small"
             * Extra Small object Size 
             * Small object Size
             * Medium object Size
             * Large object Size
             * Extra Large object Size
             * Labour
             * 
             * 
             */

            Fabric cotton = new Fabric("Cotton", -100, 0, new FabricType("Cotton"));
            //Console.WriteLine(cotton);

            Fabric cotton2 = new Fabric("Super Cotton", 100, Unit.Meters, new FabricType("Cotton"));

            List<Size> tagSizes2021 = new TagService().GenerateTagSizes(DateTime.Now);
            List<Size> productSizes2021 = new ProductService().GenerateProductSizes(DateTime.Now);

            Tag tagSmall = new Tag("Small", tagSizes2021[0]);
            //Console.WriteLine(tagSmall);

            Random random = new Random(4321);
            //Console.WriteLine(random.Next(1,22));

            FabricType xcotton = new FabricType("cotton");
            FabricType ycotton = new FabricType("Cotton");

            Console.WriteLine(xcotton == ycotton);
            Console.WriteLine(xcotton.Equals(ycotton));
            Console.WriteLine(xcotton.GetHashCode());

            //List<FabricType> fabricTypes = new List<FabricType>();
            //fabricTypes.Add(xcotton);
            //fabricTypes.Add(ycotton);

            //FabricTypeService fts; // fts αρχικοποιημένη λίστα FabricTypes χωρις reference fts!!!!
            //Console.WriteLine(fts.FabricTypes.Count); 
            //FabricTypeService fts2 = new FabricTypeService();
            //Console.WriteLine(fts2.FabricTypes.Count);

            FabricTypeService fabricTypeService = new FabricTypeService();
            
            FabricType cotton22 = new FabricType("Cotton");
            fabricTypeService.AddFabricType(cotton22); // add a new FabricType using a local variable
            fabricTypeService.AddFabricType(new FabricType("Cotton")); // add a new FabricType without a local variable


            foreach (var item in fabricTypeService.FabricTypes)
            {
                Console.WriteLine(item.Name);
            }

            Fabric fabric = new Fabric("Cotton", 10, Unit.Meters, new FabricType("Cotton"));
            Console.WriteLine(fabric);

        }
    }
}
