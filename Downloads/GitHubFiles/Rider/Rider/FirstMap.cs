using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Rider
{
    public partial class FirstMap : Form
    {
        Random rnd = new Random();
        Boolean simpleGraph = false;

        //Units
        MapArenaUnit Rider = new MapArenaUnit();
        MapArenaUnit[] Knight = new MapArenaUnit[20];
        int knightsUnitsCount = 20;
        int numOfPosDeleteUnit = -1;

        //Map
        int mapSquareLength = 150, mapSquareHeight = 150;
        int currentMapPosX = -1, currentMapPosY = -1;
        int mapX = 6000, mapY = 6000;
        int qayl = 20;
        const int mapCountX = 70, mapCountY = 30;

        int[] mapVisibleArray = new int[144];
        int mapVisibleArrayQanak = -1;

        //MiniMap
        Rectangle rectMiniMap, rect1, rect2;

        //MiniMapRadar
        int miniMapSquareLength = -1, miniMapSquareHeight = -1;
        int miniMapRadarLenght = -1, miniMapRadarHeight = -1;

        float miniMapRadarPosX = -1, miniMapRadarPosY = -1;

        float qaylMinX = 20, qaylMinY = 20;

        //landscape
        readonly string[] landscapeNames = { "tree", "stone", "sea", "grass", "platform", "stepgrass", "steplatform" };
        int[] landscape = new int[mapCountX * mapCountY];
        int[] unexploredTerrain = new int[mapCountX * mapCountY];

        Bitmap[] bpVisibleLandscape = new Bitmap[7];
        Bitmap[] bpInVisibleLandscape = new Bitmap[5];

        //Buttons ConsoleBox
        Point ptWorker, ptInWorker, consolePoint;
        int workerClearArray = -1;

        //Chits
        Boolean mapHack = false;
        public FirstMap()
        {
            InitializeComponent();
        }

        private void FirstMap_Load(object sender, EventArgs e)
        {
            //Map
            mapSquareLength = this.Width / 13;
            mapSquareHeight = this.Height / 7;

            //landscape
            for (int i = 0; i < landscape.Length; i++)
            {
                landscape[i] = rnd.Next(0, 1900 + 1);

                if (landscape[i] <= 900)
                {
                    if (landscape[i] <= 300)
                    {
                        landscape[i] = 9;
                    }
                    else if (landscape[i] > 300 && landscape[i] <= 600)
                    {
                        landscape[i] = 8;
                    }
                    else
                    {
                        landscape[i] = 7;
                    }
                }
                else
                    landscape[i] = 10;
            }

            for (int i = 0; i < 7; i++)
            {
                String str = landscapeNames[i] + ".png";
                bpVisibleLandscape[i] = new Bitmap(Path.Combine(@"Pictures\Landscape\VisibleArray", str));
                bpVisibleLandscape[i] = new Bitmap(bpVisibleLandscape[i], new Size(mapSquareLength, mapSquareHeight));
            }


            for (int i = 0; i < 5; i++)
            {
                String str = landscapeNames[i] + ".png";
                bpInVisibleLandscape[i] = new Bitmap(Path.Combine(@"Pictures\Landscape\InVisibleArray", str));
                bpInVisibleLandscape[i] = new Bitmap(bpInVisibleLandscape[i], new Size(mapSquareLength, mapSquareHeight));
            }

            //UnexploredTerrain
            for (int i = 0; i < unexploredTerrain.Length; i++)
                unexploredTerrain[i] = 0;

            currentMapPosX = -13 * mapSquareLength;
            mapX = mapSquareLength * mapCountX;
            mapY = mapSquareHeight * mapCountY;

            //MiniMap
            rectMiniMap.X = 13 * mapSquareLength - 4 * mapSquareLength;
            rectMiniMap.Y = this.Height - 2 * mapSquareHeight;
            rectMiniMap.Width = (int)((4 * mapSquareLength - 20) / mapCountX) * mapCountX;
            rectMiniMap.Height = (int)((2 * mapSquareHeight - 20) / mapCountY) * mapCountY;

            float MiniMapMashtabX = (float)rectMiniMap.Width / (float)mapX;
            float MiniMapMashtabY = (float)rectMiniMap.Height / (float)mapY;

            qaylMinX = qayl * (float)MiniMapMashtabX;
            qaylMinY = qayl * (float)MiniMapMashtabY;

            miniMapSquareLength = rectMiniMap.Width / mapCountX;
            miniMapSquareHeight = rectMiniMap.Height / mapCountY;

            miniMapRadarPosX = rectMiniMap.X;
            miniMapRadarPosY = rectMiniMap.Y;
            miniMapRadarLenght = (int)(13 * miniMapSquareLength);
            miniMapRadarHeight = (int)(7 * miniMapSquareHeight);

            //rider
            Rider.bpNomCount = 9;
            Rider.bpCurrentNom = 8;
            int dy, dx;
            while (true)
            {
                Rider.currentPos = rnd.Next(0, mapCountX * mapCountY);
                dy = Rider.currentPos / mapCountX;
                dx = Rider.currentPos - dy * mapCountX;
                if (landscape[Rider.currentPos] == 10)
                {
                    currentMapPosX = -13 * mapSquareLength + (-dx + 6) * mapSquareLength;
                    currentMapPosY = (-dy + 3) * mapSquareHeight;

                    miniMapRadarPosX = rectMiniMap.X + (dx - 6) * miniMapSquareLength;
                    miniMapRadarPosY = rectMiniMap.Y + (dy - 3) * miniMapSquareHeight;

                    break;
                }
            }

            Rider.miniMapPos.X = rectMiniMap.X + dx * miniMapSquareLength;
            Rider.miniMapPos.Y = rectMiniMap.Y + dy * miniMapSquareHeight;
            Rider.pt.X = dx * mapSquareLength;
            Rider.pt.Y = dy * mapSquareHeight;

            for (int i = 0; i < Rider.bpNomCount; i++)
            {
                String str = "H" + i.ToString() + ".png";
                Rider.bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Rider\Right\", str));
                Rider.bpUnit[i] = new Bitmap(Rider.bpUnit[i], new Size(mapSquareLength, mapSquareHeight));
            }

            //Knight
            for (int j = 0; j < knightsUnitsCount; j++)
                Knight[j] = new MapArenaUnit();

            for (int j = 0; j < knightsUnitsCount; j++)
            {
                Knight[j].bpCurrentNom = 9;
                Knight[j].bpNomCount = 10;
                while (true)
                {
                    Knight[j].currentPos = rnd.Next(0, mapCountX * mapCountY);
                    dy = Knight[j].currentPos / mapCountX;
                    dx = Knight[j].currentPos - dy * mapCountX;
                    if (landscape[Knight[j].currentPos] == 10)
                    {
                        for (int i = 0; i < j; i++)
                            if (Knight[j].currentPos == Knight[i].currentPos)
                                goto Outer;

                        if (Knight[j].currentPos == Rider.currentPos)
                            goto Outer;

                        UnitBorderCondition(Knight[j].currentPos, Knight[j].unitControlArray, ref Knight[j].unitControlArrayCount, 4);
                        break;
                    }
                Outer:;
                }

                Knight[j].miniMapPos.X = rectMiniMap.X + dx * miniMapSquareLength;
                Knight[j].miniMapPos.Y = rectMiniMap.Y + dy * miniMapSquareHeight;
                Knight[j].pt.X = dx * mapSquareLength;
                Knight[j].pt.Y = dy * mapSquareHeight;

                for (int i = 0; i < Knight[j].bpNomCount; i++)
                {
                    String str = "K" + i.ToString() + ".png";
                    Knight[j].bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Knight\Right\", str));
                    Knight[j].bpUnit[i] = new Bitmap(Knight[j].bpUnit[i], new Size(mapSquareLength, mapSquareHeight));
                }
            }
            //Workers buttons
            ptWorker.X = rectMiniMap.X;
            ptWorker.Y = rectMiniMap.Y - (mapSquareHeight / 2) - 5;

            BtnWorker.Size = new Size(mapSquareLength / 2, mapSquareHeight / 2);
            BtnWorker.Location = ptWorker;

            BtnRemove.Size = new Size(mapSquareLength / 6, mapSquareHeight / 6);
            BtnRemove.Location = ptWorker;

            ptInWorker.X = rectMiniMap.X;
            ptInWorker.Y = rectMiniMap.Y - mapSquareHeight - 5;

            BtnAxe.Size = new Size(mapSquareLength / 2, mapSquareHeight / 2);
            BtnAxe.Location = ptInWorker;
            ptInWorker.X = ptInWorker.X + mapSquareLength / 2 + 5;
            BtnPick.Size = new Size(mapSquareLength / 2, mapSquareHeight / 2);
            BtnPick.Location = ptInWorker;
            ptInWorker.X = ptInWorker.X + mapSquareLength / 2 + 5;
            BtnShovel.Size = new Size(mapSquareLength / 2, mapSquareHeight / 2);
            BtnShovel.Location = ptInWorker;
            ptInWorker.X = ptInWorker.X + mapSquareLength / 2 + 5;
            BtnHummer.Size = new Size(mapSquareLength / 2, mapSquareHeight / 2);
            BtnHummer.Location = ptInWorker;

            ptInWorker.Y = rectMiniMap.Y - mapSquareHeight - 5;

            //Console
            consolePoint.X = 5;
            consolePoint.Y = this.Height / 12;
            ConsoleBox.Location = consolePoint;
            ConsoleBox.Width = this.Width / 3;
            consolePoint.X = consolePoint.X + ConsoleBox.Width;
            BtnConsole.Location = consolePoint;

            RefreshMaps();

            //harmaravetutyun
            ConsoleBox.Text = "Gods";
            Cheats();

        }

        private void easyGraph_CheckedChanged(object sender, EventArgs e)
        {
            if (simpleGraph)
                simpleGraph = false;
            else
                simpleGraph = true;
        }

        //Console
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (ConsoleBox.Visible == false)
                {
                    ConsoleBox.Visible = true;
                    BtnConsole.Visible = true;
                    this.ActiveControl = ConsoleBox;
                    return;
                }
            }

        }
        private void ConsoleBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Cheats();
        }
        private void BtnConsole_Click(object sender, EventArgs e)
        {
            Cheats();
        }
        private void Cheats()
        {
            if (ConsoleBox.Text.Equals("Gods"))
            {
                mapHack = true;
                for (int i = 0; i < unexploredTerrain.Length; i++)
                {
                    if (landscape[i] > 6)
                        landscape[i] = landscape[i] - 7;
                    unexploredTerrain[i] = 1;
                }

            }

            ConsoleBox.Text = "";
            this.ActiveControl = textBox2;
            ConsoleBox.Visible = false;
            BtnConsole.Visible = false;
            return;
        }
        //Workers buttons
        private void BtnWorker_Click(object sender, EventArgs e)
        {
            BtnPick.Visible = true;
            BtnAxe.Visible = true;
            BtnShovel.Visible = true;
            BtnHummer.Visible = true;
            workerClearArray = -1;
            BtnRemove.Visible = true;
        }
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            RefreshButtons();
            BtnPick.Visible = false;
            BtnAxe.Visible = false;
            BtnShovel.Visible = false;
            BtnHummer.Visible = false;

            BtnRemove.Visible = false;
        }
        private void BtnPick_Click(object sender, EventArgs e)
        {
            RefreshButtons();
            BtnPick.BackColor = Color.Yellow;
            workerClearArray = 1;
        }
        private void BtnAxe_Click(object sender, EventArgs e)
        {
            RefreshButtons();
            BtnAxe.BackColor = Color.Yellow;
            workerClearArray = 0;
        }
        private void BtnShovel_Click(object sender, EventArgs e)
        {
            RefreshButtons();
            BtnShovel.BackColor = Color.Yellow;
            workerClearArray = 5;
        }
        private void BtnHummer_Click(object sender, EventArgs e)
        {
            RefreshButtons();
            BtnHummer.BackColor = Color.Yellow;
            workerClearArray = 2;
        }
        private void RefreshButtons()
        {
            BtnPick.BackColor = Color.Tomato;
            BtnShovel.BackColor = Color.Tomato;
            BtnHummer.BackColor = Color.Tomato;
            BtnAxe.BackColor = Color.Tomato;
            workerClearArray = -1;
        }

        //Unit Control Array
        private void UnitBorderCondition(int unitPos, int[] unitBorderArray, ref int unitBorderQanak, int qaylQanak)
        {
            int dx1, dx2;
            unitBorderQanak = -1;

            dx1 = unitPos;
            for (int i = 0; i < qaylQanak; i++)
            {
                if (dx1 % mapCountX == 0)
                    dx1 = dx1 + mapCountX;

                dx1--;
            }

            for (int i = 0; i < qaylQanak; i++)
            {
                if (dx1 - mapCountX < 0)
                    break;

                dx1 = dx1 - mapCountX;
            }

            dx2 = unitPos;
            for (int i = 0; i < qaylQanak; i++)
            {
                if (dx2 % mapCountX == mapCountX - 1)
                    dx2 = dx2 - mapCountX;

                dx2++;
            }

            for (int i = 0; i < qaylQanak; i++)
            {
                if (dx2 + mapCountX > (mapCountX * mapCountY) - 1)
                    break;

                dx2 = dx2 + mapCountX;
            }

            int kubikqayl = 2 * qaylQanak;

            while (true)
            {
                int skizb = dx1;

                unitBorderQanak++;
                unitBorderArray[unitBorderQanak] = dx1;

                for (int i = 0; i < kubikqayl; i++)
                {
                    if (dx1 % mapCountX == mapCountX - 1)
                        dx1 = dx1 - mapCountX;

                    dx1++;
                    unitBorderQanak++;
                    unitBorderArray[unitBorderQanak] = dx1;
                }
                if (dx1 == dx2)
                    break;
                else
                    dx1 = skizb + mapCountX;
            }
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            this.ActiveControl = textBox2;

            if (Rider.unitActive)
                return;

            for (int i = 0; i < knightsUnitsCount; i++)
                if (Knight[i].unitActive)
                    return;


            int NumPosY, NumPosX;

            Point CursorPoint = new Point();
            CursorPoint.X = Cursor.Position.X;
            CursorPoint.Y = Cursor.Position.Y;


            if (!rectMiniMap.Contains(CursorPoint))
            {

                NumPosX = (Math.Abs(currentMapPosX) + CursorPoint.X) / mapSquareLength;

                if (NumPosX < 13)
                    NumPosX = NumPosX + mapCountX - 13;
                else if (NumPosX >= mapCountX + 13)
                    NumPosX = NumPosX - mapCountX - 13;
                else
                    NumPosX = NumPosX - 13;

                NumPosY = (int)((Math.Abs(currentMapPosY) + CursorPoint.Y) / mapSquareHeight);
                Rider.newPos = NumPosY * mapCountX + NumPosX;

                //Worker Active
                if (workerClearArray != -1 && Rider.currentPos != Rider.newPos)
                {
                    for (int k = 0; k <= Rider.unitControlArrayCount; k++)
                    {
                        if (Rider.newPos == Rider.unitControlArray[k] && landscape[Rider.newPos] == workerClearArray)
                        {
                            switch (workerClearArray)
                            {
                                case 2:
                                    landscape[Rider.newPos] = 6;
                                    break;
                                case 5:
                                    landscape[Rider.newPos] = 2;
                                    break;
                                default:
                                    landscape[Rider.newPos] = 5;
                                    break;
                            }

                            BtnPick.Visible = false;
                            BtnAxe.Visible = false;
                            BtnShovel.Visible = false;
                            BtnHummer.Visible = false;
                            RefreshButtons();
                            BtnRemove.Visible = false;
                            KnightsActiveCondition();
                            return;
                        }
                    }

                }

                if (Rider.currentPos == Rider.newPos || workerClearArray != -1 || (landscape[Rider.newPos] != 5 && landscape[Rider.newPos] != 6))
                    return;

                Boolean QaylStugox = false;
                for (int i = 0; i <= Rider.unitControlArrayCount; i++)
                {
                    if (Rider.unitControlArray[i] == Rider.newPos)
                        QaylStugox = true;
                }

                if (!QaylStugox)
                    return;

                for (int i = 0; i < knightsUnitsCount; i++)
                    if (Knight[i].currentPos == Rider.newPos)
                    {
                        Rider.currentPos = Rider.newPos;
                        BattleArrayOpen(i);
                        return;
                    }

                UnitMoveStart(Rider);
                Rider.unitActive = true;
                Rider.bpCurrentNom = 0;

                if (Rider.moveX < 0)
                {
                    for (int i = 0; i < Rider.bpNomCount; i++)
                    {
                        String str = "H" + i.ToString() + ".png";
                        Rider.bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Rider\Left\", str));
                        Rider.bpUnit[i] = new Bitmap(Rider.bpUnit[i], new Size(mapSquareLength, mapSquareHeight));
                    }
                }
                else if (Rider.moveX > 0)
                {
                    for (int i = 0; i < Rider.bpNomCount; i++)
                    {
                        String str = "H" + i.ToString() + ".png";
                        Rider.bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Rider\Right\", str));
                        Rider.bpUnit[i] = new Bitmap(Rider.bpUnit[i], new Size(mapSquareLength, mapSquareHeight));
                    }
                }

                return;
            }

            NumPosY = (int)((CursorPoint.Y - rectMiniMap.Y) / miniMapSquareHeight);
            NumPosX = (int)((CursorPoint.X - rectMiniMap.X) / miniMapSquareLength);

            currentMapPosX = -13 * mapSquareLength + (-NumPosX + 6) * mapSquareLength;
            currentMapPosY = (-NumPosY + 3) * mapSquareHeight;

            miniMapRadarPosX = rectMiniMap.X + (NumPosX - 6) * miniMapSquareLength;
            miniMapRadarPosY = rectMiniMap.Y + (NumPosY - 3) * miniMapSquareHeight;

            MapsBorderCondition(CursorPoint.X, CursorPoint.Y);

            RefreshUnits();

        }

        private void UnitMoveStart(MapArenaUnit unit)
        {
            int dy = unit.currentPos / mapCountX;
            int dx = unit.currentPos - dy * mapCountX;
            int newdy = unit.newPos / mapCountX;
            int newdx = unit.newPos - newdy * mapCountX;
            int stugox = 0;

            while (true)
            {

                dx--;
                stugox++;

                if (dx == -1)
                    dx = mapCountX - 1;

                if (dx == newdx)
                    break;

                if (stugox == mapCountX / 2)
                {
                    stugox = 0;
                    break;
                }
            }

            if (stugox == 0)
            {

                dx = unit.currentPos - dy * mapCountX;
                newdx = unit.newPos - newdy * mapCountX;

                while (true)
                {
                    if (dx == newdx)
                        break;

                    dx++;
                    stugox++;

                    if (dx == mapCountX)
                        dx = 0;

                }
                unit.moveX = (stugox * mapSquareLength / unit.unitVx) * unit.unitVx;
            }
            else
                unit.moveX = -1 * (stugox * mapSquareLength / unit.unitVx) * unit.unitVx;

            unit.moveY = (((newdy - dy) * mapSquareHeight) / unit.unitVx) * unit.unitVx;

        }
        private void TmMap_Tick(object sender, EventArgs e)
        {
            if (Rider.unitActive)
                return;

            for (int i = 0; i < knightsUnitsCount; i++)
                if (Knight[i].unitActive)
                    return;


            int CurrentMousePosX = Cursor.Position.X;
            int CurrentMouseposY = Cursor.Position.Y;

            MoveMap(CurrentMousePosX, CurrentMouseposY);
            MapsBorderCondition(CurrentMousePosX, CurrentMouseposY);
            MiniMapBorderCondition();

            RefreshUnits();

        }
        private void MiniMapBorderCondition()
        {
            if (miniMapRadarPosX < rectMiniMap.X)
                rect1 = new Rectangle(rectMiniMap.X, (int)miniMapRadarPosY, (int)(miniMapRadarLenght - (rectMiniMap.X - miniMapRadarPosX)), miniMapRadarHeight);
            else if (miniMapRadarPosX + miniMapRadarLenght > rectMiniMap.X + rectMiniMap.Width)
                rect1 = new Rectangle((int)miniMapRadarPosX, (int)miniMapRadarPosY, (int)((rectMiniMap.X + rectMiniMap.Width) - miniMapRadarPosX), miniMapRadarHeight);
            else
                rect1 = new Rectangle((int)miniMapRadarPosX, (int)miniMapRadarPosY, miniMapRadarLenght, miniMapRadarHeight);

            if (miniMapRadarPosX - (mapCountX * miniMapSquareLength) + miniMapRadarLenght > rectMiniMap.X)
                rect2 = new Rectangle(rectMiniMap.X, (int)miniMapRadarPosY, (int)(miniMapRadarPosX - (mapCountX * miniMapSquareLength) + miniMapRadarLenght) - rectMiniMap.X, miniMapRadarHeight);
            else if (miniMapRadarPosX < rectMiniMap.X)
                rect2 = new Rectangle((int)miniMapRadarPosX + (mapCountX * miniMapSquareLength), (int)miniMapRadarPosY, (int)((rectMiniMap.X + rectMiniMap.Width) - (miniMapRadarPosX + (mapCountX * miniMapSquareLength))), miniMapRadarHeight);
            else
                rect2 = new Rectangle(0, 0, 0, 0);
        }
        private void MapsBorderCondition(int CurrentMousePosX, int CurrentMouseposY)
        {
            //x os granici
            if (currentMapPosX > 1)
            {
                currentMapPosX = -mapX;
                miniMapRadarPosX = rectMiniMap.X + (mapCountX - 13) * miniMapSquareLength;
            }
            else if (currentMapPosX < -13 * mapSquareLength - mapX)
            {
                currentMapPosX = -13 * mapSquareLength - 1;
                miniMapRadarPosX = rectMiniMap.X;
            }
            //y os granici
            if (currentMapPosY > 1)
            {
                currentMapPosY = 1;
                miniMapRadarPosY = rectMiniMap.Y;
            }
            else if (currentMapPosY - 7 * mapSquareHeight < -mapY)
            {
                currentMapPosY = -mapY + 7 * mapSquareHeight + 1;
                miniMapRadarPosY = rectMiniMap.Y + ((mapCountY * miniMapSquareHeight) - miniMapRadarHeight);
            }

        }
        private void MoveMap(int CurrentMousePosX, int CurrentMouseposY)
        {
            //x os
            if (CurrentMousePosX < 1)
            {
                currentMapPosX = currentMapPosX + qayl;
                miniMapRadarPosX = miniMapRadarPosX - qaylMinX;
            }
            else if ((CurrentMousePosX > (13 * mapSquareLength - 2)))
            {
                currentMapPosX = currentMapPosX - qayl;
                miniMapRadarPosX = miniMapRadarPosX + qaylMinX;
            }

            //y os 
            if (CurrentMouseposY < 1)
            {
                currentMapPosY = currentMapPosY + qayl;
                miniMapRadarPosY = miniMapRadarPosY - qaylMinY;
            }
            else if ((CurrentMouseposY > (7 * mapSquareHeight - 20)))
            {
                miniMapRadarPosY = miniMapRadarPosY + qaylMinY;
                currentMapPosY = currentMapPosY - qayl;
            }
        }

        private void TmUnits_Tick(object sender, EventArgs e)
        {
            Invalidate();

            for (int i = 0; i < knightsUnitsCount; i++)
                if (Knight[i].unitActive)
                    UnitMoveCondition(Knight[i], 9);



            if (Rider.unitActive)
            {
                Rider.bpCurrentNom++;
                if (Rider.bpCurrentNom == Rider.bpNomCount - 1)
                    Rider.bpCurrentNom = 0;

                int dx = (Math.Abs(currentMapPosX) + Rider.pt.X) / mapSquareLength;

                if (dx < 13)
                    dx = dx + mapCountX - 13;
                else if (dx >= mapCountX + 13)
                    dx = dx - mapCountX - 13;
                else
                    dx = dx - 13;

                int dy = Rider.currentPos / mapCountX;

                Rider.miniMapPos.X = rectMiniMap.X + dx * miniMapSquareLength;
                Rider.miniMapPos.Y = rectMiniMap.Y + dy * miniMapSquareHeight;

                UnitMoveCondition(Rider, 8);

                if (!Rider.unitActive)
                    KnightsActiveCondition();

            }

        }

        private void KnightsActiveCondition()
        {
            for (int i = 0; i < knightsUnitsCount; i++)
                for (int j = 0; j < Knight[i].unitControlArrayCount; j++)
                    if (Rider.currentPos == Knight[i].unitControlArray[j])
                    {

                        if (WayCondition(Knight[i].currentPos, Rider.currentPos, i).Equals(""))
                            break;

                        String[] Chanaparh = WayCondition(Knight[i].currentPos, Rider.currentPos, i).Split(' ');

                        if (Chanaparh.Length < 3)
                        {
                            BattleArrayOpen(i);
                            return;
                        }
                        Knight[i].currentPos = Int32.Parse(Chanaparh[0]);
                        Knight[i].newPos = Int32.Parse(Chanaparh[1]);
                        Knight[i].bpCurrentNom = 0;
                        Knight[i].unitActive = true;

                        UnitMoveStart(Knight[i]);

                        break;
                    }

            RefreshUnits();
            RefreshMaps();
            Rider.bpCurrentNom = 8;

        }
        private String WayCondition(int skizb, int verch, int knightIndex)
        {

            int ShurjStugoxTaracqQanak = 0;
            int[] ShurjStugoxTaracq = new int[9];
            int index = 0;
            int[] StugvoxTaracqPayman = new int[81];
            int[] QartezStugoxTaracq = new int[mapCountX * mapCountY];
            String[] WayToUnit = new String[mapCountX * mapCountY];


            for (int i = 0; i < QartezStugoxTaracq.Length; i++)
            {
                if ((landscape[i] >= 3 && landscape[i] <= 6) || landscape[i] == 10 || landscape[i] == 11)
                    QartezStugoxTaracq[i] = 0;
                else
                    QartezStugoxTaracq[i] = -10;
                WayToUnit[i] = "";
            }

            StugvoxTaracqPayman[0] = skizb;
            WayToUnit[skizb] = skizb.ToString();

            for (int i = 0; i <= index; i++)
            {
                UnitBorderCondition(StugvoxTaracqPayman[i], ShurjStugoxTaracq, ref ShurjStugoxTaracqQanak, 1);
                for (int k = 0; k <= ShurjStugoxTaracqQanak; k++)
                {
                    if (QartezStugoxTaracq[ShurjStugoxTaracq[k]] < 0)
                        continue;
                    else
                    {

                        for (int j = 0; j <= Knight[knightIndex].unitControlArrayCount; j++)
                            if (Knight[knightIndex].unitControlArray[j] == ShurjStugoxTaracq[k])
                            {
                                if (QartezStugoxTaracq[ShurjStugoxTaracq[k]] == 1 || ShurjStugoxTaracq[k] == skizb)
                                    break;

                                index++;
                                StugvoxTaracqPayman[index] = ShurjStugoxTaracq[k];
                                QartezStugoxTaracq[ShurjStugoxTaracq[k]] = 1;
                                WayToUnit[ShurjStugoxTaracq[k]] = WayToUnit[StugvoxTaracqPayman[i]] + " " + ShurjStugoxTaracq[k].ToString();

                                if (ShurjStugoxTaracq[k] == verch)
                                    return WayToUnit[verch];

                                break;
                            }
                    }

                }

            }



            return "";
        }
        private void UnitMoveCondition(MapArenaUnit unit, int numOfUnitBp)
        {
            unit.bpCurrentNom++;
            if (unit.bpCurrentNom == unit.bpNomCount - 1)
                unit.bpCurrentNom = 0;

            if (unit.moveX < 0)
            {
                unit.pt.X = unit.pt.X - unit.unitVx;
                unit.moveX = unit.moveX + unit.unitVx;
            }
            else if (unit.moveX > 0)
            {
                unit.pt.X = unit.pt.X + unit.unitVx;
                unit.moveX = unit.moveX - unit.unitVx;
            }

            if (unit.moveY < 0)
            {
                unit.pt.Y = unit.pt.Y - unit.unitVx;
                unit.moveY = unit.moveY + unit.unitVx;
            }
            else if (unit.moveY > 0)
            {
                unit.pt.Y = unit.pt.Y + unit.unitVx;
                unit.moveY = unit.moveY - unit.unitVx;
            }

            if (unit.moveX == 0 && unit.moveY == 0)
            {
                unit.currentPos = unit.newPos;
                unit.unitActive = false;
                unit.bpCurrentNom = numOfUnitBp;
            }

        }
        private void RefreshUnits()
        {
            //rider
            Rider.pt.X = currentMapPosX + ((Rider.currentPos - mapCountX * (Rider.currentPos / mapCountX)) * mapSquareLength + 13 * mapSquareLength); //hishel
            Rider.pt.Y = currentMapPosY + (mapSquareHeight * (Rider.currentPos / mapCountX));//hishel

            int dy = Rider.currentPos / mapCountX;
            int dx = Rider.currentPos - dy * mapCountX;
            Rider.miniMapPos.X = rectMiniMap.X + dx * miniMapSquareLength;
            Rider.miniMapPos.Y = rectMiniMap.Y + dy * miniMapSquareHeight;

            for (int j = 0; j < knightsUnitsCount; j++)
            {
                Knight[j].pt.X = currentMapPosX + ((Knight[j].currentPos - mapCountX * (Knight[j].currentPos / mapCountX)) * mapSquareLength + 13 * mapSquareLength); //hishel
                Knight[j].pt.Y = currentMapPosY + (mapSquareHeight * (Knight[j].currentPos / mapCountX));//hishel

                dy = Knight[j].currentPos / mapCountX;
                dx = Knight[j].currentPos - dy * mapCountX;
                Knight[j].miniMapPos.X = rectMiniMap.X + dx * miniMapSquareLength;
                Knight[j].miniMapPos.Y = rectMiniMap.Y + dy * miniMapSquareHeight;
            }
        }
        private void RefreshMaps()
        {
            if (!mapHack)
            {
                for (int i = 0; i < landscape.Length; i++)
                    if (landscape[i] < 5)
                        landscape[i] = landscape[i] + 7;
                    else if (landscape[i] == 5 || landscape[i] == 6)
                        landscape[i] = landscape[i] - 2 + 7;

                UnitBorderCondition(Rider.currentPos, mapVisibleArray, ref mapVisibleArrayQanak, 5);
                for (int k = 0; k <= mapVisibleArrayQanak; k++)
                {
                    landscape[mapVisibleArray[k]] = landscape[mapVisibleArray[k]] - 7;
                    unexploredTerrain[mapVisibleArray[k]] = 1;
                }

            }
            else
            {
                for (int i = 0; i < landscape.Length; i++)
                    if (landscape[i] > 6)
                        landscape[i] = landscape[i] - 7;
                    else if (landscape[i] == 5 || landscape[i] == 6)
                        landscape[i] = landscape[i] - 2;
            }


            UnitBorderCondition(Rider.currentPos, Rider.unitControlArray, ref Rider.unitControlArrayCount, 1);
            for (int k = 0; k <= Rider.unitControlArrayCount; k++)
                if (landscape[Rider.unitControlArray[k]] == 3 || landscape[Rider.unitControlArray[k]] == 4)
                    landscape[Rider.unitControlArray[k]] = landscape[Rider.unitControlArray[k]] + 2;
        }
        private void BattleArrayOpen(int NumDeleteUnit)
        {
            RefreshMaps();
            numOfPosDeleteUnit = NumDeleteUnit;
            Form ifrm = new FightArena();
            ifrm.Show();
            this.Hide();
            StreamWriter myfile = new StreamWriter(@"Events\ResultOfFidht.dll", false);
            myfile.Write("");
            myfile.Close();
            TmResultOfBattle.Enabled = true;
            TmUnits.Enabled = false;
            TmMap.Enabled = false;
        }
        private void TmResultOfBattle_Tick(object sender, EventArgs e)
        {
            using (var f = File.OpenText(@"Events\ResultOfFidht.dll"))
            {
                while (!f.EndOfStream)
                {
                    var line = f.ReadLine();
                    if (line.Equals("win"))
                    {
                        Knight[numOfPosDeleteUnit] = Knight[knightsUnitsCount - 1];
                        Knight[knightsUnitsCount - 1] = null;
                        knightsUnitsCount--;

                        TmUnits.Enabled = true;
                        TmMap.Enabled = true;
                        TmResultOfBattle.Enabled = false;
                        MessageBox.Show("win");
                        return;
                    }
                    else if (line.Equals("lose"))
                    {
                        TmUnits.Enabled = true;
                        TmMap.Enabled = true;
                        TmResultOfBattle.Enabled = false;
                        MessageBox.Show("lose");
                    }
                }
            }


        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            int dx = currentMapPosX
                , dy = currentMapPosY;

            Rectangle r;

            Pen PenSquare = new Pen(Color.Black, 2);
            int ba = mapCountX - 14;

            //Map
            for (int j = 0; j < mapCountY; j++)
            {
                ba = mapCountX - 14 + j * mapCountX;
                for (int i = 0; i < (26 + mapCountX); i++)
                {
                    ba++;
                    r = new Rectangle(dx, dy, mapSquareLength, mapSquareHeight);
                    //e.Graphics.DrawRectangle(PenSquare, r);

                    if (i == 13)
                        ba = 0 + j * mapCountX;
                    else if (i == 13 + mapCountX)
                        ba = 0 + j * mapCountX;


                    //landscape
                    if (unexploredTerrain[ba] == 1)
                    {
                        if (simpleGraph)
                            switch (landscape[ba])
                            {
                                case 0:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Red), r);
                                    break;
                                case 1:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightGray), r);
                                    break;
                                case 2:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.LightSkyBlue), r);
                                    break;
                                case 3:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.ForestGreen), r);
                                    break;
                                case 4:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Peru), r);
                                    break;
                                case 5:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Lime), r);
                                    break;
                                case 6:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.PeachPuff), r);
                                    break;
                                case 7:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Maroon), r);
                                    break;
                                case 8:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Gray), r);
                                    break;
                                case 9:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.Navy), r);
                                    break;
                                case 10:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.DarkGreen), r);
                                    break;
                                case 11:
                                    e.Graphics.FillRectangle(new SolidBrush(Color.SaddleBrown), r);
                                    break;
                            }
                        else
                            switch (landscape[ba])
                            {
                                case 0:
                                    e.Graphics.DrawImage(bpVisibleLandscape[0], dx, dy);
                                    break;
                                case 1:
                                    e.Graphics.DrawImage(bpVisibleLandscape[1], dx, dy);
                                    break;
                                case 2:
                                    e.Graphics.DrawImage(bpVisibleLandscape[2], dx, dy);
                                    break;
                                case 3:
                                    e.Graphics.DrawImage(bpVisibleLandscape[3], dx, dy);
                                    break;
                                case 4:
                                    e.Graphics.DrawImage(bpVisibleLandscape[4], dx, dy);
                                    break;
                                case 5:
                                    e.Graphics.DrawImage(bpVisibleLandscape[5], dx, dy);
                                    break;
                                case 6:
                                    e.Graphics.DrawImage(bpVisibleLandscape[6], dx, dy);
                                    break;
                                case 7:
                                    e.Graphics.DrawImage(bpInVisibleLandscape[0], dx, dy);
                                    break;
                                case 8:
                                    e.Graphics.DrawImage(bpInVisibleLandscape[1], dx, dy);
                                    break;
                                case 9:
                                    e.Graphics.DrawImage(bpInVisibleLandscape[2], dx, dy);
                                    break;
                                case 10:
                                    e.Graphics.DrawImage(bpInVisibleLandscape[3], dx, dy);
                                    break;
                                case 11:
                                    e.Graphics.DrawImage(bpInVisibleLandscape[4], dx, dy);
                                    break;
                            }
                    }
                    else
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), r);

                    //e.Graphics.DrawString(MapArr[ba].ToString(),
                    //                new Font(new FontFamily("Helvetica"), 25, FontStyle.Regular, GraphicsUnit.Point),
                    //                new SolidBrush(Color.Black), dx, dy);

                    dx = dx + mapSquareLength;
                }
                dy = dy + mapSquareHeight;
                dx = currentMapPosX;
            }

            //BlackBorders
            for (int i = 0; i < (26 + mapCountX); i++)
            {
                e.Graphics.DrawLine(PenSquare, currentMapPosX + i * mapSquareLength, currentMapPosY, currentMapPosX + i * mapSquareLength, currentMapPosY + mapY);
            }

            for (int i = 0; i < mapCountY; i++)
            {
                e.Graphics.DrawLine(PenSquare, currentMapPosX, currentMapPosY + i * mapSquareHeight, currentMapPosX + mapX, currentMapPosY + i * mapSquareHeight);
            }

            //rider      
            int RP = (int)(Rider.currentPos / mapCountX);
            RP = Rider.currentPos - RP * mapCountX;
            e.Graphics.DrawImage(Rider.bpUnit[Rider.bpCurrentNom], Rider.pt);
            if (RP < 13)
                e.Graphics.DrawImage(Rider.bpUnit[Rider.bpCurrentNom], Rider.pt.X + mapCountX * mapSquareLength, Rider.pt.Y);
            else if (RP > mapCountX - 13)
                e.Graphics.DrawImage(Rider.bpUnit[Rider.bpCurrentNom], Rider.pt.X - mapCountX * mapSquareLength, Rider.pt.Y);

            //knight      
            for (int j = 0; j < knightsUnitsCount; j++)
            {
                int UP = (int)(Knight[j].currentPos / mapCountX);
                UP = Knight[j].currentPos - UP * mapCountX;
                e.Graphics.DrawImage(Knight[j].bpUnit[Knight[j].bpCurrentNom], Knight[j].pt);
                if (UP < 13)
                    e.Graphics.DrawImage(Knight[j].bpUnit[Knight[j].bpCurrentNom], Knight[j].pt.X + mapCountX * mapSquareLength, Knight[j].pt.Y);
                else if (UP > mapCountX - 13)
                    e.Graphics.DrawImage(Knight[j].bpUnit[Knight[j].bpCurrentNom], Knight[j].pt.X - mapCountX * mapSquareLength, Knight[j].pt.Y);
            }

            //MiniMap
            PenSquare = new Pen(Color.Gray, 2);
            r = new Rectangle(rectMiniMap.X, rectMiniMap.Y, rectMiniMap.Width, rectMiniMap.Height);
            e.Graphics.DrawRectangle(PenSquare, r);
            e.Graphics.FillRectangle(new SolidBrush(Color.Gray), r);

            ba = -1;
            for (int j = 0; j < mapCountY; j++)
            {
                for (int i = 0; i < mapCountX; i++)
                {
                    ba++;

                    dx = rectMiniMap.X + i * miniMapSquareLength;
                    dy = rectMiniMap.Y + j * miniMapSquareHeight;
                    e.Graphics.DrawRectangle(PenSquare, dx, dy, miniMapSquareLength, miniMapSquareHeight);
                    r = new Rectangle(dx, dy, miniMapSquareLength, miniMapSquareHeight);
                    if (unexploredTerrain[ba] == 1)
                        switch (landscape[ba])
                        {
                            case 0:
                            case 7:
                                e.Graphics.FillRectangle(new SolidBrush(Color.Brown), r);
                                break;
                            case 1:
                            case 8:
                                e.Graphics.FillRectangle(new SolidBrush(Color.Gray), r);
                                break;
                            case 2:
                            case 9:
                                e.Graphics.FillRectangle(new SolidBrush(Color.Navy), r);
                                break;
                            case 3:
                            case 4:
                            case 5:
                            case 6:
                            case 10:
                            case 11:
                                e.Graphics.FillRectangle(new SolidBrush(Color.Green), r);
                                break;
                        }
                    else
                        e.Graphics.FillRectangle(new SolidBrush(Color.Black), r);
                }
            }

            PenSquare = new Pen(Color.Red, 2);
            e.Graphics.DrawRectangle(PenSquare, rect1);
            e.Graphics.DrawRectangle(PenSquare, rect2);

            //riderminimap
            r = new Rectangle(Rider.miniMapPos.X, Rider.miniMapPos.Y, miniMapSquareLength, miniMapSquareHeight);
            e.Graphics.FillRectangle(new SolidBrush(Color.White), r);

            //knightminimap
            for (int j = 0; j < knightsUnitsCount; j++)
            {
                r = new Rectangle(Knight[j].miniMapPos.X, Knight[j].miniMapPos.Y, miniMapSquareLength, miniMapSquareHeight);
                e.Graphics.FillRectangle(new SolidBrush(Color.White), r);
            }

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(1);
        }

    }
}
