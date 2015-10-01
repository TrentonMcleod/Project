using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Person
    {
        //Fields or properties
        private string _firstName;
        private string _lastName;
        private string _email;

        //Constructor
        public Person(string firstName, string lastName, string email)
        {
            _firstName = firstName;
            _lastName = lastName;
            _email = email;
        }
        //Make First Name property
        public string FirsName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        //Make Last Name property
        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }
        //Make Last Name property
        public string email
        {
            get { return _email; }
            set { _email = value; }
        }

        public void display()
        {
            Console.WriteLine("First Name =" + _firstName);
            Console.WriteLine("Last Name  =" + _lastName);
            Console.WriteLine("Eamil      =" + _email);
        }
    }
}
