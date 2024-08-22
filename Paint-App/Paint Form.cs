using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint_App
{
    public partial class PaintForm : System.Windows.Forms.Form
    {
        private CanvasManager canvasManager;

        public PaintForm()
        {
            InitializeComponent();
            canvasManager = new CanvasManager(this);

            // Subscribe to the MouseMove event for the form selection
            this.MouseMove += new MouseEventHandler(PaintForm_MouseMove);

        }

        // Event handler for mouse movement
        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;

            lblMousePos.Text = $"Mouse Position: ({mousePosition.X}, {mousePosition.Y})";

        }

        private void PaintForm_Load(object sender, EventArgs e)
        {

        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            // When clicking on File > New, it adds a new canva on which you can draw
            // When there is already a canva, it clears the canva after asking the user if he is sure

            canvasManager.CreateOrClearCanvas();
            canvasManager.SubscribeToEvents();

        }

        private void ToolSelect_Brush_Click(object sender, EventArgs e)
        {
            canvasManager.drawingManager.currentTool.Name = "Brush";
            lblTool.Text = canvasManager.drawingManager.currentTool.Name;
        }

        private void ToolSelect_Rectangle_Click(object sender, EventArgs e)
        {
            canvasManager.drawingManager.currentTool.Name = "Rectangle";
            lblTool.Text = canvasManager.drawingManager.currentTool.Name;
        }

        private void ToolSelect_Circle_Click(object sender, EventArgs e)
        {
            canvasManager.drawingManager.currentTool.Name = "Ellipse";
            lblTool.Text = canvasManager.drawingManager.currentTool.Name;
        }
    }
}