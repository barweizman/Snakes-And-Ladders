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
    public partial class frmWin : Form
    {
        public frmWin()
        {
            InitializeComponent();
        }

        private void frmWin_Load(object sender, EventArgs e)
        {
            lblWinnerName.Text = frmStart.winnerName;
        }
    }
}
