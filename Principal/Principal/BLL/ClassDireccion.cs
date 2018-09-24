using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Principal.DAL.DataSetUbicacionTableAdapters;

namespace Principal.BLL
{
    class ClassDireccion
    {
        public DepartamentoTableAdapter departamento;
        private DepartamentoTableAdapter Departamento
        {
            get
            {
                if (departamento == null)
                    departamento = new DepartamentoTableAdapter();
                return departamento;
            }
        }
        public DataTable ListaDepartamento()
        {
            return Departamento.GetDataListaDepartamento();
        }

        public MunicipioTableAdapter municipio;
        private MunicipioTableAdapter Municipio
        {
            get
            {
                if (municipio == null)
                    municipio = new MunicipioTableAdapter();
                return municipio;
            }
        }
        public DataTable ListaMunicipio(string id)
        {
            return Municipio.GetDataListaMunicipio(id);
        }
    }
}
