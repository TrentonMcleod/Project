using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Course 
    {
        //Feild
        private string _courseID;
        private string _courseName;
        private string _descriptioin;
        private int _creditHours;

        //Constructor
        public Course(string courseId, string courseName, string description, int creditHours) 
        {
            _courseID = courseId;
            _courseName = courseName;
            _descriptioin = description;
            _creditHours = creditHours;
        }
        //Make ID property
        public string CourseID
        {
            get { return _courseID; }
            set { _courseID = value; }
        }

        //Make Office Name property
        public string CourseName
        {
            get { return _courseName; }
            set { _courseName = value; }
        }
        //Make Office Name property
        public string Descriptioin
        {
            get { return _descriptioin; }
            set { _descriptioin = value; }
        }
        //Make Office Name property
        public int CreditHour
        {
            get { return _creditHours; }
            set { _creditHours = value; }
        }

        public void display()
        {
            Console.WriteLine("Course ID       =" + _courseID);
            Console.WriteLine("Course Name     =" + _courseName);
            Console.WriteLine("Description     =" + _descriptioin);
            Console.WriteLine("Credit Hours    =" + _creditHours);
        }
    }
}



