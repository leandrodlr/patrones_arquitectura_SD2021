
namespace ContactosWindowsFormsApp
{
    partial class principalForm
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
            this.buscarLabel = new System.Windows.Forms.Label();
            this.buscarTextBox = new System.Windows.Forms.TextBox();
            this.contactosDataGridView = new System.Windows.Forms.DataGridView();
            this.nombresColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefonoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.generoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opcionesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).BeginInit();
            this.opcionesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // buscarLabel
            // 
            this.buscarLabel.AutoSize = true;
            this.buscarLabel.Location = new System.Drawing.Point(24, 24);
            this.buscarLabel.Name = "buscarLabel";
            this.buscarLabel.Size = new System.Drawing.Size(56, 17);
            this.buscarLabel.TabIndex = 0;
            this.buscarLabel.Text = "Buscar:";
            // 
            // buscarTextBox
            // 
            this.buscarTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buscarTextBox.Location = new System.Drawing.Point(101, 24);
            this.buscarTextBox.Name = "buscarTextBox";
            this.buscarTextBox.Size = new System.Drawing.Size(676, 22);
            this.buscarTextBox.TabIndex = 1;
            this.buscarTextBox.TextChanged += new System.EventHandler(this.buscarTextBox_TextChanged);
            // 
            // contactosDataGridView
            // 
            this.contactosDataGridView.AllowUserToAddRows = false;
            this.contactosDataGridView.AllowUserToDeleteRows = false;
            this.contactosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contactosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.contactosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombresColumn,
            this.apellidosColumn,
            this.telefonoColumn,
            this.generoColumn});
            this.contactosDataGridView.ContextMenuStrip = this.opcionesContextMenuStrip;
            this.contactosDataGridView.Location = new System.Drawing.Point(27, 74);
            this.contactosDataGridView.Name = "contactosDataGridView";
            this.contactosDataGridView.ReadOnly = true;
            this.contactosDataGridView.RowHeadersWidth = 51;
            this.contactosDataGridView.RowTemplate.Height = 24;
            this.contactosDataGridView.Size = new System.Drawing.Size(842, 532);
            this.contactosDataGridView.TabIndex = 2;
            // 
            // nombresColumn
            // 
            this.nombresColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombresColumn.DataPropertyName = "Nombres";
            this.nombresColumn.HeaderText = "Nombres";
            this.nombresColumn.MinimumWidth = 6;
            this.nombresColumn.Name = "nombresColumn";
            this.nombresColumn.ReadOnly = true;
            // 
            // apellidosColumn
            // 
            this.apellidosColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.apellidosColumn.DataPropertyName = "Apellidos";
            this.apellidosColumn.HeaderText = "Apellidos";
            this.apellidosColumn.MinimumWidth = 6;
            this.apellidosColumn.Name = "apellidosColumn";
            this.apellidosColumn.ReadOnly = true;
            // 
            // telefonoColumn
            // 
            this.telefonoColumn.DataPropertyName = "Telefono";
            this.telefonoColumn.HeaderText = "Telefono";
            this.telefonoColumn.MinimumWidth = 6;
            this.telefonoColumn.Name = "telefonoColumn";
            this.telefonoColumn.ReadOnly = true;
            this.telefonoColumn.Width = 125;
            // 
            // generoColumn
            // 
            this.generoColumn.DataPropertyName = "Sexo";
            this.generoColumn.HeaderText = "Genero";
            this.generoColumn.MinimumWidth = 6;
            this.generoColumn.Name = "generoColumn";
            this.generoColumn.ReadOnly = true;
            this.generoColumn.Width = 125;
            // 
            // opcionesContextMenuStrip
            // 
            this.opcionesContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.opcionesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.opcionesContextMenuStrip.Name = "contextMenuStrip1";
            this.opcionesContextMenuStrip.Size = new System.Drawing.Size(143, 52);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(142, 24);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // nuevoButton
            // 
            this.nuevoButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.nuevoButton.Location = new System.Drawing.Point(795, 18);
            this.nuevoButton.Name = "nuevoButton";
            this.nuevoButton.Size = new System.Drawing.Size(75, 35);
            this.nuevoButton.TabIndex = 3;
            this.nuevoButton.Text = "&Nuevo";
            this.nuevoButton.UseVisualStyleBackColor = true;
            this.nuevoButton.Click += new System.EventHandler(this.nuevoButton_Click);
            // 
            // principalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 618);
            this.Controls.Add(this.nuevoButton);
            this.Controls.Add(this.contactosDataGridView);
            this.Controls.Add(this.buscarTextBox);
            this.Controls.Add(this.buscarLabel);
            this.Name = "principalForm";
            this.ShowIcon = false;
            this.Text = "Lista de contactos";
            this.Load += new System.EventHandler(this.principalForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.contactosDataGridView)).EndInit();
            this.opcionesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label buscarLabel;
        private System.Windows.Forms.TextBox buscarTextBox;
        private System.Windows.Forms.DataGridView contactosDataGridView;
        private System.Windows.Forms.Button nuevoButton;
        private System.Windows.Forms.ContextMenuStrip opcionesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombresColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefonoColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn generoColumn;
    }
}

