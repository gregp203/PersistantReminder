using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersistantReminder
{
    public partial class Alert : Form
    {
        String reminderMsg;

        public Alert(string _reminderMsg)
        {
            reminderMsg = _reminderMsg;
            InitializeComponent();
            label1.Text = reminderMsg;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
