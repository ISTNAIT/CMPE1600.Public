using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_15
{
    struct SItem
    {
        string FirstName;
        string LastName;
        int Age;
        uint Icon;

        public SItem(string fName, string lName, int age, uint icon)
        {
            FirstName = fName;
            LastName = lName;
            Age = age;
            Icon = icon;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} ({2})", FirstName, LastName, Age.ToString());
        }

        public ListViewItem ToLVI()
        {
            ListViewItem lvi = new ListViewItem(FirstName);
            lvi.SubItems.Add(LastName);
            lvi.SubItems.Add(Age.ToString());
            return lvi;
        }
    }

  
}
