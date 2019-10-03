using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Cliente
    {
        private CD_Conexion conexion = new CD_Conexion();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string dni, string nombre, string apellido, string telefono, string mail, string direccion, string colegio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@mail", mail);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@colegio", colegio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public List<string> buscarApellidos()
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarClientes";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> buscarnombre(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarDatosCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public void actualizar(string dni, string nombre, string apellido, string telefono, string mail, string direccion, string colegio)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.Parameters.AddWithValue("@telefono", telefono);
            comando.Parameters.AddWithValue("@mail", mail);
            comando.Parameters.AddWithValue("@direccion", direccion);
            comando.Parameters.AddWithValue("@colegio", colegio);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public List<string> buscarApellido(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarApellido";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> buscarTelefono(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarTelefono";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> buscarMail(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscarMail";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> buscarDireccion(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscarDireccion";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> buscarColegio(string dni)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "buscarColegio";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public void Eliminar(string dni)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarCliente";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@dni", dni);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
