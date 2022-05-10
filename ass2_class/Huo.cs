using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace ass2_class
{
    class Huo : Ellipse, IDraw
    {
        private float _x;
        private float _y;
        private int _h;

        public int h { get => _h; set => _h = value; }
        public float x { get => _x; set => _x = value; }
        public float y { get => _y; set => _y = value; }

        public Huo()
        {
            _x = 500;
            _y = 50;
            _h = 1;
        }

        //public override void draw(Graphics g)
        //{
        //    _y += 10;
        //    g.FillEllipse(new SolidBrush(Color.FromArgb(252, 1, 26)), _x, _y, 20, 20);
        //}

        public void Draw(Graphics g)
        {
            _y += 10;
            g.FillEllipse(new SolidBrush(Color.FromArgb(252, 1, 26)), _x, _y, 20, 20);
        }
    }
}
