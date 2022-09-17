using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace HalicopterGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }
        int p = 0, moveleft, movefire, points = 0, enemyescape = 0, chances = 0;
        int a = 500, b = 500, c = 500, d = 550, g = 550;
        int fire_show = 0;
        Boolean left, show, declare1, declare2, declare3, declare4, declare5;
        SoundPlayer helicopter = new SoundPlayer();
        SoundPlayer explod = new SoundPlayer();
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Width = 510;
            this.Height = 450;
            movefire = lbl_fire.Location.X;
            lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y + 20);
            lbl_fire.Hide();
            timr_fire.Stop();
            lbl_crash.Hide();
            helicopter.SoundLocation = @"hlcptr_sound.wav";
            // helicopter.SoundLocation = @"hlcptr_sound.wav";
            helicopter.PlayLooping();
            explod.SoundLocation = @"explod.wav";
        }

        private void timr_bg_Tick_1(object sender, EventArgs e)
        {

            p = p - 10;
            pictureBox1.Location = new Point(p, 0);

            if (p == -500)
            {
                pictureBox1.Location = new Point(0, 0);
                p = 0;
                p = p - 10;
                pictureBox1.Location = new Point(p, 0);
            }
        }
        private void timr_enemy_Tick(object sender, EventArgs e)
        {


            moveleft -= 2;
            if (left == true && lbl_hero.Location.X > 24)
            {
                lbl_hero.Location = new Point(moveleft, lbl_hero.Location.Y);
                if (moveleft < 24)
                {
                    left = false;
                }
            }
            a = a - 3;
            b = b - 2;
            c = c - 3;
            d = d - 2;
            g = g - 3;

            lbl_enemy1.Location = new Point(a, 100);
            lbl_enemy2.Location = new Point(b, 200);
            lbl_enemy3.Location = new Point(c, 300);
            lbl_enemy4.Location = new Point(d, 250);
            lbl_enemy6.Location = new Point(g, 150);





            if (a < -60)
            {
                enemyescape++;
                a = 500;
            }
            if (declare1 == true)
            {
                declare1 = false;
                a = 500;
            }
            if (b < -60)
            {
                enemyescape++;
                b = 500;
            }
            if (declare2 == true)
            {
                b = 500;
                declare2 = false;
            }
            if (c < -60)
            {
                enemyescape++;
                c = 500;
            }
            if (declare3 == true)
            {
                c = 500;
                declare3 = false;
            }

            if (d < -60)
            {
                enemyescape++;
                d = 550;
            }
            if (declare4 == true)
            {
                d = 550;
                declare4 = false;
            }
            if (g < -60)
            {
                enemyescape++;
                g = 550;
            }
            if (declare5 == true)
            {
                g = 550;
                declare5 = false;
            }
            lbl_escapepoints.Text = "" + enemyescape;





        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = lbl_hero.Location.X;
            int y = lbl_hero.Location.Y;
            if (e.KeyCode == Keys.Up && y > 5)
            {
                lbl_hero.Location = new Point(x, y - 2);
            }
            else if (e.KeyCode == Keys.Down && y < pictureBox1.Height - 50)
            {
                lbl_hero.Location = new Point(x, y + 2);
            }
            else if (e.KeyCode == Keys.Right)
            {
                lbl_hero.Location = new Point(x + 2, y);
                left = true;
                moveleft = lbl_hero.Location.X;
            }
            else if (e.KeyCode == Keys.Space)
            {
                lbl_fire.Location = lbl_hero.Location;
                movefire = lbl_hero.Location.X + 40;
                lbl_fire.Hide();
                timr_fire.Start();
                lbl_fire.Show();
            }
        }
        private void timr_fire_Tick(object sender, EventArgs e)
        {
            int x = lbl_fire.Location.X;
            int y = lbl_fire.Location.Y;
            movefire = movefire + 1;
            lbl_fire.Location = new Point(movefire, y);
            if (movefire > this.Width - 20)
            {
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                lbl_fire.Hide();
                timr_fire.Stop();
            }
        }
        private void enemy1_collision_Tick(object sender, EventArgs e)
        {
            int x = lbl_fire.Location.X;
            int y = lbl_fire.Location.Y;
            Text = "X : " + x + " Y : " + y;
            if ((x + 40 > lbl_enemy1.Location.X) && (y > 85 && y < 138))
            {
                explod.Play();
                declare1 = true;
                lbl_crash.Location = new Point(x, y - 25);
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                timr_fire.Stop();
                lbl_fire.Hide();
                show = true;
                points++;
            }
            if ((x + 40 > lbl_enemy2.Location.X) && y > 185 && y < 235)
            {
                explod.Play();
                declare2 = true;
                lbl_crash.Location = new Point(x, y - 25);
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                timr_fire.Stop();
                lbl_fire.Hide();
                show = true;
                points++;
            }
            if ((x + 40 > lbl_enemy3.Location.X) && y > 287 && y < 327)
            {
                explod.Play();
                declare3 = true;
                lbl_crash.Location = new Point(x, y - 25);
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                timr_fire.Stop();
                lbl_fire.Hide();
                show = true;
                points++;
            }
            if ((x + 40 > lbl_enemy4.Location.X) && y > 241 && y < 281)
            {
                explod.Play();
                declare4 = true;
                lbl_crash.Location = new Point(x, y - 25);
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                timr_fire.Stop();
                lbl_fire.Hide();
                show = true;
                points++;
            }
            if ((x + 40 > lbl_enemy6.Location.X) && y > 137 && y < 195)
            {
                explod.Play();
                declare5 = true;
                lbl_crash.Location = new Point(x, y - 25);
                lbl_fire.Location = new Point(lbl_hero.Location.X, lbl_hero.Location.Y);
                timr_fire.Stop();
                lbl_fire.Hide();
                show = true;
                points++;
            }



            if (show == true)
            {
                lbl_crash.Show();
                fire_show++;
            }
            if (fire_show > 50)
            {
                lbl_crash.Hide();
                fire_show = 0;
                show = false;
                helicopter.PlayLooping();
            }
            lbl_points.Text = "" + points;








        }

        private void hero_collsion_Tick(object sender, EventArgs e)
        {
            int x = lbl_hero.Location.X;
            int y = lbl_hero.Location.Y;

            if  ((lbl_enemy1.Location.X < x+42 && y > 85 && y < 143) || (( y+40>lbl_enemy1.Location.Y && y< lbl_enemy1.Location.Y+10 )&& x > lbl_enemy1.Location.X && x<lbl_enemy1.Location.X+70 ) )
            {
                declare1 = true;
                lbl_hero.Location = new Point(x, 42);
                chances++;
                lbl_crash.Location = new Point(x, y - 25);
                show = true;
                explod.Play();
            }


            if ((lbl_enemy2.Location.X < x + 42 && y > 175 && y < 235) || ((y + 40 > lbl_enemy2.Location.Y && y < lbl_enemy2.Location.Y + 10) && x > lbl_enemy2.Location.X && x < lbl_enemy2.Location.X + 70))
            {
                declare2 = true;
                lbl_hero.Location = new Point(x, 42);
                chances++;
                lbl_crash.Location = new Point(x, y - 25);
                show = true;
                explod.Play();
            }


            if ((lbl_enemy3.Location.X < x + 42 && y > 275 && y < 335) || ((y + 40 > lbl_enemy3.Location.Y && y < lbl_enemy3.Location.Y + 10) && x > lbl_enemy3.Location.X && x < lbl_enemy3.Location.X + 70))
            {
                declare3 = true;
                lbl_hero.Location = new Point(x, 42);
                chances++;
                lbl_crash.Location = new Point(x, y - 25);
                show = true;
                explod.Play();
            }


            if ((lbl_enemy4.Location.X < x + 42 && y > 225 && y < 288) || ((y + 40 > lbl_enemy4.Location.Y && y < lbl_enemy4.Location.Y + 10) && x > lbl_enemy4.Location.X && x < lbl_enemy4.Location.X + 70))
            {
                declare4 = true;
                lbl_hero.Location = new Point(x, 42);
                chances++;
                lbl_crash.Location = new Point(x, y - 25);
                show = true;
                explod.Play();
            }


            if ((lbl_enemy6.Location.X < x + 42 && y > 125 && y < 180) || ((y + 40 > lbl_enemy6.Location.Y && y < lbl_enemy6.Location.Y + 10) && x > lbl_enemy6.Location.X && x < lbl_enemy6.Location.X + 70))
            {
                declare5 = true;
                lbl_hero.Location = new Point(x, 42);
                chances++;
                lbl_crash.Location = new Point(x, y - 25);
                show = true;
                explod.Play();
            }

       

            lbl_chances.Text = "" + chances;


            if (chances == 5)
            {
                timr_bg.Stop();
                timr_enemy.Stop();
                timr_fire.Stop();
                hero_collsion.Stop();
                enemy1_collision.Stop();

                MessageBox.Show("U Have MissUsed ur 5 Chances ... Game Over :( Play Again :D");
                this.Close();
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
