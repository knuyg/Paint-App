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
        #region Variables
        public Pen currentPen;
        public Tool currentTool;

        // Variables for drawing
        private Point startPoint;
        private Point endPoint;
        private bool isDrawing;

        public List<Object> objectsList = new List<Object>();
        public int numberOfObjects = 0;
        #endregion

        public DrawingManager()
        {
            this.currentPen = new Pen(Color.Black, 5);
            this.currentTool = new Tool();
        }

        #region Methods handling the list of objects
        public void AddRectangle(Point location)
        {
            numberOfObjects++;
            Rectangle rect = new Rectangle(location.X, location.Y);
            this.objectsList.Add(rect);
        }

        public void AddEllipse(Point location)
        {
            numberOfObjects++;
            Ellipse ell = new Ellipse(location.X, location.Y);
            this.objectsList.Add(ell);
        }

        public void PrintObjects()
        {
            Console.WriteLine("Drawing Objects:");
            for (int i = 0; i < objectsList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {objectsList[i].GetInfo()}");
            }
        }
        #endregion

        #region Methods to draw objects
        public void StartDrawing(Point location)
        {
            if (currentTool.Name == "Rectangle")
            {
                AddRectangle(location);
                isDrawing = true;
                startPoint = location;
                endPoint = location;
            }
            else if (currentTool.Name == "Ellipse")
            {
                AddEllipse(location);
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
                objectsList[objectsList.Count - 1].x = Math.Min(startPoint.X, endPoint.X);
                objectsList[objectsList.Count - 1].y = Math.Min(startPoint.Y, endPoint.Y);
                objectsList[objectsList.Count - 1].width = Math.Abs(startPoint.X - endPoint.X);
                objectsList[objectsList.Count - 1].height = Math.Abs(startPoint.Y - endPoint.Y);
            }
        }

        public void EndDrawing()
        {
            isDrawing = false;
        }
        public void DrawAllObjects(CanvasManager canvasManager)
        {
            using (Graphics g = canvasManager.canvasPanel.CreateGraphics())
            {
                if (canvasManager.isCanvasCreated && objectsList.Count > 0)
                {
                    canvasManager.ClearCanvas();

                    foreach (Object obj in objectsList)
                    {
                        obj.DrawObject(g, currentPen);
                    }
                }
            }
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
        #endregion
    }
}
