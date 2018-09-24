using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetPrincipalTableAdapters;

namespace Principal.BLL
{
    class ClassSeccion
    {
        public SeccionTableAdapter seccion;
        private SeccionTableAdapter Seccion
        {
            get
            {
                if (seccion == null)
                    seccion = new SeccionTableAdapter();
                return seccion;
            }
        }
        public DataTable ListaSeccion()
        {
            return Seccion.GetDataListaSeccion();
        }
        public int InsertaSeccion(string id, string nombre, int cantidad)
        {
            return Seccion.InsertaSeccion(id, nombre, cantidad);
        }
        public int ActualizaSeccion(string id, string nombre, int cantidad)
        {
            return Seccion.UpdateSeccion(nombre, cantidad, id);
        }
    }
}
