using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetPrincipalTableAdapters;

namespace Principal.BLL
{
    class ClassCurso
    {
        public CursoTableAdapter curso;
        private CursoTableAdapter Curso
        {
            get
            {
                if (curso == null)
                    curso = new CursoTableAdapter();
                return curso;
            }
        }
        public DataTable ListaCurso()
        {
            return Curso.GetDataListaCurso();
        }
        public int InsertaCurso(string id, string nombre)
        {
            return Curso.InsertaCurso(id, nombre);
        }
        public int ActualizaCurso(string id, string nombre)
        {
            return Curso.UpdateCurso(nombre, id);
        }
    }
}
