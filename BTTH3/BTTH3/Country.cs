using System;
using System.Collections.Generic;
using System.Text;

namespace BTTH3
{
    public class Country : List<City>
    {
        public string countryName { get; set; }
        public string description { get; set; }
        public Country (string name)
        {
            countryName = name;
        }
    }
}
