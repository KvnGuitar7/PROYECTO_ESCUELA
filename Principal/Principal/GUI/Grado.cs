using System;
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
    public partial class Grado : Form
    {
        public Grado()
        {
            InitializeComponent();
        }
        ClassGrado grado = new ClassGrado();
        ClassSeccion seccion = new ClassSeccion();
        ClassEmpleado emple = new ClassEmpleado();
        private void Grado_Load(object sender, EventArgs e)
        {
            btnmodificar.Enabled = false;
            llenar();
            listaseccion();
            listacatedratico();
        }
        public void limpiar()
        {
            txtgrado.Text = "";
        }
        public void llenar()
        {
            dataGridViewgrado.DataSource = grado.ListaGrado();
        }
        public void listaseccion()
        {
            comboBoxseccion.DataSource = seccion.ListaSeccion();
            comboBoxseccion.DisplayMember = "Seccion";
            comboBoxseccion.ValueMember = "Id_Seccion";
        }
        public void listacatedratico()
        {
            comboBoxcatedratico.DataSource = emple.ListaEmpleado();
            comboBoxcatedratico.DisplayMember = "Nombre1";
            comboBoxcatedratico.ValueMember = "Id_Empleado";
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
                int bandera = grado.InsertaGrado(llave, txtgrado.Text, Convert.ToInt32(numericUpDownaño.Value), comboBoxcatedratico.SelectedValue.ToString(), comboBoxseccion.SelectedValue.ToString());
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
        private void dataGridViewgrado_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            id = dataGridViewgrado.CurrentRow.Cells[0].Value.ToString();
            txtgrado.Text = dataGridViewgrado.CurrentRow.Cells[1].Value.ToString();
            numericUpDownaño.Value = Convert.ToDecimal(dataGridViewgrado.CurrentRow.Cells[2].Value);
            comboBoxcatedratico.SelectedValue = dataGridViewgrado.CurrentRow.Cells[3].Value.ToString();
            comboBoxseccion.SelectedValue = dataGridViewgrado.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = grado.ActualizaGrado(id, txtgrado.Text, Convert.ToInt32(numericUpDownaño.Value), comboBoxcatedratico.SelectedValue.ToString(), comboBoxseccion.SelectedValue.ToString());
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                    }
    }
}
