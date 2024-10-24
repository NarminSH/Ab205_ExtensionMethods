using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ab205_ExtensionMethods.Models
{
    internal class Car
    {
        public string Brand { get; set; }
        public override string ToString()
        {
            return Brand;
        }
    }
}
