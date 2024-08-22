using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    internal class Ellipse : Object
    {
        private int width;
        private int height;

        public Ellipse(Point origin, int width, int height)
        {
            this.origin = origin;
            this.width = width;
            this.height = height;
        }
    }
}
