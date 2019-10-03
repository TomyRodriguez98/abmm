using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Productos
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        List<string> lista = new List<string>();
        SqlCommand comando = new SqlCommand();

        public DataTable Mostrar()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Insertar(int talle, string nombre, string desc, double precio, double costo, int stock, string categoria)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarProd";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@talle", talle);
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Editar(int talle, string nombre, string desc, double precio, double costo, int stock, string categoria, int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@nombre", nombre);
            comando.Parameters.AddWithValue("@descrip", desc);
            comando.Parameters.AddWithValue("@talle", talle);
            comando.Parameters.AddWithValue("@precio", precio);
            comando.Parameters.AddWithValue("@costo", costo);
            comando.Parameters.AddWithValue("@stock", stock);
            comando.Parameters.AddWithValue("@id", id);
            comando.Parameters.AddWithValue("@categoria", categoria);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarProducto";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@idpro", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }

        public List<string> Buscar(string cat)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarProductos";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cat", cat);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;

        }

        public List<string> BuscarDesc(string nombre, string cat)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarDescripciones";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cat", cat);
            comando.Parameters.AddWithValue("@prod", nombre);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public List<string> Buscartalles(string nombre, string cat, string desc)
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarTalles";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cat", cat);
            comando.Parameters.AddWithValue("@prod", nombre);
            comando.Parameters.AddWithValue("@desc", desc);
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetInt32(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public int BuscarStock(string nombre, string cat, string desc, int talle)
        {
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "BuscarStock";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cat", cat);
            comando.Parameters.AddWithValue("@prod", nombre);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.Parameters.AddWithValue("@talle", talle);
            return Convert.ToInt32(comando.ExecuteScalar());
        }
    }
}
