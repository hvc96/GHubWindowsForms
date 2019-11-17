using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
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
            Socket listen = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            System.Net.IPEndPoint connect = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8910);

            listen.Connect(connect);

            byte[] enviar_data = new byte[500];

            datos = textboxNombreJuego.Text.Trim();

            enviar_data = Encoding.Default.GetBytes(datos);
            listen.Send(enviar_data);

            //this.Hide();
        }
    }
}
