using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Services
{
    public class ProductService
    {

        public List<Size> GenerateProductSizes(DateTime year)
        {
            List<Size> result = new List<Size>();
            if (year.Year == 2021)
            {
                result = new List<Size>() { Size.XS, Size.SM, Size.M, Size.L, Size.XL};
            }

            if (year.Year == 2022)
            {
                result = new List<Size>() { Size.XS, Size.SM, Size.M, Size.L, Size.XL }; // Size.XXL
            }

            return result;
         }
    }
}
