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

namespace Cliente
{
    public partial class FormCliente : MaterialSkin.Controls.MaterialForm
    {
    SimpleTcpClient cliente;
        public FormCliente()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (
                MaterialSkin.Primary.Indigo900,
                MaterialSkin.Primary.Indigo800,
                MaterialSkin.Primary.Indigo700,
                MaterialSkin.Accent.Indigo400,
                MaterialSkin.TextShade.BLACK
                );
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            cliente = new SimpleTcpClient();
            cliente.StringEncoder = Encoding.UTF8;
            cliente.Delimiter = 0x13;
            cliente.DataReceived += Cliente_DataReceived;
            cliente.Connect("127.0.0.1", 15002);

        }

        private void Cliente_DataReceived(object sender, SimpleTCP.Message e)
        {
            txtboxDataServer.Invoke((MethodInvoker)delegate ()
            {
                txtboxDataServer.Text += e.MessageString.Substring(0, e.MessageString.Length - 1) + "\r\n";
            });
        }

        private void btnConsultarServer_Click(object sender, EventArgs e)
        {
            cliente.WriteLineAndGetReply(txtboxPreguntaServer.Text.Trim(), TimeSpan.FromSeconds(2));
        }
    }
}
