using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ass2_class
{
    public partial class Form1 : Form
    {
        Background bg = new Background();
        Sun sun;
        Planet[] q = new Planet[5];
        Huo[] h = new Huo[5];
        int hit;
        int fire;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Text = "重新开始";
            button2.Visible = true;
            hit = 0;
            fire = 5;
            sun = new Sun();
            q[0] = new Planet(Color.FromArgb(154, 17, 47), 25, 10);
            q[1] = new Planet(Color.FromArgb(253, 178, 91), 50, 15);
            q[2] = new Planet(Color.FromArgb(236, 52, 63), 75, 20);
            q[3] = new Planet(Color.FromArgb(228, 254, 253), 100, 10);
            q[4] = new Planet(Color.FromArgb(210, 124, 171), 125, 30);
            for (int i = 0; i < h.Length; i++)
            {
                h[i] = new Huo();
            }
            draw();
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("游戏结束");
            this.Close();
        }

        void draw()
        {
            Graphics g = CreateGraphics();
            if (fire == 0)
            {
                g.FillRectangle(new SolidBrush(Color.FromArgb(150, 150, 255)), 0, 0, 400, 400);
                label1.Text = "游戏结束！";
                label2.Text = "你得" + hit + "分";
            }
            else
            {
                bg.Draw(g);
                sun.Draw(g);
                label1.Text = "Flames = " + fire;
                label2.Text = "Hit = " + hit;
                for (int i = 0; i < q.Length; i++)
                {
                    if(q[i].q == 1)
                    {
                        Graphics g1 = CreateGraphics();
                        q[i].Draw(g1);
                    }
                }

                for (int i = 0; i < h.Length; i++)
                {
                    if (h[i].x != 500 && h[i].h == 1)
                    {
                        h[i].Draw(g);
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gogogo();
            draw();
        }

        // 判断是否相撞
        public void gogogo()
        {
            for (int i = 0; i < h.Length; i++)
            {
                if (h[i].x != 500 && h[i].h == 1)
                {
                    for (int j = 0; j < q.Length; j++)
                    {
                        if (bj(h[i].x, h[i].y, q[j].x + 200, q[j].y + 200))
                        {
                            h[i].h = 0;
                            q[i].q = 0;
                            hit++;
                        }
                    }
                }
            }
        }

        bool bj(float x1, float y1, float x2, float y2)
        {
            float a = 20;
            if (Math.Abs(x1 - x2) < a && Math.Abs(y1 - y2) < a) return true;
            else return false;
        }

        // 键盘事件
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)     sun.Lift();
            if (e.KeyCode == Keys.Right)    sun.Right();
            if (e.KeyCode == Keys.Down)
            {
                for(int i = 0; i < h.Length; i++)
                {
                    if(h[i].x == 500)
                    {
                        h[i].x = sun.SunX + 15;
                        fire--;
                        break;
                    }
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left) sun.Lift();
            if (e.KeyCode == Keys.Right) sun.Right();
        }
    }
}
