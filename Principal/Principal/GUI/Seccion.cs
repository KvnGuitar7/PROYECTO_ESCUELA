﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Principal.BLL;

namespace Principal.GUI
{
    public partial class Seccion : Form
    {
        public Seccion()
        {
            InitializeComponent();
        }
        ClassSeccion seccion = new ClassSeccion();
        private void Seccion_Load(object sender, EventArgs e)
        {
            llenar();
            btnmodificar.Enabled = false;
        }
        public void limpiar()
        {
            txtseccion.Text = "";
        }
        public void llenar()
        {
            dataGridViewseccion.DataSource = seccion.ListaSeccion();
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            try
            {
                string llave = "";
                string aux = "";
                if (aux == "")
                {
                    llave = "1";
                }
                else
                {
                    llave = (Convert.ToInt64(aux) + 1).ToString();

                }
                int bandera = seccion.InsertaSeccion(llave, txtseccion.Text, Convert.ToInt32(numericUpDownalumnos.Value));
                MessageBox.Show("Datos ingresados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenar();
                limpiar();
            }
            catch
            {
                MessageBox.Show("No se pudieron ingresar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        string id = "";
        private void dataGridViewseccion_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            id = dataGridViewseccion.CurrentRow.Cells[0].Value.ToString();
            txtseccion.Text = dataGridViewseccion.CurrentRow.Cells[1].Value.ToString();
            numericUpDownalumnos.Value = Convert.ToDecimal(dataGridViewseccion.CurrentRow.Cells[2].Value);
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = seccion.ActualizaSeccion(id, txtseccion.Text, Convert.ToInt32(numericUpDownalumnos.Value));
                MessageBox.Show("Datos modificados exitosamente", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                llenar();
                limpiar();
                btnguardar.Enabled = true;
                btnmodificar.Enabled = false;
            }
            catch
            {
                MessageBox.Show("No se pudieron modificar los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
