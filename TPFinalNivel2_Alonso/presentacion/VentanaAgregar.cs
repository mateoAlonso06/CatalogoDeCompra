using negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using System.IO;

namespace presentacion
{
    public partial class VentanaAgregar : Form
    {
        Articulo articulo = null;

        public VentanaAgregar()
        {
            InitializeComponent();
        }
        public VentanaAgregar(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar artículo";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            traerDatos();
            if(articulo != null)
            {
                Titulo.Text = "Modificar artículo";
                cargarImagen(articulo.Imagen);
            }
        }

        // Traer elementos
        private void traerDatos()
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            try
            {
                listaMarca.DataSource = negocioMarca.Listar();
                listaCategoria.DataSource = negocioCategoria.Listar();

                listaMarca.ValueMember = "Id";
                listaMarca.DisplayMember = "Descripcion";

                listaCategoria.ValueMember = "Id";
                listaCategoria.DisplayMember = "Descripcion";
                
                if(articulo != null)
                {
                    txtNombre.Text = articulo.Nombre;
                    txtCodigoArticulo.Text = articulo.CodigoArticulo;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrl.Text = articulo.Imagen;
                    txtPrecio.Text = articulo.Precio.ToString();
                    listaCategoria.SelectedValue = articulo.Categoria.Id;
                    listaMarca.SelectedValue = articulo.Marca.Id;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        // Eventos
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                if (validarCampos())
                    return;

                if (articulo == null)
                    articulo = new Articulo();

                articulo.CodigoArticulo = txtCodigoArticulo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Imagen = txtUrl.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)listaMarca.SelectedItem;
                articulo.Categoria = (Categoria)listaCategoria.SelectedItem;

                if (articulo.Id != 0)
                {
                    negocio.actualizarRegistro(articulo);
                    MessageBox.Show("Articulo actualizado correctamente");
                }
                else
                {
                    negocio.insertarArticulo(articulo);
                    MessageBox.Show("Articulo agregado correctamente");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrl.Text);
        }
        private void cargarImagen(string url)
        {
            try
            {
                imgAgregar.Load(url);
            }
            catch (Exception)
            {
                imgAgregar.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder-300x200.png");
            }
        }
        // Validaciones
        private bool validarCampos()
        {
            if (txtNombre.Text == "" || txtCodigoArticulo.Text == "" || txtPrecio.Text == "" || txtDescripcion.Text == "" || txtUrl.Text == "")
            {
                MessageBox.Show("Rellena todos los campos");
                return true;
            }
            if(txtDescripcion.Text.Length >= 150)
            {
                MessageBox.Show("La descripcion no puede contener mas de 150 caracteres");
                return true;
            }
            if (validarNumero(txtPrecio.Text))
            {
                MessageBox.Show("El campo PRECIO solo puede contener valores numericos");
                return true;
            }
            return false;
        }
        private bool validarNumero(string valor)
        {
            foreach (var item in valor)
            {
                if (!(char.IsNumber(item) || item == '.'))
                    return true;
            }
            return false;
        }
    }
}
