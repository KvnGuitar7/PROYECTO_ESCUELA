using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetPrincipalTableAdapters;

namespace Principal.BLL
{
    class ClassEmpleado
    {
        public EmpleadoTableAdapter empleado;
        private EmpleadoTableAdapter Empleado
        {
            get
            {
                if (empleado == null)
                    empleado = new EmpleadoTableAdapter();
                return empleado;
            }
        }
        public DataTable ListaEmpleado()
        {
            return Empleado.GetDataListaEmpleado();
        }
        public int InsertaEmpleado(string id, string muni, string nombre1, string nombre2, string ape1, string ape2, string dpi, int edad, string estado, string dir, string tel, string cel)
        {
            return Empleado.InsertaEmpleado(id, muni, nombre1, nombre2, ape1, ape2, dpi, edad, estado, dir, tel, cel);
        }
        public int ActualizaEmpleado(string id, string muni, string nombre1, string nombre2, string ape1, string ape2, string dpi, int edad, string estado, string dir, string tel, string cel)
        {
            return Empleado.UpdateEmpleado(muni, nombre1, nombre2, ape1, ape2, dpi, edad, estado, dir, tel, cel, id);
        }

        public EstadoEmpleadoTableAdapter estado;
        private EstadoEmpleadoTableAdapter Estado
        {
            get
            {
                if (estado == null)
                    estado = new EstadoEmpleadoTableAdapter();
                return estado;
            }
        }
        public DataTable ListaEstado()
        {
            return Estado.GetDataListaEstado();
        }
    }
}
