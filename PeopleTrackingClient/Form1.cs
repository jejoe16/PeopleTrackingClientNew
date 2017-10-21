using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PeopleTrackingClient
{
    public partial class Form1 : Form
        
    {
        User.User currentUser = new User.User();
        Check.Check checker = new Check.Check();
        String currentPoss;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checker.CheckIn(currentUser,currentPoss);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checker.CheckOut(currentUser, currentPoss);
        }
    }
}
