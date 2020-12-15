using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;

namespace SnakesNLadders
{
    public partial class frmLogin : Form
    {
        public static string username;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtIP.Text != "" && txtPort.Text != "" && txtName.Text != "")
            {
                this.Hide();
                frmMain.IPAddress = txtIP.Text;
                frmMain.Port = txtPort.Text;
                frmMain.UserName = txtName.Text;
                username = txtName.Text;
                frmStart f2 = new frmStart(); // שומר את כל הנתונים שהוזנו
                f2.Show();
                
            }
            else
                MessageBox.Show("עלייך למלא את כל הנתונים");
            
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            IPAddress[] LocalIPs = Dns.GetHostAddresses(Dns.GetHostName());
            txtIP.Text = Convert.ToString(LocalIPs[LocalIPs.Length - 1]);
            // txtIP.Text = "127.0.0.1"; 
        }

        private void lblExitlogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
