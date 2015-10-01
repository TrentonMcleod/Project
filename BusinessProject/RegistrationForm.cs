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
            Student student = new Student(1, "Jane", "Doe", 3.75, "janedoe@yahoo.com");
            student.display();
        }

        private void btnInstructor_Click(object sender, EventArgs e)
        {
            Instructor instructor = new Instructor(1, "John", "Doe", "1234", "Johndoe@yahoo.com");
            instructor.display();
        }
    }
}
