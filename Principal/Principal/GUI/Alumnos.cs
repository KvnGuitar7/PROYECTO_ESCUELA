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
    public partial class Alumnos : Form
    {
        public Alumnos()
        {
            InitializeComponent();
        }

        ClassAlumno alumno = new ClassAlumno();
        private void Alumnos_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = alumno.ListaAlumnos();
        }
    }
}
