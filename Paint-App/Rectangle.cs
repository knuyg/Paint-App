using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    public class Rectangle : Object
    {
        public Rectangle(int x, int y)
        {
            this.x = x;
            this.y = y;
            this.width = 0;
            this.height = 0;
        }
        public Rectangle (int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override string GetInfo()
        {
            return $"Rectangle at ({this.x}, {this.y}), Width: {this.width}, Height: {this.height}";
        }

        public override void DrawObject(Graphics g, Pen p)
        {
            g.DrawRectangle(p, this.x, this.y, this.width, this.height);
        }
    }
}
