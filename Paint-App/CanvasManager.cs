using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public class CanvasManager
    {
        public Panel canvasPanel = new Panel();
        public bool isCanvasCreated = false;
        private PaintForm mainForm;
        public Color CanvasBackColor = Color.White;

        public DrawingManager drawingManager;

        private Point canvasLocation = new System.Drawing.Point(30, 30);
        private Point centerOfWindow;
        private Size canvasSize = new System.Drawing.Size(1500, 500);

        public CanvasManager(PaintForm form)
        {
            this.mainForm = form;
            drawingManager = new DrawingManager();
        }

        public void CreateOrClearCanvas()
        {
            if (!isCanvasCreated)
            {
                // Create a new canvas Panel
                canvasPanel = new Panel
                {
                    Dock = DockStyle.None,
                    BackColor = this.CanvasBackColor, 
                    BorderStyle = BorderStyle.FixedSingle
                };

                this.isCanvasCreated = true;

                CenterPanel();

                // Add the canvas to the form's controls
                mainForm.Controls.Add(canvasPanel);

                // Add event handler for form resize
                mainForm.Resize += MainForm_Resize;

            }
            else
            {
                // Ask the user if they want to clear the existing canvas
                DialogResult result = MessageBox.Show("A canvas already exists. Do you want to clear it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    this.ClearCanvas();
                }
            }
        }

        public void ClearCanvas()
        {
            if (isCanvasCreated)
            {
                using (Graphics g = canvasPanel.CreateGraphics())
                {
                    g.Clear(this.CanvasBackColor);
                }
            }
        }

        private void CenterPanel()
        {
            //
            // The Panel should always be in the center of the window.
            // First, we check if there is any toolbar on top of the window to know where the origin point should be.
            //

            centerOfWindow = new System.Drawing.Point(0, 0);

            if (mainForm.Controls.OfType<MenuStrip>().Any())
            {
                var menuStripHeight = mainForm.Controls.OfType<MenuStrip>().First().Height;
                this.centerOfWindow.Y += menuStripHeight;

                if (mainForm.Controls.OfType<ToolStrip>().Any())
                {
                    var toolStripHeight = mainForm.Controls.OfType<ToolStrip>().First().Height;
                    this.centerOfWindow.Y += toolStripHeight;
                }
            }
            //
            // Then we define the center point of the window.
            //
            this.centerOfWindow.X += mainForm.ClientSize.Width / 2;
            this.centerOfWindow.Y += mainForm.ClientSize.Height;
            this.centerOfWindow.Y /= 2;
            //
            // Then assign the canvasLocation to the center of the window.
            //
            this.canvasLocation.X = this.centerOfWindow.X - this.canvasSize.Width / 2;
            this.canvasLocation.Y = this.centerOfWindow.Y - this.canvasSize.Height / 2;
            //
            // Need to check whether there is a statusStrip as well.
            //
            if (mainForm.Controls.OfType<StatusStrip>().Any())
            {
                var StatusStripHeight = mainForm.Controls.OfType<StatusStrip>().First().Height;
                this.canvasLocation.Y -= StatusStripHeight / 2;
            }

            canvasPanel.Location = this.canvasLocation;
            canvasPanel.Size = this.canvasSize;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            CenterPanel();
            Console.WriteLine($"Panel visible: {canvasPanel.Visible}, Location: {canvasPanel.Location}, Size: {canvasPanel.Size}");
        }

        public void SubscribeToEvents()
        {
            if (this.canvasPanel != null)
            {
                this.canvasPanel.MouseDown += DrawingPanel_MouseDown;
                this.canvasPanel.MouseMove += DrawingPanel_MouseMove;
                this.canvasPanel.MouseUp += DrawingPanel_MouseUp;
                this.canvasPanel.Paint += DrawingPanel_Paint;
            }
        }

        private void DrawingPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingManager.StartDrawing(e.Location);
                this.canvasPanel.Invalidate();
            }
        }

        private void DrawingPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingManager.ContinueDrawing(e.Location);
                this.canvasPanel.Invalidate();
            }
        }

        private void DrawingPanel_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                drawingManager.EndDrawing();
                this.canvasPanel.Invalidate();
            }
        }

        private void DrawingPanel_Paint(object sender, PaintEventArgs e)
        {
            // Method called when Invalidate() is called
            drawingManager.DrawAllObjects(this);
        }
    }
}