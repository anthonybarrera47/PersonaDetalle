namespace PersonaDetalle.UI.Registro
{
    partial class RegistroPersonas
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
            this.FechaTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DireccionTextBox = new System.Windows.Forms.MaskedTextBox();
            this.CedulaMasketTextBox = new System.Windows.Forms.MaskedTextBox();
            this.NombreTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.IDNumericUpDowm = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.AgregarTelefonoButton = new System.Windows.Forms.Button();
            this.RemoverFilaButton = new System.Windows.Forms.Button();
            this.AgregarTipoButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.TelefonoMasketTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.detalleDataGridView = new System.Windows.Forms.DataGridView();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.BuscarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.telefonoDetalleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.telefonoDetalleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDowm)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // FechaTimePicker
            // 
            this.FechaTimePicker.CustomFormat = "dd/MM/yyyy";
            this.FechaTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaTimePicker.Location = new System.Drawing.Point(328, 128);
            this.FechaTimePicker.Name = "FechaTimePicker";
            this.FechaTimePicker.Size = new System.Drawing.Size(97, 22);
            this.FechaTimePicker.TabIndex = 25;
            // 
            // DireccionTextBox
            // 
            this.DireccionTextBox.Location = new System.Drawing.Point(112, 97);
            this.DireccionTextBox.Name = "DireccionTextBox";
            this.DireccionTextBox.Size = new System.Drawing.Size(313, 22);
            this.DireccionTextBox.TabIndex = 24;
            // 
            // CedulaMasketTextBox
            // 
            this.CedulaMasketTextBox.Location = new System.Drawing.Point(112, 125);
            this.CedulaMasketTextBox.Mask = "000-0000000-0";
            this.CedulaMasketTextBox.Name = "CedulaMasketTextBox";
            this.CedulaMasketTextBox.Size = new System.Drawing.Size(101, 22);
            this.CedulaMasketTextBox.TabIndex = 23;
            // 
            // NombreTextBox
            // 
            this.NombreTextBox.Location = new System.Drawing.Point(113, 67);
            this.NombreTextBox.MaxLength = 30;
            this.NombreTextBox.Name = "NombreTextBox";
            this.NombreTextBox.Size = new System.Drawing.Size(313, 22);
            this.NombreTextBox.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 21;
            this.label6.Text = "F.Nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 20;
            this.label5.Text = "Direccion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "Cedula";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "ID";
            // 
            // IDNumericUpDowm
            // 
            this.IDNumericUpDowm.Location = new System.Drawing.Point(112, 36);
            this.IDNumericUpDowm.Name = "IDNumericUpDowm";
            this.IDNumericUpDowm.Size = new System.Drawing.Size(120, 22);
            this.IDNumericUpDowm.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.AgregarTelefonoButton);
            this.groupBox1.Controls.Add(this.RemoverFilaButton);
            this.groupBox1.Controls.Add(this.AgregarTipoButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.TipoComboBox);
            this.groupBox1.Controls.Add(this.TelefonoMasketTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.detalleDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 153);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(414, 247);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Telefonos";
            // 
            // AgregarTelefonoButton
            // 
            this.AgregarTelefonoButton.Image = global::PersonaDetalle.Properties.Resources.if_add_134224;
            this.AgregarTelefonoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AgregarTelefonoButton.Location = new System.Drawing.Point(247, 201);
            this.AgregarTelefonoButton.Name = "AgregarTelefonoButton";
            this.AgregarTelefonoButton.Size = new System.Drawing.Size(161, 40);
            this.AgregarTelefonoButton.TabIndex = 23;
            this.AgregarTelefonoButton.Text = "Agregar Telefono";
            this.AgregarTelefonoButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AgregarTelefonoButton.UseVisualStyleBackColor = true;
            this.AgregarTelefonoButton.Click += new System.EventHandler(this.AgregarTelefonoButton_Click);
            // 
            // RemoverFilaButton
            // 
            this.RemoverFilaButton.Image = global::PersonaDetalle.Properties.Resources.if_cross_24_103181;
            this.RemoverFilaButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoverFilaButton.Location = new System.Drawing.Point(7, 201);
            this.RemoverFilaButton.Name = "RemoverFilaButton";
            this.RemoverFilaButton.Size = new System.Drawing.Size(138, 40);
            this.RemoverFilaButton.TabIndex = 22;
            this.RemoverFilaButton.Text = "Remover Fila";
            this.RemoverFilaButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoverFilaButton.UseVisualStyleBackColor = true;
            this.RemoverFilaButton.Click += new System.EventHandler(this.RemoverFilaButton_Click);
            // 
            // AgregarTipoButton
            // 
            this.AgregarTipoButton.Image = global::PersonaDetalle.Properties.Resources.if_add_1342241;
            this.AgregarTipoButton.Location = new System.Drawing.Point(382, 21);
            this.AgregarTipoButton.Name = "AgregarTipoButton";
            this.AgregarTipoButton.Size = new System.Drawing.Size(21, 23);
            this.AgregarTipoButton.TabIndex = 21;
            this.AgregarTipoButton.UseVisualStyleBackColor = true;
            this.AgregarTipoButton.Click += new System.EventHandler(this.AgregarTipoButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(215, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 20;
            this.label7.Text = "Tipo:";
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Location = new System.Drawing.Point(261, 22);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(121, 24);
            this.TipoComboBox.TabIndex = 19;
            // 
            // TelefonoMasketTextBox
            // 
            this.TelefonoMasketTextBox.Location = new System.Drawing.Point(100, 22);
            this.TelefonoMasketTextBox.Mask = "000-0000000";
            this.TelefonoMasketTextBox.Name = "TelefonoMasketTextBox";
            this.TelefonoMasketTextBox.Size = new System.Drawing.Size(100, 22);
            this.TelefonoMasketTextBox.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Telefono";
            // 
            // detalleDataGridView
            // 
            this.detalleDataGridView.AllowUserToOrderColumns = true;
            this.detalleDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleDataGridView.Location = new System.Drawing.Point(7, 49);
            this.detalleDataGridView.Name = "detalleDataGridView";
            this.detalleDataGridView.ReadOnly = true;
            this.detalleDataGridView.RowTemplate.Height = 24;
            this.detalleDataGridView.Size = new System.Drawing.Size(401, 150);
            this.detalleDataGridView.TabIndex = 0;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BuscarButton
            // 
            this.BuscarButton.Image = global::PersonaDetalle.Properties.Resources.if_search_126577;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(238, 12);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(101, 46);
            this.BuscarButton.TabIndex = 14;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = global::PersonaDetalle.Properties.Resources.if_cross_24_103181;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(238, 406);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(71, 69);
            this.EliminarButton.TabIndex = 13;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.Image = global::PersonaDetalle.Properties.Resources.if_floppy_disk_save_103863;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.GuardarButton.Location = new System.Drawing.Point(163, 406);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(72, 69);
            this.GuardarButton.TabIndex = 12;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.Image = global::PersonaDetalle.Properties.Resources.if_new10_216291;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.NuevoButton.Location = new System.Drawing.Point(93, 406);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 69);
            this.NuevoButton.TabIndex = 11;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // telefonoDetalleBindingSource
            // 
            this.telefonoDetalleBindingSource.DataSource = typeof(PersonaDetalle.Entidades.TelefonoDetalle);
            // 
            // telefonoDetalleBindingSource1
            // 
            this.telefonoDetalleBindingSource1.DataSource = typeof(PersonaDetalle.Entidades.TelefonoDetalle);
            // 
            // RegistroPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 487);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.FechaTimePicker);
            this.Controls.Add(this.DireccionTextBox);
            this.Controls.Add(this.CedulaMasketTextBox);
            this.Controls.Add(this.NombreTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDNumericUpDowm);
            this.Controls.Add(this.BuscarButton);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Name = "RegistroPersonas";
            this.Text = "RegistroPersonas";
            ((System.ComponentModel.ISupportInitialize)(this.IDNumericUpDowm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detalleDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.telefonoDetalleBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.DateTimePicker FechaTimePicker;
        private System.Windows.Forms.MaskedTextBox DireccionTextBox;
        private System.Windows.Forms.MaskedTextBox CedulaMasketTextBox;
        private System.Windows.Forms.TextBox NombreTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown IDNumericUpDowm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox TelefonoMasketTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView detalleDataGridView;
        private System.Windows.Forms.Button AgregarTipoButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.Button RemoverFilaButton;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Button AgregarTelefonoButton;
        private System.Windows.Forms.BindingSource telefonoDetalleBindingSource;
        private System.Windows.Forms.BindingSource telefonoDetalleBindingSource1;
    }
}