using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    public partial class PresentacionMantenimiento : Form
    {

        private EntidadEmpleados _objEntidad = new EntidadEmpleados();
        private NegocioEmpleados _objNegocio = new NegocioEmpleados();

        public PresentacionMantenimiento()
        {
            InitializeComponent();
        }

        private void PresentacionMantenimiento_Load(object sender, EventArgs e)
        {
            this.ListarEmpleados();
        }

        private void ListarEmpleados()
        {
            DataTable dt = _objNegocio.N_Listado();
            DataGrivViewDatos.DataSource = dt;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Insertar();
            this.ListarEmpleados();
            this.Limpiar();
        }

        private void Insertar()
        {
            this._objEntidad.Nombre = txtNombre.Text;
            this._objEntidad.Edad = Convert.ToInt32(txtEdad.Text);
            this._objEntidad.Sexo = txtSexo.Text;
            this._objEntidad.Sueldo = Convert.ToDouble(txtSueldo.Text);

            try
            {
                this._objNegocio.Insertar(_objEntidad);
                MessageBox.Show("Registro insertado con exito");

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
                 
        }


        private void Limpiar()
        {
            foreach (Control item in this.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
            }
           
        }

        private void DataGrivViewDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGrivViewDatos.Rows[e.RowIndex].Cells["Eliminar"].Selected)
            {
                int eliminar = Convert.ToInt32(DataGrivViewDatos.Rows[e.RowIndex].Cells["codEmp"].Value.ToString());
                this._objNegocio.N_Eliminar(eliminar);
                this.ListarEmpleados();
            } else if (DataGrivViewDatos.Rows[e.RowIndex].Cells["Editar"].Selected)
            {
                txtCodigp.Text = DataGrivViewDatos.Rows[e.RowIndex].Cells["codEmp"].Value.ToString();
                txtNombre.Text = DataGrivViewDatos.Rows[e.RowIndex].Cells["nomEMp"].Value.ToString();
                txtEdad.Text = DataGrivViewDatos.Rows[e.RowIndex].Cells["edadEmp"].Value.ToString();
                txtSexo.Text = DataGrivViewDatos.Rows[e.RowIndex].Cells["sexoEmp"].Value.ToString();
                txtSueldo.Text = DataGrivViewDatos.Rows[e.RowIndex].Cells["sueldoEmp"].Value.ToString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            this.P_Editar();
            this.ListarEmpleados();
            this.Limpiar();
        }

        private void P_Editar()
        {
            this._objEntidad.Id = Convert.ToInt32(txtCodigp.Text);
            this._objEntidad.Nombre = txtNombre.Text;
            this._objEntidad.Edad = Convert.ToInt32(txtEdad.Text);
            this._objEntidad.Sexo = txtSexo.Text;
            this._objEntidad.Sueldo = Convert.ToDouble(txtSueldo.Text);

            try
            {
                this._objNegocio.N_Editar(this._objEntidad);
                MessageBox.Show("Registro Editado con exito");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           
             
        }
    }
}
