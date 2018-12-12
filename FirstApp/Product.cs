using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public class Product : IPrint, IEntity  
    {

        public void Print()
        {
            Console.WriteLine("print product");
        }

        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Load(int id)
        {
            throw new NotImplementedException();
        }





        private static int counter;

        public static int Counter
        {
            get {
                //float x = price;
                return counter;
            }
            //set { counter = value; }
        }

        static Product()
        {
            counter = 349;
        }

        public Product()
        {
            counter++;
        }

        public Product(int id,string name,float price) : this()
        {
            Id = id;
            Name = name;
            Price = price;
        }

        public Product(int id, string name, float price,string description) : this(id,name,price)
        {
            Description = description;
        }


        //private int abc;
        //public int Abc
        //{
        //    get { return abc; }
        //    set { abc = value; }
        //}

        //public int Abc { get; set; }

        //private string xyz;

        //public string Xyz
        //{
        //    get { return xyz; }
        //    set { xyz = value; }
        //}

        //public string Xyz { get; set; }





       

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        private float price;

        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                //int x = counter;
                if (value < 0)
                {
                    Console.WriteLine("Error");
                    return;
                }
                price = value;
            }
        }


        //public float GetPrice()
        //{
        //    return price;
        //}

        //public void SetPrice(float value)
        //{
        //    if (value < 0)
        //    {
        //        Console.WriteLine("Error");
        //        return;
        //    }
        //    price = value;
        //}

        private string description;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //drived properties
        public string Details
        {
            get { return $"{id},{name},{price},{description}"; }
        }
        
        //public void M1(int price,string p2)
        //{
        //    this.price = price;
        //    //some code here
        //}

        public void M1()
        {
            //some code here
        }

        public void M1(int p1)
        {
            //some code here
        }

        public void M1(int p1,string p2)
        {
            //some code here
        }

        public void M1(string p1)
        {
            //some code here
        }

        public void M1(string p1, int p2)
        {
            //some code here
        }

       
    }
}
