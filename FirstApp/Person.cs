using System;
using System.Collections.Generic;
using System.Text;

namespace FirstApp
{
    //public sealed class Person
    //public  class Person
    //public static class Person
    public abstract class Person : IEntity
    {
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


        public Person()
        {

        }

        public Person(string name)
        {
            Name = name;
        }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private DateTime birthDate;

        public DateTime BirthDate
        {
            get { return birthDate; }
            set { birthDate = value; }
        }

        private ContactNumber[] contactNumbers;

        public ContactNumber[] ContactNumbers
        {
            get { return contactNumbers; }
            set { contactNumbers = value; }
        }

        private Address address;

        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

       

        //not-overridable
        public string GetAuthor()
        {
            return "Dotnet342";
        }

        //overridable
        public virtual int GetAge()
        {
            return (int) (DateTime.Today.Subtract(birthDate).TotalDays / 365.25);
        }

        //must override 
        public abstract string GetJobSummary();

       
    }
}
