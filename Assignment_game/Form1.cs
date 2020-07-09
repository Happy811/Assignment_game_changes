using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_game
{
    public partial class Form1 : Form
    {
        Logicclass Logic = new Logicclass();




        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootaHead.Enabled = false;
            shootAway.Enabled = false;
        }

        //Shoot Away button
        private void shootAway_Click(object sender, EventArgs e)
        {
           if (Logic.ShootingAwayChances==0)
            {
                shootAway.Enabled = false;
               
                
                PlayAgain.Enabled = true; 
            }
            Logic.shootAway();
            SoundPlayer player = new SoundPlayer(Resource1.GunSound);
            player.Play();
        }
        // Load button
        private void Load_Click_2(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = false;
            Spin.Enabled = true;
            ShootaHead.Enabled = false;
            shootAway.Enabled = false;
            PlayAgain.Enabled = false;

            SoundPlayer player = new SoundPlayer(Resource1.LoadSound);

            player.Play();
        }
        //Shoot A Head button
        private void ShootaHead_Click(object sender, EventArgs e)
            
        {
            Logic.ShootaHead();
          
            PlayAgain.Enabled = true;
            textBox1.Text = Logic.Points + ""; 
            SoundPlayer player = new SoundPlayer(Resource1.Gunshoot);
            player.Play();
        }
        //Spin button
        private void Spin_Click(object sender, EventArgs e)
        {
            Logic.Spin();
            Load.Enabled = false;
            Spin.Enabled = false;
            ShootaHead.Enabled = true;
            shootAway.Enabled = true;
            PlayAgain.Enabled = false;


            SoundPlayer player = new SoundPlayer(Resource1.SpinSound);
            player.Play();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //PlayAgain button
        private void PlayAgain_Click(object sender, EventArgs e)
        {
            Logic.Load();
            Load.Enabled = true;
            Spin.Enabled = false;
            ShootaHead.Enabled = false;
            shootAway.Enabled = false;
        }
    }
}
