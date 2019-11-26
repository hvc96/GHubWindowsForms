using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GHub
{
    public partial class FormSockets : MaterialSkin.Controls.MaterialForm
    {
        public string mensaje = "", ipSockets = "127.0.0.7", consultaJuegoSocket;
        List<Socket> clientes = new List<Socket>();
        List<StreamWriter> swClientes = new List<StreamWriter>();
        private static readonly object l = new object();
        public bool flag, server;
        public int p = 10000;
        public DataGridView data;

        public delegate void AddTextToTextBox(String texto);
        public AddTextToTextBox delegado1;

        public delegate void ChangePuerto(String texto);
        public ChangePuerto delegado2;


        public FormSockets(DataGridView datosUsuario)
        {
            InitializeComponent();
            data = datosUsuario;
        }

        public void setTextInTextbox(String texto)
        {
            if (textboxInfoServerSockets.InvokeRequired)
            {
                AddTextToTextBox d = new AddTextToTextBox(setTextInTextbox);
                this.Invoke(d, new object[] { texto });
            }
            else
            {
                this.textboxInfoServerSockets.Text += texto;
            }
        }

        public void setPuerto(String texto)
        {
            if (labelPuertoServer.InvokeRequired)
            {
                ChangePuerto d = new ChangePuerto(setPuerto);
                this.Invoke(d, new object[] { texto });
            }
            else
            {
                this.labelPuertoServer.Text = texto;
            }
        }

        public void iniciarServerSockets()
        {
            bool puertoValido = false;
            
            FormSockets form = new FormSockets(data);
            while (!puertoValido)
            {
                try
                {
                    IPAddress ipaddress = IPAddress.Parse(ipSockets);
                    IPEndPoint iPEndPoint = new IPEndPoint(ipaddress, p);
                    Socket socketServidor = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    puertoValido = true;
                    socketServidor.Bind(iPEndPoint);
                    
                    setPuerto(p.ToString());

                    socketServidor.Listen(10);
                    setTextInTextbox(String.Format("Esperando usuarios...   {0}\r\n", iPEndPoint));
                    
                    while (server)
                    {
                        Socket socketCliente = socketServidor.Accept();
                        Thread hiloJugador = new Thread(form.hiloCliente);
                        hiloJugador.IsBackground = true;
                        hiloJugador.Start(socketCliente);
                    }
                }
                catch (SocketException)
                {                    
                    setTextInTextbox(String.Format("El puerto {0} es invalido\r\n", p));                    
                    p++;
                }
            }
        }

        private void btnStartServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = false;
            btnStopServer.Enabled = true;
            server = true;
            Task.Factory.StartNew(iniciarServerSockets, TaskCreationOptions.LongRunning);

        }

        private void btnCopiarIp_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(labelIpServer.Text.Trim());
        }

        private void FormSockets_Load(object sender, EventArgs e)
        {
            //No usar, ignora toda excepcion de hilos etc
            //CheckForIllegalCrossThreadCalls = false;  
        }

        private void btnStopServer_Click(object sender, EventArgs e)
        {
            btnStartServer.Enabled = true;
            btnStopServer.Enabled = false;
            server = false;
            textboxInfoServerSockets.Text = "";
        }

        public bool juegoSocket(string consulta)
        {
            bool juego = false;
            foreach (DataGridViewRow row in data.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (row.Cells[2].Value.ToString().Trim().ToLower().Contains(consulta))
                    {
                        juego = true;
                    }
                }
            }
            return juego;
        }

        private void hiloCliente(Object socket)
        {

            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            setTextInTextbox(String.Format("Usuario conectado con la ip:{0} en el puerto:{1}\r\n", ieCliente.Address, ieCliente.Port));
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
                    sw.WriteLine("");
                    sw.WriteLine("Presione enter para continuar");

                    sw.Flush();
                    while (true)
                    {
                        sw.Write("->");
                        sw.Flush();
                        
                        mensaje = sr.ReadLine();
                        if (mensaje != null && mensaje!="")
                        {                           
                            if (mensaje.ToLower().Contains("juego="))
                            {
                                string[] array;
                                array = mensaje.Trim().Split('=');                                
                                consultaJuegoSocket = array[1].Trim().ToLower();
                                setTextInTextbox(String.Format("Usuario conectado con la ip:{0} en el puerto:{1} ha consultado si existe el juego {2}\r\n", ieCliente.Address, ieCliente.Port, array[1]));
                                if (juegoSocket(consultaJuegoSocket))
                                {
                                    sw.WriteLine("Tiene el juego \"{0}\"", array[1]);
                                }
                                else
                                {
                                    sw.WriteLine("No tiene el juego \"{0}\"", array[1]);
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
                            //TEST
                            //else if (mensaje.ToLower().Contains("off"))
                            //{
                            //    server = false;
                            //    textboxInfoServerSockets.Text = "Apagar servidor";
                            //    sw.Close();
                            //    sr.Close();
                            //    ns.Close();
                            //    cliente.Shutdown(SocketShutdown.Both);
                            //    cliente.Close();
                            //}
                            else if (mensaje.ToLower().Contains("exit"))
                            {
                                sw.Close();
                                sr.Close();
                                ns.Close();
                            }
                            else
                            {
                                sw.WriteLine("Comando erróneo");
                                sw.Flush();
                            }
                        }
                        else
                        {
                            setTextInTextbox(String.Format("El usuario de ip:{0}, puerto:{1} se ha desconectado\r\n", ieCliente.Address, ieCliente.Port));
                            sw.Close();
                            sr.Close();
                            ns.Close();
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
                server = false;
            }
        }
    }
}
