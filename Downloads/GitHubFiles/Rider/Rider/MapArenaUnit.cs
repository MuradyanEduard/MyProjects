using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rider
{
    class MapArenaUnit
    {
        public Bitmap[] bpUnit = new Bitmap[10];
        public int currentPos, newPos;
        public int bpCurrentNom = 0;
        public int bpNomCount = 0;
        public int unitVx = 10, unitVy = 10;

        public int moveX = 0, moveY = 0;

        public int[] unitControlArray = new int[81];
        public int unitControlArrayCount = 0;

        public Point miniMapPos;
        public Point pt;

        public Boolean unitActive = false;

    }
}
