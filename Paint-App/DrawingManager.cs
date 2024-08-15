using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    internal class DrawingManager
    {
        public Pen currentPen;
        public Tool currentTool;

        public DrawingManager()
        {
            this.currentPen = new Pen(Color.Black, 5);
            this.currentTool = new Tool();
        }

        public void DrawRectangle(CanvasManager canvasManager)
        {
            using (Graphics g = canvasManager.canvasPanel.CreateGraphics())
            {
                if (canvasManager.isCanvasCreated && this.currentTool.Name == "Rectangle")
                {
                    g.DrawRectangle(currentPen, 10, 10, 100, 50);
                }
            }
        }
    }
}
