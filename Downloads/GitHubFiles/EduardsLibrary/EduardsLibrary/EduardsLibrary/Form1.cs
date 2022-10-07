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
    public partial class Form1 : Form
    {

        OleDbConnection OleConnection = null;

        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
        }

        int Nummber = 0;
        DataTable datatableVerb;       
        DataTable datatableNoun;       
        DataTable datatableAdjective;   
        DataTable datatableAdverb;
        string ConnectionString = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (OleDbConnection connection = new OleDbConnection())
                {
                    ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Library.accdb;" +
                    "Persist Security Info = False;";
                    connection.ConnectionString = ConnectionString;
                    connection.Open();
                    Refresh();                  
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to connect to data source");
            }

        }

        private void Refresh()
        {
            string strsql;
            strsql = "SELECT verb.* FROM verb;";
            SetTable(strsql, GdVerb);
            strsql = "SELECT adverb.* FROM adverb;";
            SetTable(strsql, GdAdverb);
            strsql = "SELECT noun.* FROM noun;";
            SetTable(strsql, GdNoun);
            strsql = "SELECT adjective.* FROM adjective;";
            SetTable(strsql, GdAdjective);
        }

        private void SetTable(string strsql,DataGridView GridView)
        {           
            using (DataTable datatable = loadTable(strsql, ConnectionString))
                GridView.DataSource = datatable;
        }
         
        private void DoRecordset(string strsql, string ConnectionString)
        {
            using (OleDbCommand CmdCommand3 = new OleDbCommand(strsql))
            {
                if (OleConnection == null)
                {
                    OleConnection = new OleDbConnection();
                    OleConnection.ConnectionString = ConnectionString;
                    OleConnection.Open();
                }
                CmdCommand3.Connection = OleConnection;
                CmdCommand3.ExecuteNonQuery();
            }
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

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            String StrSearch = TxtSearch.Text;
            String[] str = new String[4];
            int nom1=0, nom2=0;

            switch (Nummber)
            {
                case 1:
                    str[0] = " - Verb ";str[1] = " - Noun ";str[2] = " - Adverb ";str[3] = " - Adjective ";
                    nom1 = 2;nom2 = 3;
                    break;                   
                case 2:
                    str[0] = " - Глагол ";str[1] = " - Существительное ";str[2] = " - Наречие ";str[3] = " - Прилагательное ";
                    nom1 = 1;nom2 = 3;                   
                    break;
                case 3:
                    str[0] = " - Բայ ";str[1] = " - Գոյական ";str[2] = " - Մակբայ ";str[3] = " - Ածական ";
                    nom1 = 1;nom2 = 2;
                    break;
            }

            int n = GdVerb.RowCount;
            for (int i = 0; i < n; i++)
            {
                if (datatableVerb.Rows[i][Nummber].ToString() == StrSearch)
                {
                    TxtBox.Text = "  " + StrSearch + str[0] + "\r\n 1)" + datatableVerb.Rows[i][nom1].ToString() + "\r\n 2)" + datatableVerb.Rows[i][nom2].ToString();
                }
            }

             n = GdNoun.RowCount;
             for (int i = 0; i < n; i++)
             {
                 if (datatableNoun.Rows[i][Nummber].ToString() == StrSearch)
                 {
                     TxtBox.Text = "  " + StrSearch + str[1] +"\r\n 1)" + datatableNoun.Rows[i][nom1].ToString() + "\r\n 2)" + datatableNoun.Rows[i][nom2].ToString();
                 }
             }
             n = GdAdverb.RowCount;
             for (int i = 0; i < n; i++)
             {
                 if (datatableAdverb.Rows[i][Nummber].ToString() == StrSearch)
                 {
                     TxtBox.Text = "  " + StrSearch + str[2] + "\r\n 1)" + datatableAdverb.Rows[i][nom1].ToString() + "\r\n 2)" + datatableAdverb.Rows[i][nom2].ToString();
                 }
             }
             n = GdAdjective.RowCount;
             for (int i = 0; i < n; i++)
             {
                 if (datatableAdjective.Rows[i][Nummber].ToString() == StrSearch)
                 {
                     TxtBox.Text = "  " + StrSearch + str[3] + "\r\n 1)" + datatableAdjective.Rows[i][nom1].ToString() + "\r\n 2)" + datatableAdjective.Rows[i][nom2].ToString();
                 }
             }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) BtnSearch.PerformClick();
        }

        private void btnArm_Click(object sender, EventArgs e)
        {
            Nummber = 3;
        }

        private void btnRu_Click(object sender, EventArgs e)
        {
            Nummber = 2;
        }

        private void btnEng_Click(object sender, EventArgs e)
        {
            Nummber = 1;
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (TxtAddEng.Text.ToString() == "" || TxtAddRu.Text.ToString() == "" || TxtAddAm.Text.ToString() == "" || AddSpreachBox.Text == "Sellect a spreach")
                return;
            string strsql = "INSERT INTO " + AddSpreachBox.Text + " (Word, translateRU, translateAM) VALUES ('" + TxtAddEng.Text + "', '" + TxtAddRu.Text + "', '" + TxtAddAm.Text + "')"; 

            DoRecordset(strsql, ConnectionString);            
            TxtAddEng.Text= "" ;
            TxtAddRu.Text= "" ;
            TxtAddAm.Text= "" ;
            AddSpreachBox.Text = "Sellect a spreach";
            checkBox1.Checked = false;
            Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TxtId.Text.ToString() == "" || DelSpreachBox.Text == "Sellect a spreach")
                return;
            string ID = TxtId.Text.ToString();
            string strsql = "DELETE " + DelSpreachBox.Text + ".* FROM " + DelSpreachBox.Text + " WHERE ((" + DelSpreachBox.Text + ".id)=" + ID + ")";
            DoRecordset(strsql, ConnectionString);
            DelSpreachBox.Text = "";
            TxtId.Text = "";        
            checkBox2.Checked = false;
            Refresh();
        }
        
        private void GdVerb_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          /*  if (GdVerb.CurrentRow == null)
                return;
            string ID = GdVerb.CurrentRow.Cells["id"].Value.ToString();
            string word = GdVerb.CurrentRow.Cells["word"].Value.ToString();
            string strsql = "UPDATE verb SET verb.Word = '" + word + "'" +
            " WHERE (((verb.id)=" + ID + "))";
            DoRecordset(strsql, ConnectionString);
            SetVerb();
        */}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                TxtAddEng.Visible = true;
                TxtAddRu.Visible = true;
                TxtAddAm.Visible = true;
                butAdd.Visible = true;
                AddSpreachBox.Visible = true;
            }
            else
            {
                TxtAddEng.Visible = false;
                TxtAddRu.Visible = false;
                TxtAddAm.Visible = false;
                butAdd.Visible = false;
                AddSpreachBox.Visible = false;
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                DelSpreachBox.Visible = true;
                TxtId.Visible = true;
                butDEL.Visible = true;
            }
            else
            {
                DelSpreachBox.Visible = false;
                TxtId.Visible = false;
                butDEL.Visible = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                title1.Visible = true;
                title2.Visible = true;
                title3.Visible = true;
                title4.Visible = true;
                GdNoun.Visible = true;
                GdAdjective.Visible = true;
                GdVerb.Visible = true;
                GdAdverb.Visible = true; 
            }
            else
            {
                title1.Visible = false;
                title2.Visible = false;
                title3.Visible = false;
                title4.Visible = false;
                GdNoun.Visible = false;
                GdAdjective.Visible = false;
                GdVerb.Visible = false;
                GdAdverb.Visible = false;
            }
               
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 MyForm2 = new Form2();
 //           Form1.ActiveForm.Hide();
            MyForm2.Show();
        }     
    }
}
