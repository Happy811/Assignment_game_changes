using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_game
{
    public class Logicclass
    {
        //this is the bullet
        public int Bullet;
        public int Points = 0;
        public int ShootingAwayChances = 2;
        public int ShootingaheadChances = 5;

        public void Load()
        {
            Bullet = 0;
        }
        public void Spin()
        {
            Random rand = new Random();
            Bullet = rand.Next(0, 6);
        }
        //this function is Shoot a head
        public void ShootaHead()
        {
            if (Bullet == 5)
            {
                MessageBox.Show("you Finish");
                Points = Points - 5;
            }
            else
            {
                MessageBox.Show("Continue playing");
                Bullet++;
            }
        }
        //This function is ShootAway
        public void shootAway()
        { 
            ShootingAwayChances--;
            if (ShootingAwayChances == 0)
            {
                MessageBox.Show("You Lost ");
            }
            else
            {
                if (Bullet == 5)
                {
                    MessageBox.Show("You survive");
                    Points = Points + 5;
                }
                else
                {
                    MessageBox.Show("Continue playing");
                    Bullet++;
                }
            }
        }
    }
}









