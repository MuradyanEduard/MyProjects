using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rider
{
    class FightArenaUnit
    {
        public Bitmap[] bpUnit = new Bitmap[10];
        public int currentPos, newPos;
        public int bpCurrentNom = 0;
        public int bpNomCount = 0;
        public int unitVx = 10, unitVy = 10;

        public int moveX = 0, moveY = 0;

        public Boolean unitActive = false;

        public Point pt;

        public int attack;
        public int defense;
        public int damage;
        public int singleLife;
        public int movmentSpeed;
        public double initiative;
        public string shots;
        public int mana;
        public string fightSpirit;
        public int luck;
        public int range;
        public int countHero;


    }
}
