using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    internal abstract class Object
    {
        public Point origin;

        public Object()
        {
            this.origin = new Point(0, 0);
        }
    }
}
