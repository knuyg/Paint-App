namespace Paint_App
{
    partial class PaintForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaintForm));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.ToolSelect_Brush = new System.Windows.Forms.ToolStripButton();
            this.ToolSelect_Rectangle = new System.Windows.Forms.ToolStripButton();
            this.ToolSelect_Circle = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblMousePos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTool = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1924, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(122, 26);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.FileNew_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolSelect_Brush,
            this.ToolSelect_Rectangle,
            this.ToolSelect_Circle,
            this.toolStripSeparator1,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 30);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1924, 31);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // ToolSelect_Brush
            // 
            this.ToolSelect_Brush.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSelect_Brush.Image = ((System.Drawing.Image)(resources.GetObject("ToolSelect_Brush.Image")));
            this.ToolSelect_Brush.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSelect_Brush.Name = "ToolSelect_Brush";
            this.ToolSelect_Brush.Size = new System.Drawing.Size(29, 28);
            this.ToolSelect_Brush.Text = "Brush tool";
            this.ToolSelect_Brush.ToolTipText = "Brush tool";
            this.ToolSelect_Brush.Click += new System.EventHandler(this.ToolSelect_Brush_Click);
            // 
            // ToolSelect_Rectangle
            // 
            this.ToolSelect_Rectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSelect_Rectangle.Image = global::Paint_App.Properties.Resources._002_rectangle;
            this.ToolSelect_Rectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSelect_Rectangle.Name = "ToolSelect_Rectangle";
            this.ToolSelect_Rectangle.Size = new System.Drawing.Size(29, 28);
            this.ToolSelect_Rectangle.Text = "Rectangle tool";
            this.ToolSelect_Rectangle.ToolTipText = "Rectangle tool";
            this.ToolSelect_Rectangle.Click += new System.EventHandler(this.ToolSelect_Rectangle_Click);
            // 
            // ToolSelect_Circle
            // 
            this.ToolSelect_Circle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolSelect_Circle.Image = global::Paint_App.Properties.Resources._001_ellipse;
            this.ToolSelect_Circle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolSelect_Circle.Name = "ToolSelect_Circle";
            this.ToolSelect_Circle.Size = new System.Drawing.Size(29, 28);
            this.ToolSelect_Circle.Text = "Ellipse tool";
            this.ToolSelect_Circle.ToolTipText = "Ellipse tool";
            this.ToolSelect_Circle.Click += new System.EventHandler(this.ToolSelect_Circle_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(29, 28);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblMousePos,
            this.lblTool});
            this.statusStrip1.Location = new System.Drawing.Point(0, 773);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(19, 0, 1, 0);
            this.statusStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.statusStrip1.Size = new System.Drawing.Size(1924, 26);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblMousePos
            // 
            this.lblMousePos.Name = "lblMousePos";
            this.lblMousePos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMousePos.Size = new System.Drawing.Size(149, 20);
            this.lblMousePos.Text = "Mouse Position: (0, 0)";
            // 
            // lblTool
            // 
            this.lblTool.Name = "lblTool";
            this.lblTool.Size = new System.Drawing.Size(45, 20);
            this.lblTool.Text = "Brush";
            // 
            // PaintForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1924, 799);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PaintForm";
            this.Text = "Paint App";
            this.Load += new System.EventHandler(this.PaintForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton ToolSelect_Brush;
        private System.Windows.Forms.ToolStripButton ToolSelect_Rectangle;
        private System.Windows.Forms.ToolStripButton ToolSelect_Circle;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblMousePos;
        private System.Windows.Forms.ToolStripStatusLabel lblTool;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}

