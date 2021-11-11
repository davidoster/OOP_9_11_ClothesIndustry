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
    class Designer : IDesigner
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
            fabricService.Fabrics.ForEach(Console.WriteLine);
        }

        public void StartTagService(bool print)
        {
            tagService = new TagService();
            tagService.Tags.ForEach(Console.WriteLine);
        }

        public void StartProductService(bool print)
        {
            productService = new ProductService();
            ProductSizes = productService.GenerateProductSizes(DateTime.Now);

            Fabric wool = new Fabric("Wool", 2.5, Unit.Meters, new FabricType("Wool"));
            Fabric linen = new Fabric("Linen", 3.5, Unit.Meters, new FabricType("Linen"));

            List<Fabric> fabrics = new List<Fabric>() { wool, linen };
            Tag tag = new Tag("Small", Size.SM, 0.05);
            Cloth coat = new Cloth( "Coat", 
                                    ProductSizes[ProductSizes.IndexOf(Size.SM)], 
                                    fabrics, 
                                    8.5, 
                                    tagService.Tags[tagService.Tags.IndexOf(tag)]);
            Console.WriteLine(coat);
            
        }

        
    }
}
