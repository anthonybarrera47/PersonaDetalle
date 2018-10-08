namespace PersonaDetalle.UI.Registro
{
    partial class RegistroTipoTelefono
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
            System.Windows.Forms.Label tipoTelefonoLabel;
            System.Windows.Forms.Label idLabel1;
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.telefonoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoTelefonoTextBox = new System.Windows.Forms.TextBox();
            this.Buscar = new System.Windows.Forms.Button();
            this.idTelefonoNumericUpDown = new System.Windows.Forms.NumericUpDown();
            tipoTelefonoLabel = new System.Windows.Forms.Label();
            idLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTelefonoNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::PersonaDetalle.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(194, 96);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(71, 69);
            this.EliminarButton.TabIndex = 16;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::PersonaDetalle.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(119, 96);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(72, 69);
            this.GuardarButton.TabIndex = 15;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::PersonaDetalle.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(49, 96);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 69);
            this.NuevoButton.TabIndex = 14;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // telefonoDetalleBindingSource
            // 
            this.telefonoDetalleBindingSource.DataSource = typeof(PersonaDetalle.Entidades.TelefonoDetalle);
            // 
            // tipoTelefonoLabel
            // 
            tipoTelefonoLabel.AutoSize = true;
            tipoTelefonoLabel.Location = new System.Drawing.Point(16, 59);
            tipoTelefonoLabel.Name = "tipoTelefonoLabel";
            tipoTelefonoLabel.Size = new System.Drawing.Size(100, 17);
            tipoTelefonoLabel.TabIndex = 18;
            tipoTelefonoLabel.Text = "Tipo Telefono:";
            // 
            // tipoTelefonoTextBox
            // 
            this.tipoTelefonoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.telefonoDetalleBindingSource, "TipoTelefono", true));
            this.tipoTelefonoTextBox.Location = new System.Drawing.Point(122, 62);
            this.tipoTelefonoTextBox.Name = "tipoTelefonoTextBox";
            this.tipoTelefonoTextBox.Size = new System.Drawing.Size(100, 22);
            this.tipoTelefonoTextBox.TabIndex = 19;
            // 
            // Buscar
            // 
            this.Buscar.Image = global::PersonaDetalle.Properties.Resources.if_search_126577;
            this.Buscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscar.Location = new System.Drawing.Point(245, 34);
            this.Buscar.Name = "Buscar";
            this.Buscar.Size = new System.Drawing.Size(86, 58);
            this.Buscar.TabIndex = 20;
            this.Buscar.Text = "Buscar";
            this.Buscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscar.UseVisualStyleBackColor = true;
            this.Buscar.Click += new System.EventHandler(this.Buscar_Click);
            // 
            // idLabel1
            // 
            idLabel1.AutoSize = true;
            idLabel1.Location = new System.Drawing.Point(16, 34);
            idLabel1.Name = "idLabel1";
            idLabel1.Size = new System.Drawing.Size(23, 17);
            idLabel1.TabIndex = 20;
            idLabel1.Text = "Id:";
            // 
            // idTelefonoNumericUpDown
            // 
            this.idTelefonoNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.telefonoDetalleBindingSource, "Id", true));
            this.idTelefonoNumericUpDown.Location = new System.Drawing.Point(102, 34);
            this.idTelefonoNumericUpDown.Name = "idTelefonoNumericUpDown";
            this.idTelefonoNumericUpDown.Size = new System.Drawing.Size(120, 22);
            this.idTelefonoNumericUpDown.TabIndex = 21;
            // 
            // RegistroTipoTelefono
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 185);
            this.Controls.Add(idLabel1);
            this.Controls.Add(this.idTelefonoNumericUpDown);
            this.Controls.Add(this.Buscar);
            this.Controls.Add(tipoTelefonoLabel);
            this.Controls.Add(this.tipoTelefonoTextBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "RegistroTipoTelefono";
            this.Text = "RegistroTipoTelefono";
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.idTelefonoNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.BindingSource telefonoDetalleBindingSource;
        private System.Windows.Forms.TextBox tipoTelefonoTextBox;
        private System.Windows.Forms.Button Buscar;
        private System.Windows.Forms.NumericUpDown idTelefonoNumericUpDown;
    }
}