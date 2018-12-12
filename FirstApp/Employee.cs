using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    public class Employee : Person, IPrint
    {
        public void Print()
        {
            Console.WriteLine("print employee");
        }

        public Employee()  //: base()
        {
        }
        
        public Employee(string name,int salary) : base(name)
        {
            Salary = salary;
        }


        private int salary;

        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        public sealed override int GetAge()
        {
            return (int)DateTime.Today.Subtract(BirthDate).TotalDays;
        }

        public override string GetJobSummary()
        {
            return "manage online shop";
        }

       
    }
}
