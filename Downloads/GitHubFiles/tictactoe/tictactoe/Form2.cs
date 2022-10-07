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
    public partial class Form2 : Form
    {
        int startPos = 20;
        int fieldCount = 10;
        int squareSize;
        int fieldSize;
        int turnXO = 1;
        Boolean endGame = true;

        List<tictactoe> xlist = new List<tictactoe>();
        List<tictactoe> olist = new List<tictactoe>();

        public Form2(int p)
        {
            InitializeComponent();

            fieldCount = p;

            panelGame.Width = 350;
            panelGame.Height = 350;

            panelGame.Left = 12;
            panelGame.Top = 49;
        }

        private void panelGame_Paint(object sender, PaintEventArgs e)
        {
            int dx = startPos,
            dy = startPos;

            Pen myPen = new Pen(Color.Black);
            myPen.Width = 2;

            fieldSize = panelGame.Width - 2 * startPos;
            squareSize = fieldSize / fieldCount;
            fieldSize = squareSize * fieldCount;

            for (int i = 0; i < fieldCount + 1; i++)
            {
                e.Graphics.DrawLine(myPen, startPos + i * squareSize, startPos, startPos + i * squareSize, (fieldSize + startPos));
                e.Graphics.DrawLine(myPen, startPos, startPos + i * squareSize, (fieldSize + startPos), startPos + i * squareSize);
            }

            int chap = squareSize / 10;

            for (int i = 0; i < xlist.Count; i++)
            {
                dx = xlist[i].PosX * squareSize + startPos;
                dy = xlist[i].PosY * squareSize + startPos;

                myPen = new Pen(Color.Red);
                myPen.Width = 2;
                e.Graphics.DrawLine(myPen, dx + chap, dy + chap, dx + squareSize - chap, dy + squareSize - chap);
                e.Graphics.DrawLine(myPen, dx + chap, dy + squareSize - chap, dx + squareSize - chap, dy + chap);

            }

            for (int i = 0; i < olist.Count; i++)
            {

                dx = olist[i].PosX * squareSize + startPos;
                dy = olist[i].PosY * squareSize + startPos;

                myPen = new Pen(Color.Blue);
                myPen.Width = 2;
                e.Graphics.DrawEllipse(myPen, dx + chap / 2, dy + chap / 2, squareSize - chap, squareSize - chap);

            }
        }

        private void panelGame_Click(object sender, EventArgs e)
        {
            if (endGame)
            {
                MessageBox.Show("Click on Start!");
                return;
            }

            Point point = panelGame.PointToClient(Cursor.Position);

            if (point.X < startPos || point.X > fieldSize + startPos || point.Y < startPos || point.Y > startPos + fieldSize)
            {
                MessageBox.Show("chika");
                return;
            }


            int dx = (point.X - startPos) / squareSize;
            int dy = (point.Y - startPos) / squareSize;

            for (int i = 0; i < xlist.Count; i++)
                if (xlist[i].PosX == dx && xlist[i].PosY == dy)
                {
                    MessageBox.Show("chika");
                    return;
                }

            for (int i = 0; i < olist.Count; i++)
                if (olist[i].PosX == dx && olist[i].PosY == dy)
                {
                    MessageBox.Show("chika");
                    return;
                }

            if (turnXO == 1)
            {
                turnXO = 0;
                tictactoe t1 = new tictactoe();
                t1.PosX = dx;
                t1.PosY = dy;
                xlist.Add(t1);
            }
            else
            {
                turnXO = 1;
                tictactoe t1 = new tictactoe();
                t1.PosX = dx;
                t1.PosY = dy;
                olist.Add(t1);
            }

            panelGame.Invalidate();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/levon.mkrtchyan.54");
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[0].Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            endGame = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            xlist.Clear();
            olist.Clear();
            panelGame.Invalidate();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
           this.Close();
        }

    }
}
