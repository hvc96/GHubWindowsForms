using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHub
{
    public partial class FormBusqueda : MaterialSkin.Controls.MaterialForm
    {
        public string datos { get; set; }
        public FormBusqueda()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            datos = txtboxBuscar.Text.Trim();
            this.Hide();
        }    
    }
}
