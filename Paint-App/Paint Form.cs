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
        private bool isDrawing = false;
        private bool isThereCanva = false;
        private Pen currentPen;
        public Tool currentTool;
        private CanvasManager canvasManager;

        public PaintForm()
        {
            InitializeComponent();

            currentTool = new Tool();
            currentPen = new Pen(Color.Black, 5);
            canvasManager = new CanvasManager(this);

            // Subscribe to the MouseMove event for the form
            this.MouseMove += new MouseEventHandler(PaintForm_MouseMove);
        }

        // Event handler for mouse movement
        private void PaintForm_MouseMove(object sender, MouseEventArgs e)
        {
            Point mousePosition = e.Location;

            lblMousePos.Text = $"Mouse Position: ({mousePosition.X}, {mousePosition.Y})";

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void FileNew_Click(object sender, EventArgs e)
        {
            // When clicking on File > New, it adds a new canva on which you can draw
            // When there is already a canva, it clears the canva after asking the user if he is sure

            canvasManager.CreateOrClearCanvas();

        }

        private void ToolSelect_Brush_Click(object sender, EventArgs e)
        {
            currentTool.Name = "Brush";
            lblTool.Text = currentTool.Name;
        }

        private void ToolSelect_Rectangle_Click(object sender, EventArgs e)
        {
            currentTool.Name = "Rectangle";
            lblTool.Text = currentTool.Name;
        }

        private void ToolSelect_Circle_Click(object sender, EventArgs e)
        {
            currentTool.Name = "Circle";
            lblTool.Text = currentTool.Name;
        }
    }
}
