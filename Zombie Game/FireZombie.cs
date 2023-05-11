using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Game
{
    class FireZombie : Zombie
    {
        Random randNum = new Random();
        private PictureBox attack = new PictureBox();
        private Timer attackTimer = new Timer();


        public FireZombie()
        {
            health = 150;
            speed = 4;
            attackDamage = 1;
        }
        public override PictureBox Spawn()
        {
            PictureBox fireZombie = new PictureBox();
            fireZombie.Tag = "fireZombie";
            fireZombie.Image = Properties.Resources.FireZombieLeft;
            fireZombie.Left = randNum.Next(0, 1000);
            fireZombie.Top = randNum.Next(0, 1000);
            fireZombie.SizeMode = PictureBoxSizeMode.AutoSize;
            FireZombieList.Add(fireZombie);
            return fireZombie;
        }
        public override int ZombieAttack()
        {
            return attackDamage;
        }
        public override int getSpeed()
        {
            return speed;
        }
        public override void resetHealth()
        {
            health = 150;
        }
        public override int getHealth()
        {
            return health;
        }
        public override void setSpeed(int x)
        {
            speed += x;
        }
        public override void resetSpeed()
        {
            speed = 5;
        }
        public override void MakeAttack(Form form)
        {
            PictureBox trap = new PictureBox();
            trap.Image = Properties.Resources.DeathStep;
            trap.SizeMode = PictureBoxSizeMode.AutoSize;
            trap.Left = randNum.Next(10, 950 - trap.Width);
            trap.Top = randNum.Next(60, form.ClientSize.Height - trap.Height);
            trap.Tag = "trap";
            form.Controls.Add(trap);
            trap.BringToFront();
        }
    }
}
