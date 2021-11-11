using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public enum Size
    {
        XS, SM, M, L, XL
    }
    
    public class SizeNames
    {
        public Dictionary<string, Size> Names;

        public SizeNames()
        {
            Names = new Dictionary<string, Size> {  { "Extra Small",    Size.XS }, 
                                                    { "Small",          Size.SM },
                                                    { "Medium",         Size.M },
                                                    { "Large",          Size.L},
                                                    { "Extra Large",    Size.XL}

            };
        }
    }

}
