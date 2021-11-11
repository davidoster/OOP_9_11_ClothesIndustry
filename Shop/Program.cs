using DataStructures.Models;
using ClothesFactory.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            //List<Cloth> clothes = new List<Cloth>();
            //clothes.Add(new Cloth());
            Designer designer = new Designer();
            designer.GenerateCloth("Coat-AAA", Size.SM);
            //designer.GenerateCloth("Coat-BBB", Size.M);
            //designer.GenerateCloth("Coat-CCC", Size.L);
        }
    }
}
