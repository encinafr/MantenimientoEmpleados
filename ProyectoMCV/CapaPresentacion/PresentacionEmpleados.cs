using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;
using CapaEntidad;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class PresentacionEmpleados : Form
    {
        private EntidadEmpleados _objEntidad = new EntidadEmpleados();
        private NegocioEmpleados _objNegocio = new NegocioEmpleados();

        public PresentacionEmpleados()
        {
            InitializeComponent();
        }

        private void PresentacionEmpleados_Load(object sender, EventArgs e)
        {
            this.ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            DataTable dt = _objNegocio.N_Listado();
            dataGridView1.DataSource = dt;
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            PresentacionMantenimiento presentacion = new PresentacionMantenimiento();
            this.Hide();
            presentacion.Show();
        }
    }
}
