using dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public partial class DetallesProducto : Form
    {
        private Articulo articulo;
        public DetallesProducto(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void DetallesProducto_Load(object sender, EventArgs e)
        {
            try
            {
                
                ListViewItem newItem = new ListViewItem(articulo.Descripcion);
                tituloNombre.Text = articulo.Nombre;
                txtDescripcion.Text = articulo.Descripcion;
                txtCodigoArticulo.Text = articulo.CodigoArticulo;
                txtValue.Text = "$"+articulo.Precio.ToString();
                txtCategoria.Text = articulo.Categoria.ToString();
                txtMarca.Text = articulo.Marca.ToString();
                cargarImagen(articulo.Imagen);
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void cargarImagen(string url)
        {
            try
            {
                imgArticulo.Load(url);
            }
            catch (Exception)
            {
                imgArticulo.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder-300x200.png");
            }
        }
    }
}
