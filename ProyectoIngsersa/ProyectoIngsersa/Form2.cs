﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIngsersa
{
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        Form3 VerInventario = new Form3();

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Saliendo...");
            Application.Exit();
        }
        
        private void btnAcciones_Click(object sender, EventArgs e)
        {
            VerInventario.Show();
        }
    }
}