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
        private List<Tag> _tags;

        public List<Tag> Tags
        {
            get { return _tags; }
            private set { _tags = value; }
        }

        public TagService()
        {
            Tags = GenerateTags(DateTime.Now);
        }

        private List<Size> GenerateTagSizes(DateTime year)
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

        private List<Tag> GenerateTags(DateTime year)
        {
            List<Size> sizes = GenerateTagSizes(year);
            List<Tag> result = new List<Tag>();
            if (year.Year == 2021)
            {
                result = new List<Tag>() {  new Tag("Small", sizes[sizes.IndexOf(Size.SM)], 0.05),
                                            new Tag("Medium", sizes[sizes.IndexOf(Size.M)], 0.07),
                                            new Tag("Small", sizes[sizes.IndexOf(Size.L)], 0.09) 
                };
            }

            if (year.Year == 2022)
            {
                result = new List<Tag>() {  new Tag("Extra Small", sizes[sizes.IndexOf(Size.XS)], 0.03),
                                            new Tag("Small", sizes[sizes.IndexOf(Size.SM)], 0.05),
                                            new Tag("Medium", sizes[sizes.IndexOf(Size.M)], 0.07),
                                            new Tag("Large", sizes[sizes.IndexOf(Size.L)], 0.09) };
            }

            return result;
        }
    }
}
