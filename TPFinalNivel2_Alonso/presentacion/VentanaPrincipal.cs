using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography.X509Certificates;

namespace presentacion
{
    public partial class VentanaMain : Form
    {
        HelperApariencia helper = new HelperApariencia();
        private List<Articulo> listaArticulos;
        public VentanaMain()
        {
            InitializeComponent();
        }
        // funciones de carga de elementos
        private void VentanaMain_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cargarListasInicio();
            listaCampo.SelectedIndex = 0;
            listaCriterio.SelectedIndex = 0;
        }
        private void cargarTabla()
        {   
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.Listar();
                dgvCatalogo.DataSource = listaArticulos;
                ocultarColumnas();
                cargarImagen(listaArticulos[0].Imagen);
                extenderColumnas();
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
                imgInicio.Load(url);
            }
            catch (Exception)
            {
                imgInicio.Load("https://editorial.unc.edu.ar/wp-content/uploads/sites/33/2022/09/placeholder-300x200.png");
            }
        }
        private void cargarListasInicio()
        {
            listaCampo.Items.Add("Nombre del producto");
            listaCampo.Items.Add("Precio");
            listaCampo.Items.Add("Marca");
            listaCampo.Items.Add("Categoria");
        }
        // Evento botones y campos --------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            VentanaAgregar ventana = new VentanaAgregar();
            ventana.ShowDialog();
            cargarTabla();
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo actual;
            if (dgvCatalogo.CurrentRow != null && dgvCatalogo.SelectedRows.Count == 1)
            {
                DialogResult respuestaModificar = MessageBox.Show("¿Está seguro de que desea modificar este artículo?", "Modificandoo...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(respuestaModificar == DialogResult.Yes)
                {
                    actual = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                    VentanaAgregar ventana = new VentanaAgregar(actual);
                    ventana.ShowDialog();
                    cargarTabla();
                }
            }
            else
                MessageBox.Show("Seleccione un articulo a modificar");
        }
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            cargarTabla();
            txtBuscar.Text = "";
            helper.placeholderTextBox(txtBuscar, "", "Buscar artículo");
            cargarTabla();
            MessageBox.Show("Se han actualizado los registros");
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo actual;
            try
            {
                if(dgvCatalogo.CurrentRow != null)
                {
                    DialogResult respuesta = MessageBox.Show("¿Está seguro de que desea eliminar este artículo permanentemente?", "Eliminando...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(respuesta == DialogResult.Yes)
                    { 
                        actual = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                        negocio.eliminarArticulo(actual);
                        cargarTabla();
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un articulo a eliminar");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void btnBusquedaAvanzada_Click(object sender, EventArgs e)
        {
            if (validarCampos())
                return;

            ArticuloNegocio negocio = new ArticuloNegocio();
            string campo = listaCampo.SelectedItem.ToString();
            string criterio = listaCriterio.SelectedItem.ToString();
            string filtro = txtValorBusqueda.Text;
            try
            {
                dgvCatalogo.DataSource = negocio.filtrarBusqueda(campo, criterio, filtro);
                ocultarColumnas();
                extenderColumnas();
                //if (dgvCatalogo.CurrentRow == null)
                //    cargarTabla();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.ToString());
            }
        }
        private void listaCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = listaCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                listaCriterio.Items.Clear();
                listaCriterio.Items.Add("Menor a:");
                listaCriterio.Items.Add("Mayor a:");
                listaCriterio.Items.Add("Igual a:");
                listaCriterio.SelectedIndex = 0;
            }
            else
            {
                listaCriterio.Items.Clear();
                listaCriterio.Items.Add("Empieza con:");
                listaCriterio.Items.Add("Termina con:");
                listaCriterio.Items.Add("Contiene:");
                listaCriterio.SelectedIndex = 0;
            }
        }
        private void dgvCatalogo_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvCatalogo.CurrentRow != null)
            {
                Articulo cargar = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                cargarImagen(cargar.Imagen);
            }
        }
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text.ToLower();

            if (filtro.Length >= 1)
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro));
            else
                listaFiltrada = listaArticulos;

            dgvCatalogo.DataSource = null;
            dgvCatalogo.DataSource = listaFiltrada;
            ocultarColumnas();
            extenderColumnas();
        }
        // Eventos para el PlaceHolder ----------------------------------------------------
        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            helper.placeholderTextBox(txtBuscar, "", "Buscar artículo");
        }
        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            string filtro = txtBuscar.Text.ToLower();

            if (filtro.Length >= 1 && txtBuscar.Text != "Buscar artículo")
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToLower().Contains(filtro));
            else
            {
                listaFiltrada = listaArticulos;
                helper.placeholderTextBox(txtBuscar, "", "Buscar artículo");
            }

            dgvCatalogo.DataSource = listaFiltrada;
        }
        // Otras funciones ----------------------------------------------------
        private void ocultarColumnas()
        {
            dgvCatalogo.Columns["Id"].Visible = false;
            dgvCatalogo.Columns["Imagen"].Visible = false;
        }
        private void extenderColumnas()
        {
            foreach (DataGridViewColumn column in dgvCatalogo.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
        // Validaciones
        private bool validarCampos()
        {
            if (txtValorBusqueda.Text == "")
            {
                MessageBox.Show("Rellena todos los campos");
                return true;
            }

            if (listaCampo.Text == "Precio")
            {
                if (validarNumero(txtValorBusqueda.Text))
                {
                    MessageBox.Show("Solo puede ingresar un valor numerico");
                    return true;
                }
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

        private void txtValorBusqueda_TextChanged(object sender, EventArgs e)
        {
            if (txtValorBusqueda.Text == "")
                cargarTabla();
        }

        private void btnVerDetalles_Click(object sender, EventArgs e)
        {
            Articulo articuloEnviar;
            if(dgvCatalogo.CurrentRow != null)
            {
                articuloEnviar = (Articulo)dgvCatalogo.CurrentRow.DataBoundItem;
                DetallesProducto detallesVentana = new DetallesProducto(articuloEnviar);
                detallesVentana.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningun articulo");
            }
        }
    }
}
