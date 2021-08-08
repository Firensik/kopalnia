using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kopalnia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Over.Visible = false;

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (e.KeyCode == Keys.Left)
                {
                    if (ryl.Left > 0)
                        ryl.Left += -15;
                }
                if (e.KeyCode == Keys.Right)
                {
                    if (ryl.Left < 710)
                        ryl.Left += 15;
                }
                if (e.KeyCode == Keys.Up)
                {
                    if (ryl.Top > 0)
                        ryl.Top += -15; 
                }
                if (e.KeyCode == Keys.Down)
                {
                    if (ryl.Top < 266)
                        ryl.Top += 15;
                }

            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
           

            
        }

        private void timer1_Tick(object sender, EventArgs e)
      
        {
            moveline(3);
            gameover();
            coal(2);
            coalscollection();
        }
        int collectedcoal = 0;
        void coalscollection()
        {
            if (ryl.Bounds.IntersectsWith(coal1.Bounds))
            {
                collectedcoal++;
                label2.Text = "Coals=" + collectedcoal.ToString();
                x = r.Next(0, 800);
                coal1.Location = new Point(x, 0);

            }
            if (ryl.Bounds.IntersectsWith(coal2.Bounds))
            {
                collectedcoal++;
                label2.Text = "Coals=" + collectedcoal.ToString();
                x = r.Next(0, 800);
                coal2.Location = new Point(x, 0);
            }
            if (ryl.Bounds.IntersectsWith(coal3.Bounds))
            {
                collectedcoal++;
                label2.Text = "Coals=" + collectedcoal.ToString();
                x = r.Next(0, 800);
                coal3.Location = new Point(x, 0);
            }
            if (ryl.Bounds.IntersectsWith(coal4.Bounds))
            {
                collectedcoal++;
                label2.Text = "Coals=" + collectedcoal.ToString();
                x = r.Next(0, 800);
                coal4.Location = new Point(x, 0);
            }
            if (ryl.Bounds.IntersectsWith(coal5.Bounds))
            {
                collectedcoal++;
                label2.Text = "Coals=" + collectedcoal.ToString();
                x = r.Next(0, 800);
                coal5.Location = new Point(x, 0);
            }
        }
        void coal(int speed)
        {
            if (coal1.Top >= 400)
            {
                x = r.Next(0, 800);
                coal1.Location = new Point(x, 0);
            }
            else
            {
                coal1.Top += 3;
            }
            if (coal2.Top >= 400)
            {
                x = r.Next(0, 800);
                coal2.Location = new Point(x, 0);
            }
            else
            {
                coal2.Top += 3;
            }
            if (coal3.Top >= 400)
            {
                x = r.Next(0, 800);
                coal3.Location = new Point(x, 0);
            }
            else
            {
                coal3.Top += 3;
            }
            if (coal4.Top >= 400)
            {
                x = r.Next(0, 800);
                coal4.Location = new Point(x, 0);
            }
            else
            {
                coal4.Top += 3;
            }
            if (coal5.Top >= 400)
            {
                x = r.Next(0, 800);
                coal5.Location = new Point(x, 0);
            }
            else
            {
                coal5.Top += 3;
            }
        }
        void gameover()
        {
            if (ryl.Bounds.IntersectsWith(enemy1.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (ryl.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (ryl.Bounds.IntersectsWith(enemy3.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (ryl.Bounds.IntersectsWith(enemy4.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (ryl.Bounds.IntersectsWith(enemy5.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
            if (ryl.Bounds.IntersectsWith(enemy6.Bounds))
            {
                timer1.Enabled = false;
                Over.Visible = true;
            }
        } 

        Random r = new Random();
            int x, y;

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {

        }

        void moveline(int speed)
        {
            if (enemy1.Top >= 400)
            { 
                x = r.Next(0, 800);
                enemy1.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy1.Top += 2;
            }

            if (enemy2.Top >= 400)
            {
                x = r.Next(0, 800);
                enemy2.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy2.Top += 2;
            }

            if (enemy3.Top >= 400)
            {
                x = r.Next(0, 800);
                enemy3.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy3.Top += 2;
            }

            if (enemy5.Top >= 400)
            {
                x = r.Next(0, 800);
                enemy5.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy5.Top += 2;
            }

            if (enemy4.Top >= 400)
            {
                x = r.Next(0, 800);
                enemy4.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy4.Top += 2;
            }
            if (enemy6.Top >= 400)
            {
                x = r.Next(0, 800);
                enemy6.Location = new Point(x, 0);

                y = r.Next(0, 400);

            }
            else
            {
                enemy6.Top += 2;
            }

          
  


        }
    }
}
