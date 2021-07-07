using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace librarymanager
{
    public partial class aboutapp : Form
    {
        public aboutapp()
        {
            InitializeComponent();
        }

        private void address_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
              address.LinkVisited = true;
            System.Diagnostics.Process.Start("iexplore.exe", "https://github.com/cewly/librarymanager");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
