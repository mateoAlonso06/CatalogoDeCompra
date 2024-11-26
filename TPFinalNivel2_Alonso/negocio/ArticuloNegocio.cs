using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> Listar()
		{
			AccesoDatos consulta = new AccesoDatos();
			List<Articulo> listaDeArticulos = new List<Articulo>();
			try
			{
				consulta.setearConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion AS InfoArticulo, M.Descripcion AS InfoMarca, C.Descripcion AS InfoCategoria, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCat FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id;");
				consulta.ejecutarLectura();
				while (consulta.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = (int)consulta.Lector["Id"];
					aux.CodigoArticulo = (string)consulta.Lector["Codigo"];
					aux.Nombre = (string)consulta.Lector["Nombre"];
					aux.Descripcion = (string)consulta.Lector["InfoArticulo"];
					aux.Marca = new Marca();
					aux.Marca.Id = (int)consulta.Lector["IdMarca"];
					aux.Marca.Descripcion = (string)consulta.Lector["InfoMarca"];
					aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)consulta.Lector["IdCat"];
                    aux.Categoria.Descripcion = (string)consulta.Lector["InfoCategoria"];

					if (!(consulta.Lector["ImagenUrl"] is DBNull))
					{
						aux.Imagen = (string)consulta.Lector["ImagenUrl"];
					}
					aux.Precio = (decimal)consulta.Lector["Precio"];

					listaDeArticulos.Add(aux);
				}
				return listaDeArticulos;
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
        public void insertarArticulo(Articulo articulo)
        {
			AccesoDatos consulta = new AccesoDatos();
			try
			{
				consulta.setearConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES (@Codigo, @Nombre, @Descripcion, @IdMarca, @IdCategoria, @Url, @Precio);");
				consulta.setearParametros("@Codigo", articulo.CodigoArticulo);
				consulta.setearParametros("@Nombre", articulo.Nombre);
				consulta.setearParametros("@Descripcion", articulo.Descripcion);
				consulta.setearParametros("@IdMarca", articulo.Marca.Id);
				consulta.setearParametros("@IdCategoria", articulo.Categoria.Id);
				consulta.setearParametros("@Url", articulo.Imagen);
				consulta.setearParametros("@Precio", articulo.Precio);
				consulta.ejecutarAccion();
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

        public void actualizarRegistro(Articulo articulo)
        {
			AccesoDatos consulta = new AccesoDatos();
			try
			{
				consulta.setearConsulta("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Url, Precio = @Precio WHERE Id = @Id;");
                consulta.setearParametros("@Codigo", articulo.CodigoArticulo);
                consulta.setearParametros("@Nombre", articulo.Nombre);
                consulta.setearParametros("@Descripcion", articulo.Descripcion);
                consulta.setearParametros("@IdMarca", articulo.Marca.Id);
                consulta.setearParametros("@IdCategoria", articulo.Categoria.Id);
                consulta.setearParametros("@Url", articulo.Imagen);
                consulta.setearParametros("@Precio", articulo.Precio);
				consulta.setearParametros("@Id", articulo.Id);
                consulta.ejecutarAccion();
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

        public void eliminarArticulo(Articulo actual)
        {
			AccesoDatos consulta = new AccesoDatos();	
			try
			{
				consulta.setearConsulta("DELETE FROM ARTICULOS WHERE Id = @Id;");
				consulta.setearParametros("@Id", actual.Id);
				consulta.ejecutarAccion();
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

        public List<Articulo> filtrarBusqueda(string campo, string criterio, string filtro)
        {
            AccesoDatos consulta = new AccesoDatos();
            List<Articulo> listaFiltrada = new List<Articulo>();
            string consultaFinal = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion AS InfoArticulo, M.Descripcion AS InfoMarca, C.Descripcion AS InfoCategoria, A.ImagenUrl, A.Precio, M.Id AS IdMarca, C.Id AS IdCat FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdMarca = M.Id AND A.IdCategoria = C.Id AND ";
            try
            {
                switch (campo)
                {
                    case "Precio":
                        switch (criterio)
                        {
                            case "Menor a:": consultaFinal += "Precio < " + filtro; break;
                            case "Mayor a:": consultaFinal += "Precio > " + filtro; break;
                            default:
                                consultaFinal += "Precio = " + filtro; break;
                        }; break;
                    case "Marca":
                        switch (criterio)
                        {
                            case "Empieza con:": consultaFinal += "M.Descripcion LIKE '" + filtro + "%'"; break;
                            case "Termina con:": consultaFinal += "M.Descripcion LIKE '%" + filtro + "'"; break;
                            default:
                                consultaFinal += "M.Descripcion LIKE '%" + filtro + "%'"; break;
                        }; break;
                    case "Nombre del producto":
                        switch (criterio)
                        {
                            case "Empieza con:": consultaFinal += "A.Nombre LIKE '" + filtro + "%'"; break;
                            case "Termina con:": consultaFinal += "A.Nombre LIKE '%" + filtro + "'"; break;
                            default:
                                consultaFinal += "A.Nombre LIKE '%" + filtro + "%'"; break;
                        }; break;
                    default:
                        switch (criterio)
                        {
                            case "Empieza con:": consultaFinal += "C.Descripcion LIKE '" + filtro + "%'"; break;
                            case "Termina con:": consultaFinal += "C.Descripcion LIKE '%" + filtro + "'"; break;
                            default:
                                consultaFinal += "C.Descripcion LIKE '%" + filtro + "%'"; break;
                        }; break;
                }
                consulta.setearConsulta(consultaFinal);
                consulta.ejecutarLectura();
                while (consulta.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)consulta.Lector["Id"];
                    aux.CodigoArticulo = (string)consulta.Lector["Codigo"];
                    aux.Nombre = (string)consulta.Lector["Nombre"];
                    aux.Descripcion = (string)consulta.Lector["InfoArticulo"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)consulta.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)consulta.Lector["InfoMarca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)consulta.Lector["IdCat"];
                    aux.Categoria.Descripcion = (string)consulta.Lector["InfoCategoria"];

                    if (!(consulta.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.Imagen = (string)consulta.Lector["ImagenUrl"];
                    }
                    aux.Precio = (decimal)consulta.Lector["Precio"];

                    listaFiltrada.Add(aux);
                }
                return listaFiltrada;
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