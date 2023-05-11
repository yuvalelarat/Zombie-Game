using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zombie_Game
{
    class Person
    {
        protected int health;
        protected int speed;
        public string direction;
        public int attackLeft;
        public int attackTop;
        protected int damage;
        private int attackSpeed = 20;
        private PictureBox attack = new PictureBox();
        private Timer attackTimer = new Timer();


        public virtual int getHealth()
        {
            return health;
        }
        public virtual void setHealth(int x)
        {
            health -= x;
        }
        public virtual int getSpeed()
        {
            return speed;
        }
        public virtual void MakeAttack(Form form)
        {
            attack.BackColor = Color.White;
            attack.Size = new Size(3, 3);
            attack.Tag = "bullet";
            attack.Left = attackLeft;
            attack.Top = attackTop;
            attack.BringToFront();
            form.Controls.Add(attack);
            attackTimer.Interval = attackSpeed;
            attackTimer.Tick += new EventHandler(AttackTimerEvent);
            attackTimer.Start();
        }
        public void AttackTimerEvent(object sender, EventArgs e)
        {

            if (direction == "left")
            {
                attack.Left -= attackSpeed;
            }

            if (direction == "right")
            {
                attack.Left += attackSpeed;
            }

            if (attack.Left < 10 || attack.Left > 950)
            {
                attackTimer.Stop();
                attackTimer.Dispose();
                attack.Dispose();
                attackTimer = null;
                attack = null;
            }
        }
    }
}
