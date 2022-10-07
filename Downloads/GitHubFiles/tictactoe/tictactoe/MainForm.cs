using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tictactoe
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            openNewForm(9);
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            openNewForm(5);
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            openNewForm(3);
        }


        private void openNewForm(int Count) {
            Form ifrm = new Form2(Count);
            ifrm.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }



    }
}
