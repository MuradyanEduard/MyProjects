using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.IO;

namespace MailImitator
{
    public partial class Form1 : Form
    {
        int CountOfMessage;
        string path = "C:\\Users\\eduar_yctz87f\\Downloads\\1.xls";

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //labelPersent.Visible = true;
            pBar.Visible = true;
            pBar.Minimum = 0;
            pBar.Step = 1;

            Int32.TryParse(textBoxCount.Text, out CountOfMessage);
            pBar.Maximum = CountOfMessage;

            for (int i = 0; i < CountOfMessage; i++)
            {
                //labelPersent.Text = (int)(((float)i / (float)CountOfMessage) * 100) + "%";

                Attachment sendfile;
                var fromAddress = new MailAddress("tester013019@gmail.com", "From Name");
                var toAddress = new MailAddress(textBoxWhere.Text, "To Name");
                const string fromPassword = "q1w2e3r4zqxwcevr11";
                pBar.Value++;

                var smtp = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)

                };

                if (checkBoxAuto.Checked)
                {
                    File.Move("x" + i + ".xls", "x" + (i + 1) + ".xls");
                    path = System.IO.Path.GetDirectoryName(Application.ExecutablePath) + "\\x" + (i + 1) + ".xls";
                     sendfile = new Attachment(path);
                }
                else
                     sendfile = new Attachment(path);

                using (var message = new MailMessage(fromAddress, toAddress))
                {
                    message.Attachments.Add(sendfile);
                    smtp.Send(message);
                }

            }

            if (checkBoxAuto.Checked)
            {
                File.Move("x" + CountOfMessage + ".xls", "x0.xls");
            }

           // labelPersent.Visible = false;
            pBar.Visible = false;
            MessageBox.Show("End");
            pBar.Value = 0;
            //labelPersent.Text = "0%";
        }

        private void buttonDefMail_Click(object sender, EventArgs e)
        {
            textBoxWhere.Text = "tester01302019@mail.ru";
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                path = openFileDialog1.FileName;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (!checkBoxAuto.Checked)
                btnOpenFile.Enabled = true;
            else
                btnOpenFile.Enabled = false;
        }
    }
}

/*
            using (var message = new MailMessage(fromAddress, toAddress, subject, body)
            {
               SmtpClient mailClient = new SmtpClient("smtp.gmail.com", 587);
            mailClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            System.Net.NetworkCredential mailAuthentication = new System.Net.NetworkCredential("tester013019@gmail.com", "q1w2e3r4zqxwcevr11");
            mailClient.Credentials = mailAuthentication;
            mailClient.EnableSsl = true;
            mailClient.UseDefaultCredentials = false;
            mailClient.Send(message);

        }

            */





        /*
          using (
        Using message As _

New MailMessage(fromAddress, toAddress, subject, body)

Dim mailClient As New SmtpClient("smtp.gmail.com", 587)

mailClient.DeliveryMethod = SmtpDeliveryMethod.Network

Dim mailAuthentication As System.Net.NetworkCredential

mailAuthentication = New System.Net.NetworkCredential _

("myUsername@gmail.com", "ValidPassword") //loose the domain part

mailClient.Credentials = mailAuthentication

mailClient.EnableSsl = True

mailClient.UseDefaultCredentials = False

mailClient.Send(message)

End Using
 */


    
