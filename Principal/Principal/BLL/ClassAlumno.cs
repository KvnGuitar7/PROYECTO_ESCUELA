using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetPrincipalTableAdapters;

namespace Principal.BLL
{
    class ClassAlumno
    {
        public AlumnoTableAdapter alumnos;
        private AlumnoTableAdapter Alumnos
        {
            get
            {
                if (alumnos == null)
                    alumnos = new AlumnoTableAdapter();
                return alumnos;
            }
        }
        public DataTable ListaAlumnos()
        {
            return Alumnos.GetDataListaAlumnos();
        }
    }
}
