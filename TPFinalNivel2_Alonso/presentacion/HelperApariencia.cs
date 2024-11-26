using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    internal class HelperApariencia
    {
        public void placeholderTextBox(TextBox valor, string vacio, string cadena)
        {
            if(valor.Text == cadena)
            {
                valor.Text = "";
                valor.ForeColor = Color.Black;
            }
            else
            {
                if(valor.Text == vacio)
                {
                    valor.Text = cadena;
                    valor.ForeColor = Color.Gray;
                }
            }
        }
    }
}
