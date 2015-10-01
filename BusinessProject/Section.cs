using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessProject
{
    class Section
    {
        //Feild
        private string _CRN;
        private string _CourseID;
        private string _TimeDays;
        private string _RoomNo;
        private int _Instructor;

          //Constructor
        public Section(string crn, string courseID, string timeDays, string RoomNo , int instructor) 
        {
            _CRN = crn;
            _CourseID = courseID;
            _TimeDays = timeDays;
            _RoomNo = RoomNo;
            _Instructor = instructor;
        }
        //Make ID property
        public string CRN
        {
            get { return _CRN; }
            set { _CRN = value; }
        }
        //Make ID property
        public string CourseID
        {
            get { return _CourseID; }
            set { _CourseID = value; }
        }
        //Make ID property
        public string TimeDays
        {
            get { return _TimeDays; }
            set { _TimeDays = value; }
        }
        //Make ID property
        public string RoomNo
        {
            get { return _RoomNo; }
            set { _RoomNo = value; }
        }
        //Make ID property
        public int Instructor
        {
            get { return _Instructor; }
            set { _Instructor = value; }
        }
        public void display()
        {
            Console.WriteLine("CRN           =" + _CRN);
            Console.WriteLine("Course ID     =" + _CourseID);
            Console.WriteLine("TimeDays      =" + _TimeDays);
            Console.WriteLine("Room Number   =" + _RoomNo);
            Console.WriteLine("Instructor    =" + _Instructor);
        }
    }
}
