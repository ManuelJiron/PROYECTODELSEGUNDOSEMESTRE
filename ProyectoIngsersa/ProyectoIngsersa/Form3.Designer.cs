namespace ProyectoIngsersa
{
    partial class Form3
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInventario = new MetroFramework.Controls.MetroGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAccionID = new MetroFramework.Controls.MetroTextBox();
            this.txtAccionProducto = new MetroFramework.Controls.MetroTextBox();
            this.txtAccionPrecio = new MetroFramework.Controls.MetroTextBox();
            this.txtAccionCantidad = new MetroFramework.Controls.MetroTextBox();
            this.txtAccionUsuario = new MetroFramework.Controls.MetroTextBox();
            this.btnAccionGuardar = new MetroFramework.Controls.MetroButton();
            this.btnAccionSalir = new MetroFramework.Controls.MetroButton();
            this.btnAccionAgregar = new MetroFramework.Controls.MetroButton();
            this.btnAccionEditar = new MetroFramework.Controls.MetroButton();
            this.btnAccionEliminar = new MetroFramework.Controls.MetroButton();
            this.btnAccionCargar = new MetroFramework.Controls.MetroButton();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnAccionReporte = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIngsersa.Properties.Resources.images1;
            this.pictureBox1.Location = new System.Drawing.Point(263, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToResizeRows = false;
            this.dgvInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvInventario.BackgroundColor = System.Drawing.Color.Gray;
            this.dgvInventario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvInventario.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvInventario.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvInventario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvInventario.EnableHeadersVisualStyles = false;
            this.dgvInventario.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.dgvInventario.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dgvInventario.Location = new System.Drawing.Point(232, 401);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvInventario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvInventario.RowHeadersVisible = false;
            this.dgvInventario.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvInventario.Size = new System.Drawing.Size(579, 162);
            this.dgvInventario.TabIndex = 1;
            this.dgvInventario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(143, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 279);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(476, 197);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 18);
            this.label4.TabIndex = 2;
            this.label4.Text = "Cantidad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(476, 237);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 18);
            this.label5.TabIndex = 2;
            this.label5.Text = "Usuario:";
            // 
            // txtAccionID
            // 
            this.txtAccionID.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtAccionID.CustomButton.Image = null;
            this.txtAccionID.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtAccionID.CustomButton.Name = "";
            this.txtAccionID.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccionID.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccionID.CustomButton.TabIndex = 1;
            this.txtAccionID.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccionID.CustomButton.UseSelectable = true;
            this.txtAccionID.CustomButton.Visible = false;
            this.txtAccionID.Lines = new string[0];
            this.txtAccionID.Location = new System.Drawing.Point(198, 197);
            this.txtAccionID.MaxLength = 32767;
            this.txtAccionID.Name = "txtAccionID";
            this.txtAccionID.PasswordChar = '\0';
            this.txtAccionID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccionID.SelectedText = "";
            this.txtAccionID.SelectionLength = 0;
            this.txtAccionID.SelectionStart = 0;
            this.txtAccionID.ShortcutsEnabled = true;
            this.txtAccionID.Size = new System.Drawing.Size(211, 23);
            this.txtAccionID.TabIndex = 3;
            this.txtAccionID.UseCustomBackColor = true;
            this.txtAccionID.UseSelectable = true;
            this.txtAccionID.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccionID.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccionProducto
            // 
            this.txtAccionProducto.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtAccionProducto.CustomButton.Image = null;
            this.txtAccionProducto.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtAccionProducto.CustomButton.Name = "";
            this.txtAccionProducto.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccionProducto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccionProducto.CustomButton.TabIndex = 1;
            this.txtAccionProducto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccionProducto.CustomButton.UseSelectable = true;
            this.txtAccionProducto.CustomButton.Visible = false;
            this.txtAccionProducto.Lines = new string[0];
            this.txtAccionProducto.Location = new System.Drawing.Point(198, 237);
            this.txtAccionProducto.MaxLength = 32767;
            this.txtAccionProducto.Name = "txtAccionProducto";
            this.txtAccionProducto.PasswordChar = '\0';
            this.txtAccionProducto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccionProducto.SelectedText = "";
            this.txtAccionProducto.SelectionLength = 0;
            this.txtAccionProducto.SelectionStart = 0;
            this.txtAccionProducto.ShortcutsEnabled = true;
            this.txtAccionProducto.Size = new System.Drawing.Size(211, 23);
            this.txtAccionProducto.TabIndex = 3;
            this.txtAccionProducto.UseCustomBackColor = true;
            this.txtAccionProducto.UseSelectable = true;
            this.txtAccionProducto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccionProducto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccionPrecio
            // 
            this.txtAccionPrecio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtAccionPrecio.CustomButton.Image = null;
            this.txtAccionPrecio.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtAccionPrecio.CustomButton.Name = "";
            this.txtAccionPrecio.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccionPrecio.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccionPrecio.CustomButton.TabIndex = 1;
            this.txtAccionPrecio.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccionPrecio.CustomButton.UseSelectable = true;
            this.txtAccionPrecio.CustomButton.Visible = false;
            this.txtAccionPrecio.Lines = new string[0];
            this.txtAccionPrecio.Location = new System.Drawing.Point(198, 279);
            this.txtAccionPrecio.MaxLength = 32767;
            this.txtAccionPrecio.Name = "txtAccionPrecio";
            this.txtAccionPrecio.PasswordChar = '\0';
            this.txtAccionPrecio.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccionPrecio.SelectedText = "";
            this.txtAccionPrecio.SelectionLength = 0;
            this.txtAccionPrecio.SelectionStart = 0;
            this.txtAccionPrecio.ShortcutsEnabled = true;
            this.txtAccionPrecio.Size = new System.Drawing.Size(211, 23);
            this.txtAccionPrecio.TabIndex = 3;
            this.txtAccionPrecio.UseCustomBackColor = true;
            this.txtAccionPrecio.UseSelectable = true;
            this.txtAccionPrecio.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccionPrecio.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccionCantidad
            // 
            this.txtAccionCantidad.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtAccionCantidad.CustomButton.Image = null;
            this.txtAccionCantidad.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtAccionCantidad.CustomButton.Name = "";
            this.txtAccionCantidad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccionCantidad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccionCantidad.CustomButton.TabIndex = 1;
            this.txtAccionCantidad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccionCantidad.CustomButton.UseSelectable = true;
            this.txtAccionCantidad.CustomButton.Visible = false;
            this.txtAccionCantidad.Lines = new string[0];
            this.txtAccionCantidad.Location = new System.Drawing.Point(561, 197);
            this.txtAccionCantidad.MaxLength = 32767;
            this.txtAccionCantidad.Name = "txtAccionCantidad";
            this.txtAccionCantidad.PasswordChar = '\0';
            this.txtAccionCantidad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccionCantidad.SelectedText = "";
            this.txtAccionCantidad.SelectionLength = 0;
            this.txtAccionCantidad.SelectionStart = 0;
            this.txtAccionCantidad.ShortcutsEnabled = true;
            this.txtAccionCantidad.Size = new System.Drawing.Size(211, 23);
            this.txtAccionCantidad.TabIndex = 3;
            this.txtAccionCantidad.UseCustomBackColor = true;
            this.txtAccionCantidad.UseSelectable = true;
            this.txtAccionCantidad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccionCantidad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtAccionUsuario
            // 
            this.txtAccionUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption;
            // 
            // 
            // 
            this.txtAccionUsuario.CustomButton.Image = null;
            this.txtAccionUsuario.CustomButton.Location = new System.Drawing.Point(189, 1);
            this.txtAccionUsuario.CustomButton.Name = "";
            this.txtAccionUsuario.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAccionUsuario.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAccionUsuario.CustomButton.TabIndex = 1;
            this.txtAccionUsuario.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAccionUsuario.CustomButton.UseSelectable = true;
            this.txtAccionUsuario.CustomButton.Visible = false;
            this.txtAccionUsuario.Lines = new string[0];
            this.txtAccionUsuario.Location = new System.Drawing.Point(561, 237);
            this.txtAccionUsuario.MaxLength = 32767;
            this.txtAccionUsuario.Name = "txtAccionUsuario";
            this.txtAccionUsuario.PasswordChar = '\0';
            this.txtAccionUsuario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAccionUsuario.SelectedText = "";
            this.txtAccionUsuario.SelectionLength = 0;
            this.txtAccionUsuario.SelectionStart = 0;
            this.txtAccionUsuario.ShortcutsEnabled = true;
            this.txtAccionUsuario.Size = new System.Drawing.Size(211, 23);
            this.txtAccionUsuario.TabIndex = 3;
            this.txtAccionUsuario.UseCustomBackColor = true;
            this.txtAccionUsuario.UseSelectable = true;
            this.txtAccionUsuario.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAccionUsuario.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnAccionGuardar
            // 
            this.btnAccionGuardar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionGuardar.Location = new System.Drawing.Point(58, 635);
            this.btnAccionGuardar.Name = "btnAccionGuardar";
            this.btnAccionGuardar.Size = new System.Drawing.Size(91, 51);
            this.btnAccionGuardar.TabIndex = 4;
            this.btnAccionGuardar.Text = "Guardar";
            this.btnAccionGuardar.UseSelectable = true;
            this.btnAccionGuardar.Click += new System.EventHandler(this.btnAccionGuardar_Click);
            // 
            // btnAccionSalir
            // 
            this.btnAccionSalir.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionSalir.Location = new System.Drawing.Point(910, 635);
            this.btnAccionSalir.Name = "btnAccionSalir";
            this.btnAccionSalir.Size = new System.Drawing.Size(91, 51);
            this.btnAccionSalir.TabIndex = 4;
            this.btnAccionSalir.Text = "Salir";
            this.btnAccionSalir.UseSelectable = true;
            this.btnAccionSalir.Click += new System.EventHandler(this.btnAccionSalir_Click);
            // 
            // btnAccionAgregar
            // 
            this.btnAccionAgregar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionAgregar.Location = new System.Drawing.Point(872, 174);
            this.btnAccionAgregar.Name = "btnAccionAgregar";
            this.btnAccionAgregar.Size = new System.Drawing.Size(119, 31);
            this.btnAccionAgregar.TabIndex = 4;
            this.btnAccionAgregar.Text = "Agregar";
            this.btnAccionAgregar.UseSelectable = true;
            this.btnAccionAgregar.Click += new System.EventHandler(this.btnAccionAgregar_Click);
            // 
            // btnAccionEditar
            // 
            this.btnAccionEditar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionEditar.Location = new System.Drawing.Point(872, 224);
            this.btnAccionEditar.Name = "btnAccionEditar";
            this.btnAccionEditar.Size = new System.Drawing.Size(119, 31);
            this.btnAccionEditar.TabIndex = 4;
            this.btnAccionEditar.Text = "Editar";
            this.btnAccionEditar.UseSelectable = true;
            this.btnAccionEditar.Click += new System.EventHandler(this.btnAccionEditar_Click);
            // 
            // btnAccionEliminar
            // 
            this.btnAccionEliminar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionEliminar.Location = new System.Drawing.Point(872, 271);
            this.btnAccionEliminar.Name = "btnAccionEliminar";
            this.btnAccionEliminar.Size = new System.Drawing.Size(119, 31);
            this.btnAccionEliminar.TabIndex = 4;
            this.btnAccionEliminar.Text = "Eliminar";
            this.btnAccionEliminar.UseSelectable = true;
            this.btnAccionEliminar.Click += new System.EventHandler(this.btnAccionEliminar_Click);
            // 
            // btnAccionCargar
            // 
            this.btnAccionCargar.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnAccionCargar.Location = new System.Drawing.Point(479, 635);
            this.btnAccionCargar.Name = "btnAccionCargar";
            this.btnAccionCargar.Size = new System.Drawing.Size(91, 51);
            this.btnAccionCargar.TabIndex = 4;
            this.btnAccionCargar.Text = "Cargar";
            this.btnAccionCargar.UseSelectable = true;
            this.btnAccionCargar.Click += new System.EventHandler(this.btnAccionCargar_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnAccionReporte
            // 
            this.btnAccionReporte.Location = new System.Drawing.Point(893, 329);
            this.btnAccionReporte.Name = "btnAccionReporte";
            this.btnAccionReporte.Size = new System.Drawing.Size(75, 23);
            this.btnAccionReporte.TabIndex = 5;
            this.btnAccionReporte.Text = "Ver Reporte";
            this.btnAccionReporte.UseSelectable = true;
            this.btnAccionReporte.Click += new System.EventHandler(this.btnAccionReporte_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 726);
            this.Controls.Add(this.btnAccionReporte);
            this.Controls.Add(this.btnAccionEliminar);
            this.Controls.Add(this.btnAccionEditar);
            this.Controls.Add(this.btnAccionAgregar);
            this.Controls.Add(this.btnAccionSalir);
            this.Controls.Add(this.btnAccionCargar);
            this.Controls.Add(this.btnAccionGuardar);
            this.Controls.Add(this.txtAccionUsuario);
            this.Controls.Add(this.txtAccionCantidad);
            this.Controls.Add(this.txtAccionPrecio);
            this.Controls.Add(this.txtAccionProducto);
            this.Controls.Add(this.txtAccionID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroGrid dgvInventario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private MetroFramework.Controls.MetroTextBox txtAccionID;
        private MetroFramework.Controls.MetroTextBox txtAccionProducto;
        private MetroFramework.Controls.MetroTextBox txtAccionPrecio;
        private MetroFramework.Controls.MetroTextBox txtAccionCantidad;
        private MetroFramework.Controls.MetroTextBox txtAccionUsuario;
        private MetroFramework.Controls.MetroButton btnAccionGuardar;
        private MetroFramework.Controls.MetroButton btnAccionSalir;
        private MetroFramework.Controls.MetroButton btnAccionAgregar;
        private MetroFramework.Controls.MetroButton btnAccionEditar;
        private MetroFramework.Controls.MetroButton btnAccionEliminar;
        private MetroFramework.Controls.MetroButton btnAccionCargar;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton btnAccionReporte;
    }
}