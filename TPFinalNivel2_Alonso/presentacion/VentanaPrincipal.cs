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
    public partial class VentanaMain : Form
    {
        public VentanaMain()
        {
            InitializeComponent();
        }

        private void VentanaMain_Load(object sender, EventArgs e)
        {
            achicarBorderSize();
        }

        // Eventos para el PlaceHolder ----------------------------------------------------

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "Buscar artículo")
            {
                txtBuscar.Text = "";
                txtBuscar.ForeColor = Color.Black;
            }
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            if (txtBuscar.Text == "")
            {
                txtBuscar.Text = "Buscar artículo";
                txtBuscar.ForeColor = Color.Gray;
            }
        }
        // Comportamiento botones  --------------------------------------------------------
        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
        // Estilo de botones
        private void achicarBorderSize()
        {
            btnActualizar.FlatAppearance.BorderSize = 0;
            btnAgregar.FlatAppearance.BorderSize = 0;
            btnModificar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnVerDetalles.FlatAppearance.BorderSize = 0;
            btnBusquedaAvanzada.FlatAppearance.BorderSize = 0;
        }
    }
}
