using dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace negocio
{
    public class CategoriaNegocio
    {
        public List<Categoria> Listar()
        {
            AccesoDatos consulta = new AccesoDatos();
            List<Categoria> listaCategorias = new List<Categoria>();
            try
            {
                consulta.setearConsulta("SELECT Id, Descripcion FROM CATEGORIAS");
                consulta.ejecutarLectura();
                while (consulta.Lector.Read())
                {
                    Categoria aux = new Categoria();
                    aux.Id = (int)consulta.Lector["Id"];
                    aux.Descripcion = (string)consulta.Lector["Descripcion"];

                    listaCategorias.Add(aux);
                }
                return listaCategorias;
            }
            catch (Exception exc)
            {
                throw exc;
            }
            finally
            {
                consulta.cerrarConexion();
            }
        }
    }
}
