using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public struct ContactNumber
    {
        public ContactNumber(short nc, int num) : this(92,nc,num)
        {
        }

        public ContactNumber(short cc,short nc,int num)
        {
            countryCode = cc;
            networkCode = nc;
            number = num;
        }


        private short countryCode;

        public short CountryCode
        {
            get { return countryCode; }
        }

        private short networkCode;

        public short NetworkCode
        {
            get { return networkCode; }
        }

        private int number;
        public int Number
        {
            get { return number; }
        }

        public string FullNumber
        {
            get { return $"+{countryCode}-{networkCode}-{number}"; }
        }

        //public void DoX()
        //{
        //    //some code here
        //}


    }
}
