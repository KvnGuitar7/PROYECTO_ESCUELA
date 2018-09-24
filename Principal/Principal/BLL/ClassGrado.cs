using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetPrincipalTableAdapters;

namespace Principal.BLL
{
    class ClassGrado
    {
        public GradoEscolarTableAdapter grado;
        private GradoEscolarTableAdapter Grado
        {
            get
            {
                if (grado == null)
                    grado = new GradoEscolarTableAdapter();
                return grado;
            }
        }
        public DataTable ListaGrado()
        {
            return Grado.GetDataListaGrado();
        }
        public int InsertaGrado(string id, string nombre, int anio, string emple, string seccion)
        {
            return Grado.InsertaGrado(id, nombre, anio, emple, seccion);
        }
        public int ActualizaGrado(string id, string nombre, int anio, string emple, string seccion)
        {
            return Grado.UpdateGrado(nombre, anio, emple, seccion, id);
        }
    }
}
