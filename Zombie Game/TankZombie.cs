using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Game
{
    class TankZombie : Zombie
    {

        Random randNum = new Random();
        private PictureBox attack = new PictureBox();
        private Timer attackTimer = new Timer();
        public TankZombie()
        {
            health = 300;
            speed = 1;
            damage = 5;
        }
        public override PictureBox Spawn()
        {
            PictureBox tankZombie = new PictureBox();
            tankZombie.Tag = "tankZombie";
            tankZombie.Image = Properties.Resources.TankZombieLeft;
            tankZombie.Left = randNum.Next(200, 300);
            tankZombie.Top = randNum.Next(300, 400);
            tankZombie.SizeMode = PictureBoxSizeMode.AutoSize;
            TankZombieList.Add(tankZombie);
            return tankZombie;
        }
        public override int ZombieAttack()
        {
            return damage;
        }
        public override int getSpeed()
        {
            return speed;
        }
        public override void resetHealth()
        {
            health = 300;
        }
        public override int getHealth()
        {
            return health;
        }
    }
}
