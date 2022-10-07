using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace EduardsLibrary
{
    public partial class Form2 : Form
    {
        OleDbConnection OleConnection = null;
        string ConnectionString = "";
        public Form2()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
        }

        DataTable datatableTrain;

        int WCount = 1;
        int Wrong = 0, Right = 0;
        int Nummber;
        int RCount;
        int[] allow = new int[10]; 
        Random rnd = new Random();

        int[] matrixCol = new int[300];
        int col = 0;

        private void Form2_Load(object sender, EventArgs e)
        {           
            try
            {
                using (OleDbConnection connection = new OleDbConnection())
                {
                    ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Library.accdb;Mode = Share Deny None;" +
                    "Persist Security Info=False";
                    connection.ConnectionString = ConnectionString;

                    string strsql = "SELECT train.* FROM train;";
                    using (DataTable datatable = loadTable(strsql, ConnectionString))
                    {
                        datatableTrain = datatable;
                        GdTrain.DataSource = datatable;
                    }


                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }

            comboBox1.SelectedItem = "English";
            comboBox2.SelectedItem = "Armenia";

            RCount = GdTrain.RowCount - 1;

            label2.Text = "Right: " + Right.ToString();
            label3.Text = "Wrong: " + Wrong.ToString();

            Nummber = rnd.Next(0, RCount);
            label1.Text = RCount + ") " + (String)(GdTrain.Rows[Nummber].Cells["Word"].Value);

            //SNulya();
        }

        private DataTable loadTable(string strsql, string ConnectionString)
        {
            DataTable datatable = new DataTable();
            datatable.Locale = System.Globalization.CultureInfo.InvariantCulture;
            if (OleConnection == null)
            {
                OleConnection = new OleDbConnection();
                OleConnection.ConnectionString = ConnectionString;
                OleConnection.Open();
            }
            using (OleDbDataAdapter da = new OleDbDataAdapter(strsql, OleConnection))
            {
                da.Fill(datatable);
            }

            return datatable;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnOk.PerformClick();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (col == -1 || ((String)comboBox1.SelectedItem == (String)comboBox2.SelectedItem))
            {
                SNulya();
                label1.Text = "end";
                return;
            }

            Tm1.Stop();
            Tm1.Start();
            Red.Visible = false;
            Green.Visible = false;

            string str = LenguageBar(comboBox2);
            if ((String)(str) == WordBox.Text)
            {
                Green.Visible = true;
                Right++;
            }
            else
            {
                Red.Visible = true;
                listBox1.Items.Add(WCount.ToString() + ") " + (String)(GdTrain.Rows[Nummber].Cells["Word"].Value) + " - " + (String)(GdTrain.Rows[Nummber].Cells["TranslateRU"].Value) + " || " + (String)(GdTrain.Rows[Nummber].Cells["TranslateAM"].Value));
                Wrong++; WCount++;
            }

            WordBox.Text = "";
            FreeCount();

            label2.Text = "Right" + Right.ToString();
            label3.Text = "Wrong" + Wrong.ToString();

        }

        private String LenguageBar(ComboBox ComboBox)
        {
            String Cbox1 = (String)ComboBox.SelectedItem, str = "";
            switch (Cbox1)
            {
                case ("English"):
                    str = (String)(GdTrain.Rows[Nummber].Cells["Word"].Value);
                    break;
                case ("Russia"):
                    str = (String)(GdTrain.Rows[Nummber].Cells["TranslateRU"].Value);
                    break;
                case ("Armenia"):
                    str = (String)(GdTrain.Rows[Nummber].Cells["TranslateAM"].Value);
                    break;
            }

            return str;
        }

        private void SNulya()
        {
            int CountLesson = -1;
            for (int i = 0; i < LessonCheckBox.Items.Count; i++)
            {
                String str1 = (String)LessonCheckBox.Items[i];
                if (str1.Substring(0, 2) == "GT")
                {
                    int Cucich = 100;
                    for (int j = i; j < LessonCheckBox.Items.Count; j++)
                    {
                        Cucich = Cucich + 1;
                        CountLesson++;
                        allow[CountLesson] = Cucich;
                    }
                    break;
                }
                if (LessonCheckBox.GetItemChecked(i))
                {
                        CountLesson++;
                        allow[CountLesson] = i+1;
                }
            }

            WCount = 1;
            listBox1.Items.Clear();
            col = -1;
            for (int i = 0; i < RCount; i++)
            {
                GdTrain.Rows[i].Cells["TrueFalse"].Value = false;
                for (int j = 0; j <= CountLesson; j++)
                {
                    if(allow[j] == (int)GdTrain.Rows[i].Cells["Lesson"].Value)
                        GdTrain.Rows[i].Cells["TrueFalse"].Value = true;
                }

            }

            FreeCount();
        }

        private void FreeCount()
        {
            col = -1;
            for (int i = 0; i < RCount; i++)
            {
                if ((bool)GdTrain.Rows[i].Cells["TrueFalse"].Value == true)
                {
                    col++;
                    matrixCol[col] = i;
                }
            }

            if (col == -1)
            {
                label1.Text = "end";
                return;
            }

            Nummber = matrixCol[rnd.Next(0, col + 1)];
            string str = LenguageBar(comboBox1);
            label1.Text = col + ") " + str;
            GdTrain.Rows[Nummber].Cells["TrueFalse"].Value = false;
        }

        private void Tm_Tick(object sender, EventArgs e)
        {
            Red.Visible = false;
            Green.Visible = false;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                WCount = 1;
                listBox1.Items.Clear();
                label1.Text = "--------------";
                return;
            }
            SNulya();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == comboBox2.SelectedItem)
            {
                WCount = 1;
                listBox1.Items.Clear();
                label1.Text = "--------------";
                return;
            }
            SNulya();          
        }

        private void BtnRotate_Click(object sender, EventArgs e)
        {
            string str;
            str = (String)comboBox1.SelectedItem;
            comboBox1.SelectedItem = comboBox2.SelectedItem;
            comboBox2.SelectedItem = str;
        }

        private void btnCheckBox_Click(object sender, EventArgs e)
        {            
            SNulya();
        }

        private void LessonCheckBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            LessonCheckBox.SelectedItem = null;
        }
    }
}
