
namespace ContactosWindowsFormsApp
{
    partial class contactoDialog
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
            this.nombresLabel = new System.Windows.Forms.Label();
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.apellidosTextBox = new System.Windows.Forms.TextBox();
            this.apellidosLabel = new System.Windows.Forms.Label();
            this.telefonoLabel = new System.Windows.Forms.Label();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.generoComboBox = new System.Windows.Forms.ComboBox();
            this.generoLabel = new System.Windows.Forms.Label();
            this.aceptarButton = new System.Windows.Forms.Button();
            this.cancelarButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nombresLabel
            // 
            this.nombresLabel.AutoSize = true;
            this.nombresLabel.Location = new System.Drawing.Point(18, 26);
            this.nombresLabel.Name = "nombresLabel";
            this.nombresLabel.Size = new System.Drawing.Size(79, 17);
            this.nombresLabel.TabIndex = 0;
            this.nombresLabel.Text = "Nombre(s):";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nombresTextBox.Location = new System.Drawing.Point(103, 23);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(443, 22);
            this.nombresTextBox.TabIndex = 1;
            // 
            // apellidosTextBox
            // 
            this.apellidosTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.apellidosTextBox.Location = new System.Drawing.Point(103, 62);
            this.apellidosTextBox.Name = "apellidosTextBox";
            this.apellidosTextBox.Size = new System.Drawing.Size(443, 22);
            this.apellidosTextBox.TabIndex = 3;
            // 
            // apellidosLabel
            // 
            this.apellidosLabel.AutoSize = true;
            this.apellidosLabel.Location = new System.Drawing.Point(18, 65);
            this.apellidosLabel.Name = "apellidosLabel";
            this.apellidosLabel.Size = new System.Drawing.Size(79, 17);
            this.apellidosLabel.TabIndex = 2;
            this.apellidosLabel.Text = "Apellido(s):";
            // 
            // telefonoLabel
            // 
            this.telefonoLabel.AutoSize = true;
            this.telefonoLabel.Location = new System.Drawing.Point(18, 104);
            this.telefonoLabel.Name = "telefonoLabel";
            this.telefonoLabel.Size = new System.Drawing.Size(68, 17);
            this.telefonoLabel.TabIndex = 4;
            this.telefonoLabel.Text = "Teléfono:";
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(103, 101);
            this.telefonoMaskedTextBox.Mask = "000-000-0000";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(121, 22);
            this.telefonoMaskedTextBox.TabIndex = 5;
            // 
            // generoComboBox
            // 
            this.generoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.generoComboBox.FormattingEnabled = true;
            this.generoComboBox.Location = new System.Drawing.Point(103, 140);
            this.generoComboBox.Name = "generoComboBox";
            this.generoComboBox.Size = new System.Drawing.Size(121, 24);
            this.generoComboBox.TabIndex = 6;
            // 
            // generoLabel
            // 
            this.generoLabel.AutoSize = true;
            this.generoLabel.Location = new System.Drawing.Point(18, 145);
            this.generoLabel.Name = "generoLabel";
            this.generoLabel.Size = new System.Drawing.Size(60, 17);
            this.generoLabel.TabIndex = 7;
            this.generoLabel.Text = "Genero:";
            // 
            // aceptarButton
            // 
            this.aceptarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.aceptarButton.Location = new System.Drawing.Point(389, 217);
            this.aceptarButton.Name = "aceptarButton";
            this.aceptarButton.Size = new System.Drawing.Size(75, 38);
            this.aceptarButton.TabIndex = 8;
            this.aceptarButton.Text = "&Aceptar";
            this.aceptarButton.UseVisualStyleBackColor = true;
            this.aceptarButton.Click += new System.EventHandler(this.aceptarButton_Click);
            // 
            // cancelarButton
            // 
            this.cancelarButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelarButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelarButton.Location = new System.Drawing.Point(470, 217);
            this.cancelarButton.Name = "cancelarButton";
            this.cancelarButton.Size = new System.Drawing.Size(75, 38);
            this.cancelarButton.TabIndex = 9;
            this.cancelarButton.Text = "&Cancelar";
            this.cancelarButton.UseVisualStyleBackColor = true;
            // 
            // contactoDialog
            // 
            this.AcceptButton = this.aceptarButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelarButton;
            this.ClientSize = new System.Drawing.Size(557, 267);
            this.Controls.Add(this.cancelarButton);
            this.Controls.Add(this.aceptarButton);
            this.Controls.Add(this.generoLabel);
            this.Controls.Add(this.generoComboBox);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(this.telefonoLabel);
            this.Controls.Add(this.apellidosTextBox);
            this.Controls.Add(this.apellidosLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Controls.Add(this.nombresLabel);
            this.Name = "contactoDialog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contacto";
            this.Load += new System.EventHandler(this.contactoDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nombresLabel;
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox apellidosTextBox;
        private System.Windows.Forms.Label apellidosLabel;
        private System.Windows.Forms.Label telefonoLabel;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.ComboBox generoComboBox;
        private System.Windows.Forms.Label generoLabel;
        private System.Windows.Forms.Button aceptarButton;
        private System.Windows.Forms.Button cancelarButton;
    }
}