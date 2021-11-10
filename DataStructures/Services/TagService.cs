using DataStructures.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Services
{
    public class TagService
    {

        public List<Size> GenerateTagSizes(DateTime year)
        {
            List<Size> result = new List<Size>();
            if (year.Year == 2021)
            {
                result = new List<Size>() { Size.SM, Size.M, Size.L };
            }

            if (year.Year == 2022)
            {
                result = new List<Size>() { Size.XS, Size.SM, Size.M, Size.L };
            }

            return result;
         }
    }
}
