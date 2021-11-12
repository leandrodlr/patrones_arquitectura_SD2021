
namespace CADWindowsFormsApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.circuloButton = new System.Windows.Forms.Button();
            this.cuadradoButton = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // circuloButton
            // 
            this.circuloButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circuloButton.Location = new System.Drawing.Point(1469, 45);
            this.circuloButton.Name = "circuloButton";
            this.circuloButton.Size = new System.Drawing.Size(114, 80);
            this.circuloButton.TabIndex = 0;
            this.circuloButton.Text = "Circulo";
            this.circuloButton.UseVisualStyleBackColor = true;
            this.circuloButton.Click += new System.EventHandler(this.circuloButton_Click);
            // 
            // cuadradoButton
            // 
            this.cuadradoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cuadradoButton.Location = new System.Drawing.Point(1469, 141);
            this.cuadradoButton.Name = "cuadradoButton";
            this.cuadradoButton.Size = new System.Drawing.Size(114, 77);
            this.cuadradoButton.TabIndex = 1;
            this.cuadradoButton.Text = "Cuadrado";
            this.cuadradoButton.UseVisualStyleBackColor = true;
            this.cuadradoButton.Click += new System.EventHandler(this.cuadradoButton_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.duplicarToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(135, 52);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // duplicarToolStripMenuItem
            // 
            this.duplicarToolStripMenuItem.Name = "duplicarToolStripMenuItem";
            this.duplicarToolStripMenuItem.Size = new System.Drawing.Size(134, 24);
            this.duplicarToolStripMenuItem.Text = "Duplicar";
            this.duplicarToolStripMenuItem.Click += new System.EventHandler(this.duplicarToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 802);
            this.Controls.Add(this.cuadradoButton);
            this.Controls.Add(this.circuloButton);
            this.Name = "Form1";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button circuloButton;
        private System.Windows.Forms.Button cuadradoButton;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicarToolStripMenuItem;
    }
}

