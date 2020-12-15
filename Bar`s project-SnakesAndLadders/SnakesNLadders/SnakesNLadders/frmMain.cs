using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakesNLadders
{
    public partial class frmMain : Form
    {
        public static string IPAddress, UserName, Port;
        public frmMain()
        {
            InitializeComponent();
        }

        private void lblEnter_Click(object sender, EventArgs e)
        {
            frmLogin f2 = new frmLogin();
            f2.ShowDialog();
            this.Hide();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void lblHelp_Click(object sender, EventArgs e)
        {
            frmHelp f2 = new frmHelp();
            f2.ShowDialog();
        }
    }
}
