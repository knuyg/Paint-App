using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    internal class Rectangle : Object
    {
        public int width;
        public int height;

        public Rectangle (Point origin, int width, int height)
        {
            this.origin = origin;
            this.width = width;
            this.height = height;
        }
    }
}
