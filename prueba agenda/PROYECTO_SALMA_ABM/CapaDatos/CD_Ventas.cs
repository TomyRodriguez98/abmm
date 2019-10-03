using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Ventas
    {
        private CD_Conexion conexion = new CD_Conexion();

        SqlDataReader leer;
        DataTable tabla = new DataTable();
        List<string> lista = new List<string>();
        SqlCommand comando = new SqlCommand();

        public void crearVenta(string cat, string prod, string desc, int talle, int cant, string apellido)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarVenta";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@cat", cat);
            comando.Parameters.AddWithValue("@prod", prod);
            comando.Parameters.AddWithValue("@desc", desc);
            comando.Parameters.AddWithValue("@talle", talle);
            comando.Parameters.AddWithValue("@cant", cant);
            comando.Parameters.AddWithValue("@apellido", apellido);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public DataTable MostrarVentas()
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarVentas";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            tabla.Load(leer);
            conexion.CerrarConexion();
            return tabla;
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "eliminarVenta";
            comando.CommandType = CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@id", id);

            comando.ExecuteNonQuery();

            comando.Parameters.Clear();
        }
    }
}
