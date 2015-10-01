using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Student : Person
    {
        private int _id;
        private double _GPA;
        //Constructor
        public Student(int id, string firstName, string lastName, double gpa, string email) : base(firstName, lastName, email)
        {
            _GPA = gpa;
            _id = id;

        }
        //Make First Name property
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        //Make First Name property
        public double GPA
        {
            get { return _GPA; }
            set { _GPA = value; }
        }
        public void display()
        {
            Console.WriteLine("ID         =" + _id);
            base.display();
            Console.WriteLine("GPA        =" + _GPA);
        }
    }
}

