
namespace CADWindowsFormsApp
{
    partial class mainForm
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
            this.menuContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorButton = new System.Windows.Forms.Button();
            this.colorLabel = new System.Windows.Forms.Label();
            this.altoLabel = new System.Windows.Forms.Label();
            this.altoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anchoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.anchoLabel = new System.Windows.Forms.Label();
            this.menuContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.altoNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // circuloButton
            // 
            this.circuloButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.circuloButton.Location = new System.Drawing.Point(1479, 45);
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
            this.cuadradoButton.Location = new System.Drawing.Point(1479, 141);
            this.cuadradoButton.Name = "cuadradoButton";
            this.cuadradoButton.Size = new System.Drawing.Size(114, 77);
            this.cuadradoButton.TabIndex = 1;
            this.cuadradoButton.Text = "Cuadrado";
            this.cuadradoButton.UseVisualStyleBackColor = true;
            this.cuadradoButton.Click += new System.EventHandler(this.cuadradoButton_Click);
            // 
            // menuContextMenuStrip
            // 
            this.menuContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.eliminarToolStripMenuItem,
            this.duplicarToolStripMenuItem});
            this.menuContextMenuStrip.Name = "contextMenuStrip1";
            this.menuContextMenuStrip.Size = new System.Drawing.Size(135, 52);
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
            // colorButton
            // 
            this.colorButton.BackColor = System.Drawing.Color.Black;
            this.colorButton.Location = new System.Drawing.Point(1550, 224);
            this.colorButton.Name = "colorButton";
            this.colorButton.Size = new System.Drawing.Size(43, 48);
            this.colorButton.TabIndex = 2;
            this.colorButton.UseVisualStyleBackColor = false;
            this.colorButton.Click += new System.EventHandler(this.colorButton_Click);
            // 
            // colorLabel
            // 
            this.colorLabel.AutoSize = true;
            this.colorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.colorLabel.Location = new System.Drawing.Point(1479, 236);
            this.colorLabel.Name = "colorLabel";
            this.colorLabel.Size = new System.Drawing.Size(65, 25);
            this.colorLabel.TabIndex = 3;
            this.colorLabel.Text = "Color:";
            // 
            // altoLabel
            // 
            this.altoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altoLabel.AutoSize = true;
            this.altoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altoLabel.Location = new System.Drawing.Point(1462, 282);
            this.altoLabel.Name = "altoLabel";
            this.altoLabel.Size = new System.Drawing.Size(52, 25);
            this.altoLabel.TabIndex = 4;
            this.altoLabel.Text = "Alto:";
            // 
            // altoNumericUpDown
            // 
            this.altoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.altoNumericUpDown.Location = new System.Drawing.Point(1533, 282);
            this.altoNumericUpDown.Name = "altoNumericUpDown";
            this.altoNumericUpDown.Size = new System.Drawing.Size(57, 22);
            this.altoNumericUpDown.TabIndex = 5;
            this.altoNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // anchoNumericUpDown
            // 
            this.anchoNumericUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchoNumericUpDown.Location = new System.Drawing.Point(1533, 312);
            this.anchoNumericUpDown.Name = "anchoNumericUpDown";
            this.anchoNumericUpDown.Size = new System.Drawing.Size(57, 22);
            this.anchoNumericUpDown.TabIndex = 7;
            this.anchoNumericUpDown.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // anchoLabel
            // 
            this.anchoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.anchoLabel.AutoSize = true;
            this.anchoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.anchoLabel.Location = new System.Drawing.Point(1462, 310);
            this.anchoLabel.Name = "anchoLabel";
            this.anchoLabel.Size = new System.Drawing.Size(75, 25);
            this.anchoLabel.TabIndex = 6;
            this.anchoLabel.Text = "Ancho:";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1609, 802);
            this.Controls.Add(this.anchoNumericUpDown);
            this.Controls.Add(this.anchoLabel);
            this.Controls.Add(this.altoNumericUpDown);
            this.Controls.Add(this.altoLabel);
            this.Controls.Add(this.colorLabel);
            this.Controls.Add(this.colorButton);
            this.Controls.Add(this.cuadradoButton);
            this.Controls.Add(this.circuloButton);
            this.Name = "mainForm";
            this.Text = "Paint";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mainForm_MouseUp);
            this.menuContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.altoNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anchoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button circuloButton;
        private System.Windows.Forms.Button cuadradoButton;
        private System.Windows.Forms.ContextMenuStrip menuContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicarToolStripMenuItem;
        private System.Windows.Forms.Button colorButton;
        private System.Windows.Forms.Label colorLabel;
        private System.Windows.Forms.Label altoLabel;
        private System.Windows.Forms.NumericUpDown altoNumericUpDown;
        private System.Windows.Forms.NumericUpDown anchoNumericUpDown;
        private System.Windows.Forms.Label anchoLabel;
    }
}

