using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AxWMPLib;
using WMPLib;

namespace Rider
{
    public partial class ProductForm : Form
    {
        Point pt;
        public ProductForm()
        {
            InitializeComponent();
        }

        private void ProductForm_Load(object sender, EventArgs e)
        {

            pt.X = 0;
            pt.Y = 0;
            axWindowsMediaPlayer.Location = pt;
            axWindowsMediaPlayer.Width = this.Width;
            axWindowsMediaPlayer.Height = this.Height + 85;
            axWindowsMediaPlayer.URL = @"Product.mp4";
            axWindowsMediaPlayer.Ctlcontrols.play();
            axWindowsMediaPlayer.settings.volume = 100;

        }

        private void axWindowsMediaPlayer_KeyDownEvent(object sender, _WMPOCXEvents_KeyDownEvent e)
        {
            GoingNewForm();
        }

        private void axWindowsMediaPlayer_ClickEvent(object sender, _WMPOCXEvents_ClickEvent e)
        {
            GoingNewForm();
        }

        private void Tm1_Tick(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer.playState == WMPLib.WMPPlayState.wmppsStopped)
            {
                GoingNewForm();
            }
        }

        private void GoingNewForm()
        {
            Form ifrm = new StartMenu();
            ifrm.Show();
            this.Hide();
            axWindowsMediaPlayer.settings.volume = 0;
            Tm1.Enabled = false;
        }

    }
}
