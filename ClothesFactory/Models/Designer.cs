using DataStructures.Models;
using ClothesFactory.Services;
using DataStructures.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesFactory.Models
{
    public class Designer : IDesigner
    {

        public FabricService fabricService { get; set; }
        public TagService tagService { get; set; }
        public ProductService productService { get; set; }
        public List<Size> ProductSizes { get; set; }

        public Designer()
        {
            StartFactory(false);
        }

        public Designer(bool print)
        {
            StartFactory(print);
        }

        public void StartFactory(bool print)
        {
            StartFabricService(print);
            StartTagService(print);
            StartProductService(print);
            
        }

        public void StartFabricService(bool print)
        {
            fabricService = new FabricService();
            //fabricService.Fabrics.ForEach(Console.WriteLine);
        }

        public void StartTagService(bool print)
        {
            tagService = new TagService();
            //tagService.Tags.ForEach(Console.WriteLine);
        }

        public void StartProductService(bool print)
        {
            productService = new ProductService();
            ProductSizes = productService.GenerateProductSizes(DateTime.Now);
            // StartClothService <--- new ClothPrices()
            List<FabricCosts> fabricCosts = new List<FabricCosts>()
            {
                { new FabricCosts(new FabricType("Wool"), 2.5) },
                { new FabricCosts(new FabricType("Linen"), 3.5) }
            };
            ClothPrices coatSM = new ClothPrices(ClothTypes.COAT, fabricCosts, Size.SM);
        }

        // public Cloth GenerateCloth(Type, Size)
        public Cloth GenerateCloth(string type, Size size)
        {
            Cloth cloth = new Cloth();
            switch(type)
            {
                // DRY - DON'T REPEAT YOURSELF
                case "Coat-AAA":
                case "Coat-BBB":
                case "Coat-CCC":
                    // My 1st Product - Coat
                    cloth = GenerateCoat(type, size);
                    Console.WriteLine(cloth);

                    break;
                case "WomensJean-AAA":
                case "WomensJean-BBB":
                    // GenerateWomensJean(type, size);
                    break;

            }
            return cloth;
        }

        private Cloth GenerateCoat(string type, Size size)
        {
            // ProductType, Size, FabricType, Cost
            // Size M, Wool,3.5
            Fabric wool = new Fabric("Wool", 2.5, Unit.Meters,
                new FabricType("Wool"));
            Fabric linen = new Fabric("Linen", 3.5, Unit.Meters,
                new FabricType("Linen"));

            Fabric woolFromList = fabricService.Fabrics[fabricService.Fabrics.IndexOf(wool)];
            wool.Cost *= woolFromList.Cost;

            Fabric linenFromList = fabricService.Fabrics[fabricService.Fabrics.IndexOf(linen)];
            linen.Cost *= linenFromList.Cost;

            //Console.WriteLine($"Fabric Wool: {fabricService.Fabrics.IndexOf(wool)}");

            List<Fabric> fabrics = new List<Fabric>() { wool, linen };
            SizeNames sizeNames = new SizeNames();
            string sizeName = sizeNames.Names.ElementAt((int)size).Key;
            Tag tag = new Tag(sizeName, size, 0.05);
            Cloth coat = new Cloth(type,
                                    ProductSizes[ProductSizes.IndexOf(size)],
                                    fabrics, // I believe this is wrong and we need to change it!!!! like the other services
                                    8.5,
                                    tagService.Tags[tagService.Tags.IndexOf(tag)]);
            return coat;
        }
    }
}
