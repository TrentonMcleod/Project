using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Schedule will hold a list of sections
namespace BusinessProject
{
    class Schedule
    {
        List <Section> sectionList = new List <Section>();
         //will loop until the is noting left in the section        
        public void display()
        {
          foreach ( Section s1 in sectionList)
         {
             s1.display();
         }
        }
        public void addsection(Section s)
        {
            sectionList.Add(s);
        }
    }
}
