namespace inicio_de_sesion
{
    partial class Form4
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvInventario = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Productos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblInventariodeProductos = new System.Windows.Forms.Label();
            this.lblAccionProducto = new System.Windows.Forms.Label();
            this.lblAccionID = new System.Windows.Forms.Label();
            this.txtAccionID = new System.Windows.Forms.TextBox();
            this.txtAccionProducto = new System.Windows.Forms.TextBox();
            this.lblAccionPrecio = new System.Windows.Forms.Label();
            this.txtAccionPrecio = new System.Windows.Forms.TextBox();
            this.lblAccionCantidad = new System.Windows.Forms.Label();
            this.lblAccionUsuario = new System.Windows.Forms.Label();
            this.txtAccionCantidad = new System.Windows.Forms.TextBox();
            this.txtAccionUsuario = new System.Windows.Forms.TextBox();
            this.btnAccionModificar = new System.Windows.Forms.Button();
            this.btnAccionEliminar = new System.Windows.Forms.Button();
            this.btnAccionSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::inicio_de_sesion.Properties.Resources.descargar1;
            this.pictureBox1.Location = new System.Drawing.Point(165, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(497, 95);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dgvInventario
            // 
            this.dgvInventario.AllowUserToAddRows = false;
            this.dgvInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Productos,
            this.Precio,
            this.Cantidad,
            this.Usuario});
            this.dgvInventario.Location = new System.Drawing.Point(132, 359);
            this.dgvInventario.Name = "dgvInventario";
            this.dgvInventario.ReadOnly = true;
            this.dgvInventario.Size = new System.Drawing.Size(545, 215);
            this.dgvInventario.TabIndex = 2;
            this.dgvInventario.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvInventario_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // Productos
            // 
            this.Productos.HeaderText = "Productos";
            this.Productos.Name = "Productos";
            this.Productos.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Usuario
            // 
            this.Usuario.HeaderText = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.ReadOnly = true;
            // 
            // lblInventariodeProductos
            // 
            this.lblInventariodeProductos.AutoSize = true;
            this.lblInventariodeProductos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInventariodeProductos.Location = new System.Drawing.Point(302, 124);
            this.lblInventariodeProductos.Name = "lblInventariodeProductos";
            this.lblInventariodeProductos.Size = new System.Drawing.Size(208, 24);
            this.lblInventariodeProductos.TabIndex = 3;
            this.lblInventariodeProductos.Text = "Inventario de Productos";
            // 
            // lblAccionProducto
            // 
            this.lblAccionProducto.AutoSize = true;
            this.lblAccionProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionProducto.Location = new System.Drawing.Point(129, 220);
            this.lblAccionProducto.Name = "lblAccionProducto";
            this.lblAccionProducto.Size = new System.Drawing.Size(73, 18);
            this.lblAccionProducto.TabIndex = 4;
            this.lblAccionProducto.Text = "Producto:";
            // 
            // lblAccionID
            // 
            this.lblAccionID.AutoSize = true;
            this.lblAccionID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionID.Location = new System.Drawing.Point(129, 182);
            this.lblAccionID.Name = "lblAccionID";
            this.lblAccionID.Size = new System.Drawing.Size(26, 18);
            this.lblAccionID.TabIndex = 4;
            this.lblAccionID.Text = "ID:";
            // 
            // txtAccionID
            // 
            this.txtAccionID.Location = new System.Drawing.Point(165, 182);
            this.txtAccionID.Name = "txtAccionID";
            this.txtAccionID.Size = new System.Drawing.Size(100, 20);
            this.txtAccionID.TabIndex = 5;
            // 
            // txtAccionProducto
            // 
            this.txtAccionProducto.Location = new System.Drawing.Point(209, 217);
            this.txtAccionProducto.Name = "txtAccionProducto";
            this.txtAccionProducto.Size = new System.Drawing.Size(100, 20);
            this.txtAccionProducto.TabIndex = 6;
            // 
            // lblAccionPrecio
            // 
            this.lblAccionPrecio.AutoSize = true;
            this.lblAccionPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionPrecio.Location = new System.Drawing.Point(129, 260);
            this.lblAccionPrecio.Name = "lblAccionPrecio";
            this.lblAccionPrecio.Size = new System.Drawing.Size(55, 18);
            this.lblAccionPrecio.TabIndex = 4;
            this.lblAccionPrecio.Text = "Precio:";
            // 
            // txtAccionPrecio
            // 
            this.txtAccionPrecio.Location = new System.Drawing.Point(190, 258);
            this.txtAccionPrecio.Name = "txtAccionPrecio";
            this.txtAccionPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtAccionPrecio.TabIndex = 6;
            // 
            // lblAccionCantidad
            // 
            this.lblAccionCantidad.AutoSize = true;
            this.lblAccionCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionCantidad.Location = new System.Drawing.Point(382, 181);
            this.lblAccionCantidad.Name = "lblAccionCantidad";
            this.lblAccionCantidad.Size = new System.Drawing.Size(70, 18);
            this.lblAccionCantidad.TabIndex = 4;
            this.lblAccionCantidad.Text = "Cantidad:";
            this.lblAccionCantidad.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblAccionUsuario
            // 
            this.lblAccionUsuario.AutoSize = true;
            this.lblAccionUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccionUsuario.Location = new System.Drawing.Point(382, 216);
            this.lblAccionUsuario.Name = "lblAccionUsuario";
            this.lblAccionUsuario.Size = new System.Drawing.Size(64, 18);
            this.lblAccionUsuario.TabIndex = 4;
            this.lblAccionUsuario.Text = "Usuario:";
            // 
            // txtAccionCantidad
            // 
            this.txtAccionCantidad.Location = new System.Drawing.Point(458, 183);
            this.txtAccionCantidad.Name = "txtAccionCantidad";
            this.txtAccionCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtAccionCantidad.TabIndex = 6;
            // 
            // txtAccionUsuario
            // 
            this.txtAccionUsuario.Location = new System.Drawing.Point(458, 217);
            this.txtAccionUsuario.Name = "txtAccionUsuario";
            this.txtAccionUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtAccionUsuario.TabIndex = 6;
            // 
            // btnAccionModificar
            // 
            this.btnAccionModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionModificar.Location = new System.Drawing.Point(681, 157);
            this.btnAccionModificar.Name = "btnAccionModificar";
            this.btnAccionModificar.Size = new System.Drawing.Size(106, 32);
            this.btnAccionModificar.TabIndex = 7;
            this.btnAccionModificar.Text = "Modificar";
            this.btnAccionModificar.UseVisualStyleBackColor = true;
            // 
            // btnAccionEliminar
            // 
            this.btnAccionEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionEliminar.Location = new System.Drawing.Point(681, 220);
            this.btnAccionEliminar.Name = "btnAccionEliminar";
            this.btnAccionEliminar.Size = new System.Drawing.Size(106, 33);
            this.btnAccionEliminar.TabIndex = 7;
            this.btnAccionEliminar.Text = "Eliminar";
            this.btnAccionEliminar.UseVisualStyleBackColor = true;
            // 
            // btnAccionSalir
            // 
            this.btnAccionSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccionSalir.Location = new System.Drawing.Point(725, 622);
            this.btnAccionSalir.Name = "btnAccionSalir";
            this.btnAccionSalir.Size = new System.Drawing.Size(106, 26);
            this.btnAccionSalir.TabIndex = 7;
            this.btnAccionSalir.Text = "Salir";
            this.btnAccionSalir.UseVisualStyleBackColor = true;
            this.btnAccionSalir.Click += new System.EventHandler(this.btnAccionSalir_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(856, 671);
            this.Controls.Add(this.btnAccionSalir);
            this.Controls.Add(this.btnAccionEliminar);
            this.Controls.Add(this.btnAccionModificar);
            this.Controls.Add(this.txtAccionUsuario);
            this.Controls.Add(this.txtAccionCantidad);
            this.Controls.Add(this.txtAccionPrecio);
            this.Controls.Add(this.txtAccionProducto);
            this.Controls.Add(this.txtAccionID);
            this.Controls.Add(this.lblAccionID);
            this.Controls.Add(this.lblAccionUsuario);
            this.Controls.Add(this.lblAccionCantidad);
            this.Controls.Add(this.lblAccionPrecio);
            this.Controls.Add(this.lblAccionProducto);
            this.Controls.Add(this.lblInventariodeProductos);
            this.Controls.Add(this.dgvInventario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form4";
            this.Text = "Mostrar Inventario";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dgvInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Productos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Usuario;
        private System.Windows.Forms.Label lblInventariodeProductos;
        private System.Windows.Forms.Label lblAccionProducto;
        private System.Windows.Forms.Label lblAccionID;
        private System.Windows.Forms.TextBox txtAccionID;
        private System.Windows.Forms.TextBox txtAccionProducto;
        private System.Windows.Forms.Label lblAccionPrecio;
        private System.Windows.Forms.TextBox txtAccionPrecio;
        private System.Windows.Forms.Label lblAccionCantidad;
        private System.Windows.Forms.Label lblAccionUsuario;
        private System.Windows.Forms.TextBox txtAccionCantidad;
        private System.Windows.Forms.TextBox txtAccionUsuario;
        private System.Windows.Forms.Button btnAccionModificar;
        private System.Windows.Forms.Button btnAccionEliminar;
        private System.Windows.Forms.Button btnAccionSalir;
    }
}