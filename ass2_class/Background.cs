using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;



namespace ass2_class
{
    // 背景
    class Background : IDraw
    {
        //public override void draw(Graphics g)
        //{
        //    // 刷屏
        //    g.FillRectangle(new SolidBrush(Color.FromArgb(150, 150, 255)), 0, 0, 400, 400);

        //    // 画黑底
        //    SolidBrush mybrush3 = new SolidBrush(Color.FromArgb(50, 50, 0));
        //    g.FillEllipse(mybrush3, 0, 300, 380, 100);

        //    // 画轨迹
        //    Pen pen = new Pen(Color.FromArgb(72, 203, 255), 2);
        //    g.DrawEllipse(pen, 175, 175, 50, 50);
        //    g.DrawEllipse(pen, 150, 150, 100, 100);
        //    g.DrawEllipse(pen, 125, 125, 150, 150);
        //    g.DrawEllipse(pen, 100, 100, 200, 200);
        //    g.DrawEllipse(pen, 75, 75, 250, 250);
        //}

        public void Draw(Graphics g)
        {
            // 刷屏
            g.FillRectangle(new SolidBrush(Color.FromArgb(150, 150, 255)), 0, 0, 400, 400);

            // 画黑底
            SolidBrush mybrush3 = new SolidBrush(Color.FromArgb(50, 50, 0));
            g.FillEllipse(mybrush3, 0, 300, 380, 100);

            // 画轨迹
            Pen pen = new Pen(Color.FromArgb(72, 203, 255), 2);
            g.DrawEllipse(pen, 175, 175, 50, 50);
            g.DrawEllipse(pen, 150, 150, 100, 100);
            g.DrawEllipse(pen, 125, 125, 150, 150);
            g.DrawEllipse(pen, 100, 100, 200, 200);
            g.DrawEllipse(pen, 75, 75, 250, 250);
        }
    }
}
