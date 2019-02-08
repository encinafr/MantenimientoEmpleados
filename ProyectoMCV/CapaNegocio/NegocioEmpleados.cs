using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
using CapaEntidad;

namespace CapaNegocio
{
    public class NegocioEmpleados
    {
        DatosEmpleados objEmpleados = new DatosEmpleados();

        public DataTable N_Listado()
        {
            return this.objEmpleados.ListaDatos();
        }

        public void Insertar(EntidadEmpleados emp)
        {
            this.objEmpleados.InsertarDatos(emp);
        }

        public void N_Eliminar(int cod)
        {
            this.objEmpleados.Eliminar(cod);
        }

        public void N_Editar(EntidadEmpleados emp)
        {
            this.objEmpleados.Editar(emp);
        }
    }
}
