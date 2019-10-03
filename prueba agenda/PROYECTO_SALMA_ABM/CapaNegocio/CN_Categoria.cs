using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using CapaDatos;

namespace CapaNegocio
{
    public class CN_Categoria
    {
        private CD_Categoria objetoCD_Categoria = new CD_Categoria();

        public void InsertarCat(string descripcion)
        {
            objetoCD_Categoria.Insertar(descripcion);
        }

        public void EliminarCat(string id)
        {
            objetoCD_Categoria.Eliminar(Convert.ToInt32(id));
        }

        public List<string> BuscarCat()
        {
            List<string> lista = new List<string>();
            lista = objetoCD_Categoria.Buscar();
            return lista;
        }

        public void ModificarCategoria(string vieja, string nueva)
        {
            objetoCD_Categoria.Editar(vieja, nueva);
        }
    }
}
