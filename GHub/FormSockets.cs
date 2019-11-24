using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHub
{
    public partial class FormSockets : MaterialSkin.Controls.MaterialForm
    {
        public string datos { get; set; }
        public string mensaje = "", ipSockets = "127.0.0.7";
        List<Socket> clientes = new List<Socket>();
        List<StreamWriter> swClientes = new List<StreamWriter>();
        private static readonly object l = new object();
        public bool flag;

        public FormSockets()
        {
            InitializeComponent();
        }

        public void iniciarServerSockets()
        {
            bool puertoValido = false;
            int p = 31416;
            FormSockets form = new FormSockets();

            while (!puertoValido)
            {
                try
                {
                    IPAddress ipaddress = IPAddress.Parse(ipSockets);
                    labelIpServer.Text = ipSockets;
                    labelPuertoServer.Text = p.ToString();

                    IPEndPoint iPEndPoint = new IPEndPoint(ipaddress, p);
                    Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    puertoValido = true;
                    socketServidor.Bind(iPEndPoint);

                    socketServidor.Listen(10);
                    textboxInfoServerSockets.Text = String.Format("Esperando usuarios...{0,60} puerto actual {1}\r\n", p, iPEndPoint);
                    while (true)
                    {
                        Socket socketCliente = socketServidor.Accept();
                        Thread hiloJugador = new Thread(form.hiloCliente);
                        hiloJugador.IsBackground = true;
                        hiloJugador.Start(socketCliente);
                    }
                }
                catch (SocketException)
                {
                    textboxInfoServerSockets.Text = String.Format("El puerto {0} es invalido", p);
                    p++;
                }
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            iniciarServerSockets();
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
        }

        private void hiloCliente(Object socket)
        {
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            textboxInfoServerSockets.Text += String.Format("Usuario conectado con la ip:{0} en el puerto:{1}", ieCliente.Address, ieCliente.Port);

            NetworkStream ns;
            StreamReader sr;
            StreamWriter sw = null;

            try
            {
                using (ns = new NetworkStream(cliente))
                using (sr = new StreamReader(ns))
                using (sw = new StreamWriter(ns))
                {
                    lock (l)
                    {
                        swClientes.Add(sw);
                        clientes.Add(cliente);
                    }
                    sw.WriteLine("Bienvenido, que juego desea consultar");
                    sw.WriteLine("Comandos disponibles: help, juego, exit");
                    sw.Flush();
                    while (true)
                    {
                        mensaje = sr.ReadLine();
                        if (mensaje.ToLower() == "exit")
                        {
                            sw.Close();
                            sr.Close();
                            ns.Close();
                        }
                        else if (mensaje.ToLower().Contains("juego="))
                        {
                            string[] array;
                            array = mensaje.Trim().Split('=');
                            textboxInfoServerSockets.Text = String.Format("Usuario conectado con la ip:{0} en el puerto:{1} ha consultado si existe el juego {2}", ieCliente.Address, ieCliente.Port, array[1]);
                            if (flag)
                            {
                                sw.WriteLine("Tiene ese juego");
                            }
                            else
                            {
                                sw.WriteLine("No tiene ese juego");                              
                            }
                            sw.Flush();
                        }
                        else if (mensaje.ToLower().Contains("help"))
                        {
                            sw.WriteLine("help  : Muestra el listado de comandos disponibles");
                            sw.WriteLine("juego : La consulta tiene que tener la estructura: juego=X");
                            sw.WriteLine("exit  : Corta la conexión con el servidor");
                            sw.Flush();
                        }
                        else
                        {
                            sw.WriteLine("Comando erróneo");
                            sw.Flush();
                        }
                    }
                }
            }
            catch (IOException)
            {
                Console.WriteLine("IOEX");
                swClientes.Remove(sw);
                clientes.Remove(cliente);
                cliente.Close();
            }
            catch (ObjectDisposedException)
            {
                Console.WriteLine("OBJEX");
                swClientes.Remove(sw);
                clientes.Remove(cliente);
                cliente.Close();
            }
        }
    }
}
