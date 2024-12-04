namespace ProyectoIngsersa
{
    partial class Form2
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
            this.btnAcciones = new MetroFramework.Controls.MetroButton();
            this.btnSalir2 = new MetroFramework.Controls.MetroButton();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ProyectoIngsersa.Properties.Resources.images2;
            this.pictureBox1.Location = new System.Drawing.Point(181, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(498, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnAcciones
            // 
            this.btnAcciones.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnAcciones.Location = new System.Drawing.Point(339, 302);
            this.btnAcciones.Name = "btnAcciones";
            this.btnAcciones.Size = new System.Drawing.Size(163, 61);
            this.btnAcciones.TabIndex = 1;
            this.btnAcciones.Text = "Acciones";
            this.btnAcciones.UseSelectable = true;
            this.btnAcciones.Click += new System.EventHandler(this.btnAcciones_Click);
            // 
            // btnSalir2
            // 
            this.btnSalir2.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSalir2.Location = new System.Drawing.Point(705, 564);
            this.btnSalir2.Name = "btnSalir2";
            this.btnSalir2.Size = new System.Drawing.Size(87, 57);
            this.btnSalir2.TabIndex = 2;
            this.btnSalir2.Text = "Salir";
            this.btnSalir2.UseSelectable = true;
            this.btnSalir2.Click += new System.EventHandler(this.btnSalir2_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "Administrar Inventario";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 644);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir2);
            this.Controls.Add(this.btnAcciones);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroButton btnAcciones;
        private MetroFramework.Controls.MetroButton btnSalir2;
        private System.Windows.Forms.Label label1;
    }
}