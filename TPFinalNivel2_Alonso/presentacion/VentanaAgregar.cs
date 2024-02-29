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
    public partial class VentanaAgregar : Form
    {
        public VentanaAgregar()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            btnAceptar.FlatAppearance.BorderSize = 2;
            btnCancelar.FlatAppearance.BorderSize = 2;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }
    }
}
