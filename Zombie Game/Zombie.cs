using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Game
{
    class Zombie : Person
    {
        Random randNum = new Random();
        public List<PictureBox> zombiesList = new List<PictureBox>();
        public List<PictureBox> FireZombieList = new List<PictureBox>();
        public List<PictureBox> TankZombieList = new List<PictureBox>();

        public Zombie()
        {
            health = 100;
            damage = 1;
            speed = 2;
        }
        public virtual PictureBox Spawn()
        {
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zombieRight;
            zombie.Left = randNum.Next(0, 900);
            zombie.Top = randNum.Next(0, 900);
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombie.BackColor = Color.Transparent;
            zombiesList.Add(zombie);
            return zombie;
        }
        public virtual int ZombieAttack()
        {
            return damage;
        }
        public override int getSpeed()
        {
            return speed;
        }
        public virtual void resetHealth()
        {
            health = 100;
        }
        public override int getHealth()
        {
            return health;
        }
        public virtual void setSpeed(int x)
        {
            speed += x;
        }
        public virtual void resetSpeed()
        {
            speed = 2;
        }
    }
}
