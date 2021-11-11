using DataStructures.Models;
using ClothesFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothesFactory.Services
{
    interface IDesigner
    {
        void StartFactory(bool print);
        void StartFabricService(bool print);
        void StartTagService(bool print);
        void StartProductService(bool print);
        Cloth GenerateCloth(string type, Size size);
    }
}
