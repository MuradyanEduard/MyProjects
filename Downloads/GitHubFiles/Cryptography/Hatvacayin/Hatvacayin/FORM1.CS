using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hatvacayin
{
    public partial class Form1 : Form
    {
        String[] firstVar;
        String[] keyVar;
        String[] encryptedVar;
        String[] frcracVar;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.DefaultCellStyle.Font = new Font("Tahoma", 15);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (radioEsb.Checked)
            {
                MethodDecryptECB();
            }
            else if (radioCbc.Checked)
            {
                MethodDecryptCBC();
            }
            //else if (radioPbc.Checked)
            //{
            //    MessageBox.Show("ESB");
            //}
            //else if (radioCfb.Checked)
            //{
            //    MessageBox.Show("PBC");
            //}
        }

        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            if (radioEsb.Checked)
            {
                MethodEncryptECB();
            }
            else if (radioCbc.Checked)
            {
                MethodEncryptCBC();
            }
            //else if (radioPbc.Checked)
            //{
            //    MessageBox.Show("ESB");
            //}
            //else if (radioCfb.Checked)
            //{
            //    MessageBox.Show("PBC");
            //}

            return;
        }

        //ECB
        private void MethodEncryptECB()
        {
            String strRow1 = "", strRow2 = "", strRow3 = "", strRow4 = "";
            TextToBinary();

            encryptedVar = new String[firstVar.Length];
            frcracVar = new String[firstVar.Length];
            for (int i = 0; i < firstVar.Length; i++)
            {
                encryptedVar[i] = XorAscii(firstVar[i], keyVar[i]);
                frcracVar[i] = encryptedVar[i].Substring(1, encryptedVar[i].Length - 1) + encryptedVar[i].Substring(0, 1);
            }

            for (int i = 0; i < encryptedVar.Length; i++)
            {
                strRow1 = strRow1 + firstVar[i] + " ";
                strRow2 = strRow2 + keyVar[i] + " ";
                strRow3 = strRow3 + encryptedVar[i] + " ";
                strRow4 = strRow4 + frcracVar[i] + " ";
            }

            dataGridView1.Rows.Add(strRow1);
            dataGridView1.Rows.Add(strRow2);
            dataGridView1.Rows.Add(strRow3);
            dataGridView1.Rows.Add(strRow4);
            BinaryToText(frcracVar);
        }
        private void MethodDecryptECB()
        {
            String strRow1 = "", strRow2 = "", strRow3 = "", strRow4 = "";
            TextToBinary();

            frcracVar = new String[firstVar.Length];
            encryptedVar = new String[firstVar.Length];
            for (int i = 0; i < firstVar.Length; i++)
            {
                frcracVar[i] = firstVar[i].Substring(firstVar[i].Length - 1, 1) + firstVar[i].Substring(0, firstVar[i].Length - 1);
                encryptedVar[i] = XorAscii(frcracVar[i], keyVar[i]);
            }

            for (int i = 0; i < encryptedVar.Length; i++)
            {
                strRow1 = strRow1 + firstVar[i] + " ";
                strRow2 = strRow2 + frcracVar[i] + " ";
                strRow3 = strRow3 + keyVar[i] + " ";
                strRow4 = strRow4 + encryptedVar[i] + " ";
            }

            dataGridView1.Rows.Add(strRow1);
            dataGridView1.Rows.Add(strRow2);
            dataGridView1.Rows.Add(strRow3);
            dataGridView1.Rows.Add(strRow4);
            BinaryToText(encryptedVar);
        }
        //CBC
        private void MethodEncryptCBC()
        {
            String strRow1 = "", strRow2 = "", strRow3 = "", strRow4 = "";
            TextToBinary();

            {
                String endText = "", newText = "";
                for (int i = 0; i < firstVar.Length; i++)
                    newText = newText + firstVar[i];

                while (newText.Length > txtKey.Text.Length)
                {
                    endText = endText + " " + newText.Substring(0, txtKey.Text.Length);
                    newText = newText.Substring(txtKey.Text.Length);
                }

                if (!newText.Equals(""))
                {
                    while (newText.Length < keyVar[0].Length)
                        newText = "0" + newText;
                    endText = endText + " " + newText;
                }

                endText = endText.Substring(1);
                dataGridView1.Rows.Add(endText);
            }

            String beforeEncrypt = "";
            while (beforeEncrypt.Length < firstVar[0].Length)
                beforeEncrypt = beforeEncrypt + "0";

            encryptedVar = new String[firstVar.Length];
            frcracVar = new String[firstVar.Length];

            for (int i = 0; i < firstVar.Length; i++)
            {
                firstVar[i] = XorAscii(firstVar[i], beforeEncrypt);
                encryptedVar[i] = XorAscii(firstVar[i], keyVar[i]);
                frcracVar[i] = encryptedVar[i].Substring(1, encryptedVar[i].Length - 1) + encryptedVar[i].Substring(0, 1);
                beforeEncrypt = frcracVar[i];
            }

            for (int i = 0; i < encryptedVar.Length; i++)
            {
                strRow1 = strRow1 + firstVar[i] + " ";
                strRow2 = strRow2 + keyVar[i] + " ";
                strRow3 = strRow3 + encryptedVar[i] + " ";
                strRow4 = strRow4 + frcracVar[i] + " ";
            }

            dataGridView1.Rows.Add(strRow1);
            dataGridView1.Rows.Add(strRow2);
            dataGridView1.Rows.Add(strRow3);
            dataGridView1.Rows.Add(strRow4);
            BinaryToText(frcracVar);
        }
        private void MethodDecryptCBC()
        {
            String strRow1 = "", strRow2 = "", strRow3 = "", strRow4 = "";
            TextToBinary();

            String beforeEncrypt = "";
            while (beforeEncrypt.Length < firstVar[0].Length)
                beforeEncrypt = beforeEncrypt + "0";

            encryptedVar = new String[firstVar.Length];
            frcracVar = new String[firstVar.Length];

            for (int i = 0; i < firstVar.Length; i++)
            {
                frcracVar[i] = firstVar[i].Substring(firstVar[i].Length - 1,1) + firstVar[i].Substring(0, firstVar[i].Length - 1);
                encryptedVar[i] = XorAscii(frcracVar[i], keyVar[i]);

                String str = firstVar[i];
                firstVar[i] = XorAscii(encryptedVar[i], beforeEncrypt);
                beforeEncrypt = str;

            }

            for(int i = 0; i < firstVar.Length; i++)
            {
                strRow1 = strRow1 + frcracVar[i] + " ";
                strRow2 = strRow2 + keyVar[i] + " ";
                strRow3 = strRow3 + encryptedVar[i] + " ";
                strRow4 = strRow4 + firstVar[i] + " ";
            }

            dataGridView1.Rows.Add(strRow1);
            dataGridView1.Rows.Add(strRow2);
            dataGridView1.Rows.Add(strRow3);
            dataGridView1.Rows.Add(strRow4);
            BinaryToText(firstVar);
        }
        private String XorAscii(String a, String b)
        {
            String Answer = "";
            if (a.Length > b.Length)
            {
                while (a.Length > b.Length)
                    b = "0" + b;
            }
            else if (a.Length < b.Length)
            {
                while (a.Length < b.Length)
                    a = "0" + a;
            }

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(b[i]))
                    Answer = Answer + "0";
                else
                    Answer = Answer + "1";
            }

            return Answer;

        }
        private void TextToBinary()
        {
            String stringKey = "";
            String EndText = "";
            String strToAscii = "";

            for (int i = 0; i < txtText.Text.Length; i++)
            {
                String str = "";
                Char Symboll = txtText.Text[i];
                int SymbollToAscii = Symboll;
                strToAscii = strToAscii + SymbollToAscii.ToString() + " ";

                str = Convert.ToString(SymbollToAscii, 2);

                while (str.Length < 8)
                    str = "0" + str;

                EndText = EndText + str + " ";
            }

            dataGridView1.Rows.Add(strToAscii);
            dataGridView1.Rows.Add(EndText);
            EndText = EndText.Replace(" ", "");

            String newText = EndText;
            EndText = "";
            int countOfSyn = (txtText.Text.Length * 8) / txtKey.Text.Length;

            for (int i = 0; i < countOfSyn; i++)
            {
                EndText = EndText + " " + newText.Substring(0, txtKey.Text.Length);
                newText = newText.Substring(txtKey.Text.Length);
                stringKey = stringKey + " " + txtKey.Text;
            }

            if (!newText.Equals(""))
            {
                EndText = EndText + " " + newText;
                stringKey = stringKey + " " + txtKey.Text.Substring(0, newText.Length);
            }

            EndText = EndText.Substring(1);
            stringKey = stringKey.Substring(1);

            firstVar = EndText.Split(' ');
            keyVar = stringKey.Split(' ');

            //dataGridView1.Rows.Add(EndText);
            //dataGridView1.Rows.Add(stringKey);

        }
        private void BinaryToText(String[] bTTStr)
        {
            String newText = "";
            String endText = "";

            for (int i = 0; i < bTTStr.Length; i++)
                newText = newText + bTTStr[i];
            
            String strToAscii = "";

            endText = "";
            while (newText.Length > 8)
            {
                endText = endText + " " + newText.Substring(0, 8);
                newText = newText.Substring(8);
            }

            if (!newText.Equals(""))
                endText = endText + " " + newText;

            endText = endText.Substring(1);
            dataGridView1.Rows.Add(endText);

            String[] BnToTxt = endText.Split(' ');

            endText = "";
            for (int i = 0; i < BnToTxt.Length; i++)
            {
                int unicode = BinaryToDecimal(BnToTxt[i]);
                strToAscii = strToAscii + unicode.ToString() + " ";
                char character = (char)unicode;
                endText = endText + character.ToString();
            }
            dataGridView1.Rows.Add(strToAscii);
            txtReady.Text = endText;
        }
        private int BinaryToDecimal(String BnString)
        {
            int sum = 0, ba = 0;

            for (int i = BnString.Length - 1; i >= 0; i--)
            {

                if (BnString[i] == '1')
                {
                    if (ba == 0)
                        sum += 1;
                    else
                        sum += (int)Math.Pow(2, ba);
                }
                ba++;
            }

            return sum;
        }

    }
}
