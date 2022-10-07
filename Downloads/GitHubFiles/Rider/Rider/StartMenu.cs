using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rider
{
    public partial class StartMenu : Form
    {
        Boolean endGame = true;
        Point mainMenuPt;
        public StartMenu()
        {
            InitializeComponent();
        }

        private void StartMenu_Load(object sender, EventArgs e)
        {
            mainMenuPt.X = this.Width - this.Width / 3 - 10;
            mainMenuPt.Y = 60;

            MainMenuPictureBox.Location = mainMenuPt;
            MainMenuPictureBox.Width = this.Width / 3;
            MainMenuPictureBox.Height = this.Height / 3;

            btnStart.Height =  (MainMenuPictureBox.Height) / 3;
            btnEnd.Height =  (MainMenuPictureBox.Height) / 3;

            btnStart.Width = MainMenuPictureBox.Width - 2*(MainMenuPictureBox.Width / 12);
            btnEnd.Width = MainMenuPictureBox.Width - 2*(MainMenuPictureBox.Width / 12);

            mainMenuPt.X = mainMenuPt.X + MainMenuPictureBox.Width/12;
            mainMenuPt.Y = mainMenuPt.Y + MainMenuPictureBox.Height/12;
            btnStart.Location = mainMenuPt;

            mainMenuPt.Y = mainMenuPt.Y + btnStart.Height;
            btnEnd.Location = mainMenuPt;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            endGame = false;
            Form ifrm = new FirstMap();
            Form ifrm1 = new ProductForm();
            ifrm.Show();
            ifrm1.Close();
            this.Close();
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void StartMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(endGame)
                Environment.Exit(1);
        }


    }
}
