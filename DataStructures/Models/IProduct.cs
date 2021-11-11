using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures.Models
{
    public interface IProduct
    {
        void GenerateProduct(string name, Size size, List<Fabric> fabrics, double labour, Tag tag);
    }
}
