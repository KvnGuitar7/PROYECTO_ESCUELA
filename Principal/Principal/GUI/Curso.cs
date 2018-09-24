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
    public partial class Curso : Form
    {
        public Curso()
        {
            InitializeComponent();
        }
        ClassCurso curso = new ClassCurso();
        private void Curso_Load(object sender, EventArgs e)
        {
            llenar();
            btnmodificar.Enabled = false;
        }
        public void limpiar()
        {
            txtcurso.Text = "";
        }
        public void llenar()
        {
            dataGridViewcurso.DataSource = curso.ListaCurso();
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
                int bandera = curso.InsertaCurso(llave, txtcurso.Text);
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
        private void dataGridViewcurso_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            id = dataGridViewcurso.CurrentRow.Cells[0].Value.ToString();
            txtcurso.Text = dataGridViewcurso.CurrentRow.Cells[1].Value.ToString();

        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = curso.ActualizaCurso(id, txtcurso.Text);
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
