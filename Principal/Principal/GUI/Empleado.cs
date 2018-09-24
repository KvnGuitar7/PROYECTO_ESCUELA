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
    public partial class Empleado : Form
    {
        public Empleado()
        {
            InitializeComponent();
        }
        ClassEmpleado empleado = new ClassEmpleado();
        ClassDireccion direccion = new ClassDireccion();
        private void Empleado_Load(object sender, EventArgs e)
        {
            llenar();
            listadepartamento();
            listaestado();
            btnmodificar.Enabled = false;
        }
        public void limpiar()
        {
            txtapellido1.Text = "";
            txtapellido2.Text = "";
            txtcelular.Text = "";
            txtdir.Text = "";
            txtdpi.Text = "";
            txtnombre1.Text = "";
            txtnombre2.Text = "";
            txttelefono.Text = "";
        }
        public void llenar()
        {
            dataGridViewempleado.DataSource = empleado.ListaEmpleado();
        }
        public void listadepartamento()
        {
            comboBoxdepa.DataSource = direccion.ListaDepartamento();
            comboBoxdepa.DisplayMember = "Departamento";
            comboBoxdepa.ValueMember = "Id_Departamento";
        }
        public void listaestado()
        {
            comboBoxestado.DataSource = empleado.ListaEstado();
            comboBoxestado.DisplayMember = "Estado";
            comboBoxestado.ValueMember = "Id_Estado";
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
                int bandera = empleado.InsertaEmpleado(llave, comboBoxmuni.SelectedValue.ToString(), txtnombre1.Text, txtnombre2.Text, txtapellido1.Text, txtapellido2.Text, txtdpi.Text, Convert.ToInt32(numericUpDownedad.Value), comboBoxestado.SelectedValue.ToString(), txtdir.Text, txttelefono.Text, txtcelular.Text);
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
        private void dataGridViewempleado_DoubleClick(object sender, EventArgs e)
        {
            btnmodificar.Enabled = true;
            btnguardar.Enabled = false;
            id = dataGridViewempleado.CurrentRow.Cells[0].Value.ToString();
            comboBoxmuni.SelectedValue = dataGridViewempleado.CurrentRow.Cells[1].Value.ToString();
            txtnombre1.Text = dataGridViewempleado.CurrentRow.Cells[2].Value.ToString();
            txtnombre2.Text = dataGridViewempleado.CurrentRow.Cells[3].Value.ToString();
            txtapellido1.Text = dataGridViewempleado.CurrentRow.Cells[4].Value.ToString();
            txtapellido2.Text = dataGridViewempleado.CurrentRow.Cells[5].Value.ToString();
            txtdpi.Text = dataGridViewempleado.CurrentRow.Cells[6].Value.ToString();
            numericUpDownedad.Value = Convert.ToDecimal(dataGridViewempleado.CurrentRow.Cells[7].Value);
            comboBoxestado.SelectedValue = dataGridViewempleado.CurrentRow.Cells[8].Value.ToString();
            txtdir.Text = dataGridViewempleado.CurrentRow.Cells[9].Value.ToString();
            txttelefono.Text = dataGridViewempleado.CurrentRow.Cells[10].Value.ToString();
            txtcelular.Text = dataGridViewempleado.CurrentRow.Cells[11].Value.ToString();
        }

        private void btnmodificar_Click(object sender, EventArgs e)
        {
            try
            {
                int bandera = empleado.ActualizaEmpleado(id, comboBoxmuni.SelectedValue.ToString(), txtnombre1.Text, txtnombre2.Text, txtapellido1.Text, txtapellido2.Text, txtdpi.Text, Convert.ToInt32(numericUpDownedad.Value), comboBoxestado.SelectedValue.ToString(), txtdir.Text, txttelefono.Text, txtcelular.Text);
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

        private void comboBoxdepa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                comboBoxmuni.DataSource = direccion.ListaMunicipio(comboBoxdepa.SelectedValue.ToString());
                comboBoxmuni.DisplayMember = "Municipio";
                comboBoxmuni.ValueMember = "Id_Municipio";
            }
            catch
            {
 
            }
        }
    }
}
