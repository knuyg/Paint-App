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
        private Form mainForm;

        private Point location = new System.Drawing.Point(30, 30);
        private Size size = new System.Drawing.Size(50, 50);

        public CanvasManager(Form form)
        {
            this.mainForm = form;
        }

        public void CreateOrClearCanvas()
        {
            if (!isCanvasCreated)
            {
                // / Create a new canvas Panel
                canvasPanel = new Panel
                {
                    Dock = DockStyle.None,
                    BackColor = Color.Red,
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Initialize the canvas.
                // The canvas has to be 50 px below the latest toolbar, and 50 px on the right of the left border of the window.
                //
                // Need first to check whether there is any MenuStrip and ToolStrip
                // If that's the case, just need to append the heights of these strips to the default location
                //

                if (mainForm.Controls.OfType<MenuStrip>().Any())
                {
                    var menuStripHeight = mainForm.Controls.OfType<MenuStrip>().First().Height;
                    this.location.Y += menuStripHeight;

                    if (mainForm.Controls.OfType<ToolStrip>().Any())
                    {
                        var toolStripHeight = mainForm.Controls.OfType<ToolStrip>().First().Height;
                        this.location.Y += toolStripHeight;
                    }
                }

                canvasPanel.Location = this.location;
                canvasPanel.Size = this.size;

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
    }
}
