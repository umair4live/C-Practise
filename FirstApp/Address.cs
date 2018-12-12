using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public class Address
    {
        private string streetAddress;

        public string StreetAddress
        {
            get { return streetAddress; }
            set { streetAddress = value; }
        }

        private City city;

        public City City
        {
            get { return city; }
            set { city = value; }
        }


        public Country Country
        {
            get { return city.Country; }
            set { city.Country = value; }
        }

        public string FullAddress
        {
            get { return $"{streetAddress},{city.Name},{Country.Name}"; }
        }




    }
}
