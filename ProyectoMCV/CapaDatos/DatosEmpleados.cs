using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaEntidad;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class DatosEmpleados
    {
        SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["CapaPresentacion.Properties.Settings.Conexion"].ConnectionString);

        public DataTable ListaDatos()
        {
            SqlCommand cmd = new SqlCommand("sp_listar", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sqlDataAdapter.Fill(dt);
            return dt;
        }

        public void InsertarDatos(EntidadEmpleados emp)
        {
            SqlCommand cmd = new SqlCommand("sp_insertar", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
           // cmd.Parameters.AddWithValue("@cod", emp.Id);
            cmd.Parameters.AddWithValue("@nom", emp.Nombre);
            cmd.Parameters.AddWithValue("@edad", emp.Edad);
            cmd.Parameters.AddWithValue("@sexo", emp.Sexo);
            cmd.Parameters.AddWithValue("@sueldo", emp.Sueldo);
           if(sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }

        public void Eliminar(int cod)
        {
            SqlCommand cmd = new SqlCommand("sp_eliminar", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@cod", cod);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public void Editar(EntidadEmpleados emp)
        {
            SqlCommand cmd = new SqlCommand("sp_editar", sqlConnection);
            cmd.CommandType = CommandType.StoredProcedure;
             cmd.Parameters.AddWithValue("@cod", emp.Id);
            cmd.Parameters.AddWithValue("@nom", emp.Nombre);
            cmd.Parameters.AddWithValue("@edad", emp.Edad);
            cmd.Parameters.AddWithValue("@sexo", emp.Sexo);
            cmd.Parameters.AddWithValue("@sueldo", emp.Sueldo);
            if (sqlConnection.State == ConnectionState.Open)
            {
                sqlConnection.Close();
            }
            sqlConnection.Open();
            cmd.ExecuteNonQuery();
            sqlConnection.Close();

        }
    }
}
