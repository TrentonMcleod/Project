using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Instructor : Person
    {
        //Feild
        private int _id;
        private string _office;

        //Constructor
        public Instructor(int id, string firstName, string lastName, Address address, string office, string email) : base(firstName, lastName, address, email)
        {
            _id = id;
            _office = office;
        }
        //Make ID property
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }

        //Make Office Name property
        public string Office
        {
            get { return _office; }
            set { _office = value; }
        }

        public void display()
        {
            Console.WriteLine("ID         =" + _id);
            //This is pulling from the Person
            base.display();
            Console.WriteLine("Office     =" + _office);
        }
    }
}

