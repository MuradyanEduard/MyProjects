using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rider
{
    public partial class FightArena : Form
    {
        Point startPoint;
        int squareWidth, squareHeight;
        int fightArrayLengthCount = 12, fightArrayHeightCount = 10;
        int[] fightArray;

        FightArenaUnit MyKnight = new FightArenaUnit();
        FightArenaUnit EnemyKnight = new FightArenaUnit();

        Bitmap swordType;
        Point swordPt;
        int atackPos = -1;

        int knightHeight, knightWidth;
        Point[] squarePoints;
        Point[] atackDirectionPlygons = new Point[16 * 4];
        public FightArena()
        {
            InitializeComponent();
        }

        private void FightArena_Load(object sender, EventArgs e)
        {

            squareWidth = (2 * this.Width) / 27;
            squareHeight = this.Height / 14;

            ArenaCreator();

            {
                String str = "S0.png";
                swordType = new Bitmap(Path.Combine(@"Pictures\SwordType\", str));
                swordType = new Bitmap(swordType, new Size(squareWidth, squareWidth));
            }
            //Units create
            knightWidth = squareWidth;
            knightHeight = squareHeight;
            MyKnight.currentPos = 0;
            MyKnight.newPos = 0;
            MyKnight.bpCurrentNom = 9;
            MyKnight.bpNomCount = 10;

            for (int i = 0; i < MyKnight.bpNomCount; i++)
            {
                String str = "K" + i.ToString() + ".png";
                MyKnight.bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Knight\Right\", str));
                MyKnight.bpUnit[i] = new Bitmap(MyKnight.bpUnit[i], new Size(knightWidth, knightWidth));
            }

            MyKnight.pt.X = (squarePoints[MyKnight.currentPos * 4].X + squarePoints[MyKnight.currentPos * 4 + 3].X) / 2;
            MyKnight.pt.Y = (squarePoints[MyKnight.currentPos * 4].Y + squarePoints[MyKnight.currentPos * 4 + 2].Y) / 2;
            PointCorrection(ref MyKnight.pt);

            knightWidth = squareWidth;
            knightHeight = squareHeight;
            EnemyKnight.currentPos = 40;
            EnemyKnight.newPos = 0;
            EnemyKnight.bpCurrentNom = 9;
            EnemyKnight.bpNomCount = 10;

            for (int i = 0; i < EnemyKnight.bpNomCount; i++)
            {
                String str = "K" + i.ToString() + ".png";
                EnemyKnight.bpUnit[i] = new Bitmap(Path.Combine(@"Pictures\Knight\Right\", str));
                EnemyKnight.bpUnit[i] = new Bitmap(EnemyKnight.bpUnit[i], new Size(knightWidth, knightWidth));
            }

            EnemyKnight.pt.X = (squarePoints[EnemyKnight.currentPos * 4].X + squarePoints[EnemyKnight.currentPos * 4 + 3].X) / 2;
            EnemyKnight.pt.Y = (squarePoints[EnemyKnight.currentPos * 4].Y + squarePoints[EnemyKnight.currentPos * 4 + 2].Y) / 2;
            PointCorrection(ref EnemyKnight.pt);

            UnitBorderCondition(MyKnight);
        }

        private void ArenaCreator()
        {
            squarePoints = new Point[fightArrayLengthCount * fightArrayHeightCount * 4];
            Point[] newSquarePoints = new Point[(fightArrayHeightCount + 1) * (fightArrayLengthCount + 1)];
            fightArray = new int[squarePoints.Length / 4];

            int Alfa = 90 - (fightArrayLengthCount / 2) * 3;
            int dx = squareWidth, dy = squareHeight + this.Height / 55;
            int numIndexPt = -1;
            int chapX, ChapY = squareHeight;
            int currentX, currentY;

            startPoint.X = dx;
            startPoint.Y = dy;

            for (int j = 0; j < (fightArrayLengthCount + 1); j++)
            {
                currentX = dx + j * squareWidth;
                currentY = dy + fightArrayHeightCount * squareHeight;
                chapX = (int)(squareHeight / Math.Tan(Alfa * (Math.PI / 180)));
                for (int i = 0; i < fightArrayHeightCount + 1; i++)
                {
                    numIndexPt++;
                    Point pt = new Point { X = currentX, Y = currentY };
                    newSquarePoints[numIndexPt] = pt;

                    currentY = currentY - ChapY;
                    currentX = currentX + chapX;

                }
                Alfa += 3;
            }

            //Sort By 4 Points
            numIndexPt = -1;
            for (int i = 0; i < fightArrayHeightCount; i++)
            {
                for (int j = 0; j < fightArrayLengthCount; j++)
                {
                    numIndexPt++;
                    squarePoints[numIndexPt] = newSquarePoints[j * (fightArrayHeightCount + 1) + i];
                    numIndexPt++;
                    squarePoints[numIndexPt] = newSquarePoints[j * (fightArrayHeightCount + 1) + 1 + i];
                    numIndexPt++;
                    squarePoints[numIndexPt] = newSquarePoints[(j + 1) * (fightArrayHeightCount + 1) + 1 + i];
                    numIndexPt++;
                    squarePoints[numIndexPt] = newSquarePoints[(j + 1) * (fightArrayHeightCount + 1) + i];
                }
            }
        }
        private void PointCorrection(ref Point ptUnit)
        {
            ptUnit.X = ptUnit.X - squareWidth / 2;
            ptUnit.Y = ptUnit.Y - squareWidth;
        }
        private void FightArena_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.OpenForms[1].Show();

            StreamWriter myfile = new StreamWriter(@"Events\ResultOfFidht.dll", false);
            myfile.Write("win");
            myfile.Close();

        }

        private void FightArena_MouseClick(object sender, MouseEventArgs e)
        {
            Point CursorPoint = new Point();
            CursorPoint.X = Cursor.Position.X;
            CursorPoint.Y = Cursor.Position.Y;

            int cursorCurrentPos = IndexOfCurrentPos(CursorPoint);

            if (cursorCurrentPos >= 0 && cursorCurrentPos<=fightArrayHeightCount*fightArrayLengthCount)
            {
                Point[] pts = new Point[4];

                if (atackPos > -1)
                {
                    pts[0] = squarePoints[atackPos * 4];
                    pts[1] = squarePoints[atackPos * 4 + 1];
                    pts[2] = squarePoints[atackPos * 4 + 2];
                    pts[3] = squarePoints[atackPos * 4 + 3];
                }
                else
                { 
                    pts[0] = squarePoints[cursorCurrentPos * 4];
                    pts[1] = squarePoints[cursorCurrentPos * 4 + 1];
                    pts[2] = squarePoints[cursorCurrentPos * 4 + 2];
                    pts[3] = squarePoints[cursorCurrentPos * 4 + 3];
                }

                MyKnight.newPos = cursorCurrentPos;

                for (int k = 0; k < 4; k++)
                    PointCorrection(ref pts[k]);

                MyKnight.moveX = (((pts[0].X + pts[3].X) / 2 - MyKnight.pt.X) / MyKnight.unitVx) * MyKnight.unitVx;
                MyKnight.moveY = (((pts[0].Y + pts[2].Y) / 2 - MyKnight.pt.Y) / MyKnight.unitVy) * MyKnight.unitVy;
            }

            if (atackPos >= 0)
            {
                ArenaClear();
                TmUnit.Enabled = true;
            }
            else
            {
                for (int i = 0; i < fightArray.Length; i++)
                    if (fightArray[i] == 2)
                    {
                        ArenaClear();
                        TmUnit.Enabled = true;
                    }
                
            }

        }

        private void FightArena_MouseMove(object sender, MouseEventArgs e)
        {
            if (TmUnit.Enabled == true)
                return;

            Point CursorPoint = new Point();
            CursorPoint.X = Cursor.Position.X;
            CursorPoint.Y = Cursor.Position.Y;

            int cursorCurrentPos = IndexOfCurrentPos(CursorPoint);

            ArenaClear();
            UnitBorderCondition(MyKnight);

            if (cursorCurrentPos >= 0)
            {
                if (cursorCurrentPos == EnemyKnight.currentPos)
                    AtackPosCreator(CursorPoint, squarePoints[cursorCurrentPos*4], squarePoints[cursorCurrentPos * 4+1], squarePoints[cursorCurrentPos * 4+2], squarePoints[cursorCurrentPos * 4+3]);
                else
                    for (int i = 0; i < fightArray.Length; i++)
                        if (i == cursorCurrentPos && fightArray[i]==1)                    
                            fightArray[i] = 2;

                Invalidate();
            }

        }

        private void ArenaClear()
        {
            for (int i = 0; i < squarePoints.Length / 4; i++)
                fightArray[i] = -1;

            atackPos = -1;
        }
        private void UnitBorderCondition(FightArenaUnit unit)
        {

            int ShurjStugoxTaracqQanak = 0;
            int[] ShurjStugoxTaracq = new int[4];
            int index = 0;
            int[] StugvoxTaracqPayman = new int[fightArrayLengthCount * fightArrayHeightCount];
            int[] QartezStugoxTaracq = new int[fightArrayLengthCount * fightArrayHeightCount];
            String[] WayToUnit = new String[fightArrayLengthCount * fightArrayHeightCount];

            //OneSquareArray(ShurjStugoxTaracq, ref ShurjStugoxTaracqQanak, unit.CurrentPos);
            int cycleNum = 0, cycleCount = 0, cycleCountSt = 0;
            StugvoxTaracqPayman[0] = unit.currentPos;

            while (cycleNum < 6)
            {
                cycleNum++;
                cycleCount = cycleCountSt;

                for (int i = 0; i <= cycleCount; i++)
                {
                    OneSquareArray(ShurjStugoxTaracq, ref ShurjStugoxTaracqQanak, StugvoxTaracqPayman[i]);

                    for (int k = 0; k <= ShurjStugoxTaracqQanak; k++)
                    {
                        if (QartezStugoxTaracq[ShurjStugoxTaracq[k]] < 0 || ShurjStugoxTaracq[k] == unit.currentPos)
                            continue;
                        else
                        {
                            cycleCountSt++;
                            index++;
                            StugvoxTaracqPayman[index] = ShurjStugoxTaracq[k];
                            QartezStugoxTaracq[ShurjStugoxTaracq[k]] = -1;
                            fightArray[ShurjStugoxTaracq[k]] = 1;
                            WayToUnit[ShurjStugoxTaracq[k]] = WayToUnit[StugvoxTaracqPayman[i]] + " " + ShurjStugoxTaracq[k].ToString();

                        }
                    }

                }

            }

            cycleCount = cycleCountSt;

            //cycleCountSt = 0;
        }

        private void OneSquareArray(int[] squareArray, ref int arrayLength, int unitPos)
        {
            arrayLength = -1;

            if (!(unitPos % fightArrayLengthCount == 0))
            {
                arrayLength++;
                squareArray[arrayLength] = unitPos-1;
            }
            if (!(unitPos >= fightArrayLengthCount * fightArrayHeightCount - fightArrayLengthCount))
            {
                arrayLength++;
                squareArray[arrayLength] = unitPos + fightArrayLengthCount;
            }
            if (!(unitPos % fightArrayLengthCount == fightArrayLengthCount - 1))
            {
                arrayLength++;
                squareArray[arrayLength] = unitPos+1;
            }

            if (!(unitPos < fightArrayLengthCount))
            {
                arrayLength++;
                squareArray[arrayLength] = unitPos - fightArrayLengthCount;
            }

        }
        private int IndexOfCurrentPos(Point stugvoxPoint)
        {
            int numIndexPt = -1;

            Point[] pts = new Point[] { squarePoints[0],
                                       squarePoints[(fightArrayLengthCount * (fightArrayHeightCount-1))*4+1],
                                       squarePoints[squarePoints.Length - 2],
                                       squarePoints[(fightArrayLengthCount-1)*4+3]};


            if (!IsInPolygon(pts, stugvoxPoint))
                return -1;

            pts = new Point[4];

            for (int i = 0; i < squarePoints.Length / 4; i++)
            {
                numIndexPt++;
                pts[0] = squarePoints[numIndexPt];
                numIndexPt++;
                pts[1] = squarePoints[numIndexPt];
                numIndexPt++;
                pts[2] = squarePoints[numIndexPt];
                numIndexPt++;
                pts[3] = squarePoints[numIndexPt];

                if (IsInPolygon(pts, stugvoxPoint))
                {
                    return i;
                }
            }

            return -1;
        }
        private void AtackPosCreator(Point crsPoint, params Point[] unitPoints)
        {
            Point[] atackDirectionPoints = new Point[16];

            int chapX = ((unitPoints[1].X - unitPoints[0].X)) / 3;
            int chapY = squareHeight / 3;

            for (int i = 0; i < 4; i++)
            {
                atackDirectionPoints[i].X = unitPoints[0].X + chapX * i;
                atackDirectionPoints[i].Y = unitPoints[0].Y - chapY * i;
            }

            chapX = (unitPoints[3].X - unitPoints[0].X) / 3;
            for (int i = 4; i < 8; i++)
            {
                atackDirectionPoints[i].X = unitPoints[0].X + chapX;
                atackDirectionPoints[i].Y = unitPoints[0].Y - chapY * (i - 4);
            }

            chapX = 2 * (unitPoints[3].X - unitPoints[0].X) / 3;
            for (int i = 8; i < 12; i++)
            {
                atackDirectionPoints[i].X = unitPoints[0].X + chapX;
                atackDirectionPoints[i].Y = unitPoints[0].Y - chapY * (i - 8);
            }

            chapX = (unitPoints[3].X - unitPoints[2].X) / 3;
            for (int i = 12; i < 16; i++)
            {
                atackDirectionPoints[i].X = unitPoints[3].X  - chapX * (i-12);
                atackDirectionPoints[i].Y = unitPoints[0].Y - chapY * (i - 12);
            }

            int numIndexPt = -1;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    numIndexPt++;
                    atackDirectionPlygons[numIndexPt] = atackDirectionPoints[i * (3 + 1) + j];
                    numIndexPt++;
                    atackDirectionPlygons[numIndexPt] = atackDirectionPoints[i * (3 + 1) + 1 + j];
                    numIndexPt++;
                    atackDirectionPlygons[numIndexPt] = atackDirectionPoints[(i + 1) * (3 + 1) + 1 + j];
                    numIndexPt++;
                    atackDirectionPlygons[numIndexPt] = atackDirectionPoints[(i + 1) * (3 + 1) + j];

                }
            }

            for (int i = 0; i < 9; i++)
            {
                Point point1 = atackDirectionPlygons[i * 4];
                Point point2 = atackDirectionPlygons[i * 4 + 1];
                Point point3 = atackDirectionPlygons[i * 4 + 2];
                Point point4 = atackDirectionPlygons[i * 4 + 3];

                Point[] curvePoints = { point1, point2, point3, point4 };
                
                if (IsInPolygon(curvePoints, crsPoint))
                {
                    int icp = IndexOfCurrentPos(crsPoint);
                    switch (i)
                    {
                        case 0:
                            if (!SquareExist(icp,0))
                                break;

                            atackPos = icp - fightArrayLengthCount - 1;
                            swordPt.X = point1.X - squareWidth / 2;
                            swordPt.Y = point1.Y;
                            break;
                        case 1:
                            if (!SquareExist(icp, 1))
                                break;

                            atackPos = icp -  1;
                            swordPt.X = point1.X - squareWidth / 2;
                            swordPt.Y = point1.Y + (point1.Y - point2.Y) / 2 - squareWidth / 2;
                            break;
                        case 2:
                            if (!SquareExist(icp, 2))
                                break;

                            atackPos = icp + fightArrayLengthCount - 1;
                            swordPt.X = point2.X - squareWidth / 2;
                            swordPt.Y = point2.Y - squareWidth / 2;
                            break;
                        case 3:
                            if (!SquareExist(icp, 3))
                                break;

                            atackPos = icp - fightArrayLengthCount;
                            swordPt.X = point1.X - squareWidth / 6;
                            swordPt.Y = point1.Y;
                            break;
                        case 4:
                            return;
                        case 5:
                            if (!SquareExist(icp, 5))
                                break;

                            atackPos = icp + fightArrayLengthCount;
                            swordPt.X = point2.X;
                            swordPt.Y = point2.Y - squareWidth / 2;
                            break;
                        case 6:
                            if (!SquareExist(icp, 6))
                                break;

                            atackPos = icp - fightArrayLengthCount + 1;
                            swordPt = point4;
                            break;
                        case 7:
                            if (!SquareExist(icp, 7))
                                break;

                            atackPos = icp + 1;
                            swordPt.X = point4.X;
                            swordPt.Y = point4.Y - squareWidth / 3;
                            break;
                        case 8:
                            if (!SquareExist(icp, 8))
                                break;

                            atackPos = icp + fightArrayLengthCount + 1;
                            swordPt.X = point3.X;
                            swordPt.Y = point3.Y - squareWidth / 2;
                            break;
                    }

                }

            }

        }
        private bool SquareExist(int squareCheckPos,int directionNum)
        {
            atackPos = -1;

            String str = "S" + directionNum + ".png";
            swordType = new Bitmap(Path.Combine(@"Pictures\SwordType\", str));
            swordType = new Bitmap(swordType, new Size(squareWidth / 2, squareWidth / 2));

            if (directionNum == 0 || directionNum == 1 || directionNum == 2)
                if (squareCheckPos % fightArrayLengthCount == 0)
                {
                    swordType = null;
                    return false;
                }

            if (directionNum == 2 || directionNum == 5 || directionNum == 8)
                if (squareCheckPos >=  fightArrayLengthCount*fightArrayHeightCount - fightArrayLengthCount)
                {
                    swordType = null;
                    return false;
                }

            if (directionNum == 8 || directionNum == 7 || directionNum == 6)
                if (squareCheckPos % fightArrayLengthCount == fightArrayLengthCount - 1)
                {
                    swordType = null;
                    return false;
                }

            if (directionNum == 0 || directionNum == 3 || directionNum == 6)
                if (squareCheckPos < fightArrayLengthCount)
                {
                    swordType = null;
                    return false;
                }


            return true;
        }
        private bool IsInPolygon(Point[] polygon, Point point)
        {
            bool isInside = false;
            for (int i = 0, j = polygon.Length - 1; i < polygon.Length; j = i++)
            {
                if (((polygon[i].Y > point.Y) != (polygon[j].Y > point.Y)) &&
                (point.X < (polygon[j].X - polygon[i].X) * (point.Y - polygon[i].Y) / (polygon[j].Y - polygon[i].Y) + polygon[i].X))
                {
                    isInside = !isInside;
                }
            }
            return isInside;
        }
        private void TmUnit_Tick(object sender, EventArgs e)
        {
            MyKnight.bpCurrentNom++;
            if (MyKnight.bpCurrentNom >= 9)
                MyKnight.bpCurrentNom = 0;

            if (MyKnight.moveX < 0)
            {
                MyKnight.pt.X = MyKnight.pt.X - MyKnight.unitVx;
                MyKnight.moveX = MyKnight.moveX + MyKnight.unitVx;
            }
            else if (MyKnight.moveX > 0)
            {
                MyKnight.pt.X = MyKnight.pt.X + MyKnight.unitVx;
                MyKnight.moveX = MyKnight.moveX - MyKnight.unitVx;
            }

            if (MyKnight.moveY < 0)
            {
                MyKnight.pt.Y = MyKnight.pt.Y - MyKnight.unitVy;
                MyKnight.moveY = MyKnight.moveY + MyKnight.unitVy;
            }
            else if (MyKnight.moveY > 0)
            {
                MyKnight.pt.Y = MyKnight.pt.Y + MyKnight.unitVy;
                MyKnight.moveY = MyKnight.moveY - MyKnight.unitVy;
            }

            if (MyKnight.moveX == 0 && MyKnight.moveY == 0)
            {
                for (int i = 0; i < squarePoints.Length / 4; i++)
                    fightArray[i] = -1;

                if (atackPos > -1)
                {
                    MyKnight.currentPos = atackPos;
                    atackPos = -1;
                }
                else
                    MyKnight.currentPos = MyKnight.newPos;

                UnitBorderCondition(MyKnight);
                TmUnit.Enabled = false;
                MyKnight.bpCurrentNom = 9;

            }
            Invalidate();

        }

        private void FightArena_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Font drawFont = new System.Drawing.Font("Arial", 16);
            System.Drawing.SolidBrush drawBrush = new System.Drawing.SolidBrush(System.Drawing.Color.Black);
            System.Drawing.StringFormat drawFormat = new System.Drawing.StringFormat();

            int dx = squareWidth;//, dy = 0;
            Pen PenSquare = new Pen(Color.Black, 2);
            SolidBrush squareBrush = new SolidBrush(Color.Yellow);

            int num = 0;
            for (int i = 0; i < squarePoints.Length / 4; i++)
            {
                PointF point1 = squarePoints[i*4];
                PointF point2 = squarePoints[i*4+1];
                PointF point3 = squarePoints[i*4+2];
                PointF point4 = squarePoints[i*4+3];

                PointF[] curvePoints = { point1, point2, point3, point4 };

                dx = dx + squareWidth;

                switch (fightArray[i])
                {
                    case 0:
//                        e.Graphics.DrawPolygon(PenSquare, curvePoints);
                        break;
                    case 1:
                        e.Graphics.FillPolygon(new SolidBrush(Color.Gray), curvePoints);
                        break;
                    case 2:
                        e.Graphics.FillPolygon(new SolidBrush(Color.Yellow), curvePoints);
                        break;
                }

                e.Graphics.DrawString(num.ToString(), drawFont, drawBrush, (point1.X + point3.X) / 2 - 16, (point1.Y + point2.Y) / 2 - 16, drawFormat);
                e.Graphics.DrawPolygon(PenSquare, curvePoints);

                num++;
            }

           

            if (atackPos > -1)
            {
                PointF point1 = squarePoints[atackPos * 4];
                PointF point2 = squarePoints[(atackPos * 4) + 1];
                PointF point3 = squarePoints[(atackPos * 4) + 2];
                PointF point4 = squarePoints[(atackPos * 4) + 3];

                PointF[] curvePoints = { point1, point2, point3, point4 };

                e.Graphics.FillPolygon(squareBrush, curvePoints);
                e.Graphics.DrawImage(swordType, swordPt);
            }

            e.Graphics.DrawImage(MyKnight.bpUnit[MyKnight.bpCurrentNom], MyKnight.pt);

            //for (int i = 0; i < 16; i++)
            //{
            //    PointF point1 = atackDirectionPlygons[i * 4];
            //    PointF point2 = atackDirectionPlygons[(i * 4) + 1];
            //    PointF point3 = atackDirectionPlygons[(i * 4) + 2];
            //    PointF point4 = atackDirectionPlygons[(i * 4) + 3];

            //    PointF[] curvePoints = { point1, point2, point3, point4 };

            //    e.Graphics.DrawPolygon(new Pen(Color.Red, 2), curvePoints);
            //}

            e.Graphics.DrawImage(EnemyKnight.bpUnit[EnemyKnight.bpCurrentNom], EnemyKnight.pt);

            //Point[] pts = new Point[] { squarePoints[0],
            //                           squarePoints[(fightArrayLengthCount * (fightArrayHeightCount-1))*4+1],
            //                           squarePoints[squarePoints.Length - 2],
            //                           squarePoints[(fightArrayLengthCount-1)*4+3]};

            //e.Graphics.FillPolygon(squareBrush, pts);
        }

    }
}
