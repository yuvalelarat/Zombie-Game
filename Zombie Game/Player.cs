using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Zombie_Game
{
    class Player : Person
    {
        private int ammo;
        public bool goLeft, goRight, goUp, goDown;
        public string facing;
        public Player()
        {
            health = 100;
            ammo = 10;
            goLeft = false;
            goRight = false;
            goUp = false;
            goDown = false;
            speed = 10;
            damage = 100;
            facing = "right";
        }
        public int GetAmmo()
        {
            return ammo;
        }
        public void SetAmmo(int _ammo)
        {
            ammo -= _ammo;
        }
        public void SetAmmo(double _ammo)
        {
            ammo = (int)_ammo;
        }
        public void SetAmmo()
        {
            ammo += 5;
        }
        public int GetDamage()
        {
            return damage;
        }
        public void Movement(string what)
        {
            if (what == "left")
            {
                goLeft = true;
                facing = "left";
            }
            if (what == "right")
            {
                goRight = true;
                facing = "right";
            }
            if (what == "up")
            {
                goUp = true;
                //facing = "up";
            }
            if (what == "down")
            {
                goDown = true;
                //facing = "down";
            }
        }
        public void StopMovement(string what)
        {
            if (what == "left")
            {
                goLeft = false;
            }
            if (what == "right")
            {
                goRight = false;

            }
            if (what == "up")
            {
                goUp = false;

            }
            if (what == "down")
            {
                goDown = false;

            }
        }
        public bool GetLeft()
        {
            return goLeft;
        }
        public bool GetRight()
        {
            return goRight;
        }
        public bool GetUp()
        {
            return goUp;
        }
        public bool GetDown()
        {
            return goDown;
        }
        public void SetLeft(bool what)
        {
            goLeft = what;
        }
        public void SetRight(bool what)
        {
            goRight = what;
        }
        public void SetUp(bool what)
        {
            goUp = what;
        }
        public void SetDown(bool what)
        {
            goDown = what;
        }
        public void SetNewHealth(int newHealth)
        {
            health = newHealth;
        }
    }
}
