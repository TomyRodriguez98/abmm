using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace CapaDatos
{
    public class CD_Categoria
    {
        private CD_Conexion conexion = new CD_Conexion();

        List<string> Categoria = new List<string>();
        SqlCommand comando = new SqlCommand();

        public void Insertar(string descripcion)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "InsertarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@descripcion", descripcion);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public void Eliminar(int id)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EliminarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@id", id);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }

        public List<string> Buscar()
        {
            SqlDataReader leer;
            List<string> lista = new List<string>();
            SqlCommand comando = new SqlCommand();
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "MostrarCategorias";
            comando.CommandType = CommandType.StoredProcedure;
            leer = comando.ExecuteReader();
            while (leer.Read())
                lista.Add(leer.GetString(0).ToString());
            conexion.CerrarConexion();
            conexion.BorrarConexion();
            return lista;
        }

        public void Editar(string vieja, string nueva)
        {
            comando.Connection = conexion.AbrirConexion();
            comando.CommandText = "EditarCategoria";
            comando.CommandType = CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@catVieja", vieja);
            comando.Parameters.AddWithValue("@catNueva", nueva);
            comando.ExecuteNonQuery();
            comando.Parameters.Clear();
        }
    }
}
