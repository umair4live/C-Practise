using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public class City
    {
        private Country country;

        public Country Country
        {
            get { return country; }
            set { country = value; }
        }



        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Details
        {
            get { return $"{id},{name},{Country.Name}"; }
        }



    }
}
