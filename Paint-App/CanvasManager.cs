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

        private Panel canvasPanel;
        private bool isCanvasCreated = false;
        private PaintForm mainForm;

        private Point canvasLocation = new System.Drawing.Point(30, 30);
        private Point centerOfWindow = new System.Drawing.Point(0, 0);
        private Size canvasSize = new System.Drawing.Size(1500, 500);

        public CanvasManager(PaintForm form)
        {
            this.mainForm = form;
        }

        public void CreateOrClearCanvas()
        {
            if (!isCanvasCreated)
            {
                // Create a new canvas Panel
                canvasPanel = new Panel
                {
                    Dock = DockStyle.None,
                    BackColor = Color.Red, // !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!! 
                    BorderStyle = BorderStyle.FixedSingle
                };

                this.isCanvasCreated = true;
                //
                // Initialize the canvas.
                //
                // The Panel should always be in the center of the window.
                // First, we check if there is any toolbar on top of the window to know where the origin point should be.
                //
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
                this.centerOfWindow.X += mainForm.ClientSize.Width/2;
                this.centerOfWindow.Y += mainForm.ClientSize.Height;
                this.centerOfWindow.Y /= 2;
                //
                // Need to check whether there is a statusStrip as well
                //
                this.canvasLocation.X = this.centerOfWindow.X - this.canvasSize.Width/2;
                this.canvasLocation.Y = this.centerOfWindow.Y - this.canvasSize.Height/2;

                if (mainForm.Controls.OfType<StatusStrip>().Any())
                {
                    var StatusStripHeight = mainForm.Controls.OfType<StatusStrip>().First().Height;
                    this.canvasLocation.Y -= StatusStripHeight / 2;
                }

                canvasPanel.Location = this.canvasLocation;
                canvasPanel.Size = this.canvasSize;

                // Add the canvas to the form's controls
                mainForm.Controls.Add(canvasPanel);

            }
            else
            {
                // Ask the user if they want to clear the existing canvas
                DialogResult result = MessageBox.Show("A canvas already exists. Do you want to clear it?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Clear the existing canvas
                    using (Graphics g = canvasPanel.CreateGraphics())
                    {
                        g.Clear(Color.White);
                    }
                }
            }
        }

        public void DrawRectangle()
        {
            if (isCanvasCreated && this.mainForm.currentTool.Name == "Rectangle")
            {

            }
        }
    }
}
