using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrequencyAnalysis
{
    public partial class Form1 : Form
    {
        readonly String StrDefult = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//26;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            String Text = "";
            for (int i = 0; i < textBox.Text.Length; i++)
                if (!textBox.Text[i].Equals(' '))
                    Text = Text + textBox.Text[i];
            

            for (int i = 0; i < StrDefult.Length; i++)
            {
                int qanak = 0;
                for (int j = 0; j < Text.Length; j++)
                    if (Char.ToUpper(Text[j]).Equals(StrDefult[i]))
                        qanak++;

                dataGridView1.Rows.Add(StrDefult[i], Math.Round(((double)qanak / (double)Text.Length)*100,2));
            }
        } 

    }
}
