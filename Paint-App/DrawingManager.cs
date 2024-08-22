using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint_App
{
    public class DrawingManager
    {
        public Pen currentPen;
        public Tool currentTool;

        // Variables for drawing
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;

        public DrawingManager()
        {
            this.currentPen = new Pen(Color.Black, 5);
            this.currentTool = new Tool();
        }

        public void StartDrawing(Point location)
        {
            if (currentTool.Name == "Rectangle")
            {
                isDrawing = true;
                startPoint = location;
                endPoint = location;
            }
            else if (currentTool.Name == "Ellipse")
            {
                isDrawing = true;
                startPoint = location;
                endPoint = location;
            }
        }

        public void ContinueDrawing(Point location)
        {
            if (isDrawing && (currentTool.Name == "Rectangle" || currentTool.Name == "Ellipse"))
            {
                endPoint = location;
            }
        }

        public void EndDrawing()
        {
            isDrawing = false;
        }

        public void DrawRectangle(CanvasManager canvasManager)
        {
            using (Graphics g = canvasManager.canvasPanel.CreateGraphics())
            {
                if (canvasManager.isCanvasCreated && this.currentTool.Name == "Rectangle")
                {
                    int x = Math.Min(startPoint.X, endPoint.X);
                    int y = Math.Min(startPoint.Y, endPoint.Y);
                    int width = Math.Abs(startPoint.X - endPoint.X);
                    int height = Math.Abs(startPoint.Y - endPoint.Y);
                    g.DrawRectangle(currentPen, x, y, width, height);
                }
            }
        }

        public void DrawEllipse(CanvasManager canvasManager)
        {
            using (Graphics g = canvasManager.canvasPanel.CreateGraphics())
            {
                if (canvasManager.isCanvasCreated && this.currentTool.Name == "Ellipse")
                {
                    int x = Math.Min(startPoint.X, endPoint.X);
                    int y = Math.Min(startPoint.Y, endPoint.Y);
                    int width = Math.Abs(startPoint.X - endPoint.X);
                    int height = Math.Abs(startPoint.Y - endPoint.Y);
                    g.DrawEllipse(currentPen, x, y, width, height);
                }
            }
        }

    }
}
