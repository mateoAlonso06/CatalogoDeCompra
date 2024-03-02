using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class MarcaNegocio
    {
        public List<Marca> Listar()
        {
            AccesoDatos consulta = new AccesoDatos();   
            List<Marca> listaMarcas = new List<Marca>();
			try
			{
                consulta.setearConsulta("SELECT Id, Descripcion FROM MARCAS");
                consulta.ejecutarLectura();
                while(consulta.Lector.Read())
                {
                    Marca aux = new Marca();
                    aux.Id = (int)consulta.Lector["Id"];
                    aux.Descripcion = (string)consulta.Lector["Descripcion"];

                    listaMarcas.Add(aux);
                }
                return listaMarcas;
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
