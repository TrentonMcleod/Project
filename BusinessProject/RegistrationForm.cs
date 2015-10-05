using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessProject
{
    public partial class RegistrationForm : Form
    {
    
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {

        }

        private void btnStudent_Click(object sender, EventArgs e)
        {
            Student student;
            student = new Student();
            student.SelectDB(2);
            student.display();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
             
            Instructor i1;
            i1 = new Instructor();
            i1.SelectDB(2);
            i1.display();

        }

        private void btnSection_Click(object sender, EventArgs e)
        {
            Section section = new Section("123", "404", "1400", "407", 4);
            section.display();
        }

        private void btnSchedule_Click(object sender, EventArgs e)
        {
            Schedule schedule = new Schedule();
            schedule.addsection(new Section("123", "404", "1400", "407", 4));
            schedule.addsection(new Section("125", "404", "1400", "407", 4));
            schedule.display();
        }
    }
}
