using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Resources;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Web;
using System.Net;
using System.IO;
using Json.Net;
using System.Data.SqlClient;
using System.Configuration;
using System.Net.Sockets;
using SimpleTCP;
using System.Threading;

namespace GHub
{
    public partial class FormDatos : MaterialSkin.Controls.MaterialForm
    {
        String mensaje = "";
        List<Socket> clientes = new List<Socket>();
        List<StreamWriter> swClientes = new List<StreamWriter>();
        private static readonly object l = new object();
        public string steam_key, steam_id, url, nombrejuego, ip = "127.0.0.1", ipSockets = "127.0.0.7", user_string;
        public int user_id, totalJuegos, puerto = 15002, cant;
        public List<Game> juegosFav;
        public bool borrado, flag;


        SimpleTcpServer server;

        private async void FormDatos_Load(object sender, EventArgs e)
        {
            try
            {
                string respuesta = await getHttp();
                var source = new BindingSource();
                RootObject rootDatos = JsonConvert.DeserializeObject<RootObject>(respuesta);
                Response response = rootDatos.response;

                List<Game> games = response.games;
                source.DataSource = games;
                totalJuegos = response.game_count;
                labelTotalJuegos.Text = response.game_count.ToString();

                dataGridViewPrincipal.DataSource = source;             

            }
            catch (System.Net.WebException)
            {
                MessageBox.Show("No ha introducido credenciales válidos (SteamID y SteamKey). \r\nA continuación se borrará este usuario. Asegúrese de introducirlos correctamente cuando lo cree de nuevo.", "Error, usuario no válido");
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        using (SqlCommand command = new SqlCommand("DELETE FROM t_usuarios WHERE id=" + user_id, conexion))
                        {
                            command.ExecuteNonQuery();
                        }
                        conexion.Close();
                        this.Close();
                    }
                }
                catch (SystemException ex)
                {
                    MessageBox.Show(string.Format("Ha ocurrido un error ejecutando la consulta de borrado: {0}", ex.Message));
                    this.Close();
                }
            }
        }

        private void dataGridViewPrincipal_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1 && dataGridViewPrincipal.Rows[e.RowIndex].Cells[0].IsInEditMode)
            {
                dataGridViewPrincipal.EndEdit();
            }
        }
        private void dataGridViewPrincipal_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewPrincipal.ClearSelection();
            for (int i = 0; i < dataGridViewPrincipal.Columns.Count; ++i)
            {
                dataGridViewPrincipal.Rows[e.RowIndex].Cells[i].Selected = true;
            }
        }


        private void dataGridViewPrincipal_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridViewPrincipal.ClearSelection();
            for (int i = 0; i < dataGridViewPrincipal.Rows.Count; ++i)
            {
                dataGridViewPrincipal.Rows[i].Cells[e.ColumnIndex].Selected = true;
            }
        }

        private void picGuardar_Click(object sender, EventArgs e)
        {
            juegosFav = new List<Game>();
            juegosFav.Clear();

            if (dataGridViewPrincipal.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < dataGridViewPrincipal.Rows.Count - 1; i++)
                {
                    if (dataGridViewPrincipal.Rows[i].Cells[0].Value != null && dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString() == "False")
                    {
                        string a = dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString();
                        string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                        using (SqlConnection conexion = new SqlConnection(cnn))
                        {
                            try
                            {
                                conexion.Open();
                                SqlCommand comando = new SqlCommand("delete from t_juegosFavoritos where appid=@appid and user_id=@user_id", conexion);

                                comando.Parameters.AddWithValue("@appid", dataGridViewPrincipal.Rows[i].Cells[1].Value);
                                comando.Parameters.AddWithValue("@user_id", user_id);
                                comando.ExecuteNonQuery();
                                conexion.Close();
                            }
                            catch (ArgumentException)
                            {
                                MessageBox.Show("Error");
                            }
                        }
                    }

                    if (dataGridViewPrincipal.Rows[i].Cells[0].Value != null && dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString() == "True")
                    {
                        Game game = new Game();
                        game.appid = Convert.ToInt32(dataGridViewPrincipal.Rows[i].Cells[1].Value);
                        game.name = dataGridViewPrincipal.Rows[i].Cells[2].Value.ToString();
                        game.playtime_forever = Convert.ToInt32(dataGridViewPrincipal.Rows[i].Cells[3].Value);
                        game.img_logo_url = dataGridViewPrincipal.Rows[i].Cells[4].Value.ToString();
                        game.playtime_windows_forever = Convert.ToInt32(dataGridViewPrincipal.Rows[i].Cells[5].Value);
                        game.playtime_2weeks = Convert.ToInt32(dataGridViewPrincipal.Rows[i].Cells[6].Value);

                        juegosFav.Add(game);
                    }

                }
                try
                {
                    if (juegosFav.Count > 0)
                    {
                        for (int j = 0; j < juegosFav.Count; j++)
                        {
                            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                            using (SqlConnection conexion = new SqlConnection(cnn))
                            {
                                conexion.Open();
                                SqlCommand sql = new SqlCommand("JuegosAdd", conexion);
                                sql.CommandType = CommandType.StoredProcedure;
                                sql.Parameters.AddWithValue("@user_id", user_id);
                                sql.Parameters.AddWithValue("@appid", juegosFav[j].appid);
                                sql.Parameters.AddWithValue("@name", juegosFav[j].name);
                                sql.Parameters.AddWithValue("@playtime_forever", juegosFav[j].playtime_forever);
                                sql.Parameters.AddWithValue("@img_logo_url", juegosFav[j].img_logo_url);
                                sql.Parameters.AddWithValue("@playtime_windows_forever", juegosFav[j].playtime_windows_forever);
                                sql.Parameters.AddWithValue("@playtime_2weeks", juegosFav[j].playtime_windows_forever);
                                sql.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                juegosFav.Clear();
            }
        }

        private void picAccesoFavoritos_Click(object sender, EventArgs e)
        {
            panelJuegos.Visible = false;
            panelFavoritos.Visible = true;
            picBuscar.Visible = false;
            panelContadorJuegos.Visible = false;
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                SqlCommand comando = new SqlCommand("select distinct appid,name, playtime_forever, img_logo_url, playtime_windows_forever,playtime_2weeks from t_juegosFavoritos where user_id=" + user_id, conexion);
                SqlDataAdapter adaptador = new SqlDataAdapter();
                adaptador.SelectCommand = comando;
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                dataGridViewFavoritos.DataSource = tabla;
            }
        }

        private void picAccesoJuegos_Click(object sender, EventArgs e)
        {
            panelJuegos.Visible = true;
            panelFavoritos.Visible = false;
            picBuscar.Visible = true;
            panelContadorJuegos.Visible = true;
            labelTotalJuegos.Text = totalJuegos + "";
        }

        private void picAccesoAjustes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa realizado por Hadrián Villar Cuadrado \r\nEn un futuro se podrá elegir desde un panel la configuracion de la cuenta y las plataformas de videojuegos con las que te estes conectado, por el momento está WIP\r\n", "- - - - INFORMACIÓN - - - -", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }


        private void picServerSockets_Click(object sender, EventArgs e)
        {
            if (!panelServidor.Visible)
            {             
                panelServidor.Visible = true;
                textboxInfoServer.Text = "";
                iniciarServerSockets();
            }
            else
            {
                panelServidor.Visible = false;
            }
        }

        private void picboxServer_Click(object sender, EventArgs e)
        {
            panelServidor.Visible = true;
            picboxServer.Enabled = false;
            picboxApagarServer.Enabled = true;
            textboxInfoServer.Text += "Servidor iniciado! \r\n";

            System.Net.IPAddress ipadress = System.Net.IPAddress.Parse(ip);
            server.Start(ipadress, puerto);
        }

        private void picboxApagarServer_Click(object sender, EventArgs e)
        {
            if (server.IsStarted)
            {
                picboxServer.Enabled = true;
                picboxApagarServer.Enabled = false;
                panelServidor.Visible = false;
                textboxInfoServer.Text = "";
                server.Stop();
            }
        }

        private void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            textboxInfoServer.Invoke((MethodInvoker)delegate ()
            {
                flag = false;
                cant = 0;
                textboxInfoServer.Text += e.MessageString.Substring(0, e.MessageString.Length - 1) + "\r\n";

                foreach (DataGridViewRow row in dataGridViewPrincipal.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (row.Cells[2].Value.ToString().Contains(e.MessageString.Substring(0, e.MessageString.Length - 1)))
                        {
                            flag = true;
                            cant++;
                        }
                    }
                }
                if (!flag)
                {
                    e.ReplyLine(string.Format("No, en su biblioteca de steam no consta el juego \"{0}\"\r\n", e.MessageString.Substring(0, e.MessageString.Length - 1)));
                }
                else
                {
                    if (cant / dataGridViewPrincipal.Columns.Count > 1)
                    {
                        e.ReplyLine(string.Format("Tiene {1} juegos con \"{0}\" en el nombre\r\n", e.MessageString.Substring(0, e.MessageString.Length - 1), cant / dataGridViewPrincipal.Columns.Count));
                    }
                    else
                    {
                        e.ReplyLine(string.Format("Si, tiene el juego \"{0}\" en su biblioteca de steam\r\n", e.MessageString.Substring(0, e.MessageString.Length - 1)));
                    }
                }
            });
        }

        private void picBuscar_Click(object sender, EventArgs e)
        {
            FormBusqueda busqueda = new FormBusqueda();

            if (busqueda.ShowDialog() == DialogResult.OK)
            {
                dataGridViewPrincipal.ClearSelection();
                nombrejuego = busqueda.datos;
                foreach (DataGridViewRow row in dataGridViewPrincipal.Rows)
                {
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (row.Cells[2].Value.ToString().Contains(nombrejuego))
                        {
                            cell.Selected = true;
                            dataGridViewPrincipal.CurrentCell = cell;
                        }
                    }
                }
            }
        }

        public FormDatos(int id, string s_key, string s_id, string user)
        {
            InitializeComponent();
            user_id = id;
            steam_id = s_id;
            steam_key = s_key;
            user_string = user;
            labelNombreUsuario.Text = user;

            panelFavoritos.Location = new Point(61, 114);
            panelFavoritos.Size = new Size(939, 537);
            panelJuegos.Location = new Point(61, 114);
            panelJuegos.Size = new Size(939, 537);

            panelJuegos.Visible = true;
            panelFavoritos.Visible = false;

            server = new SimpleTcpServer();
            server.StringEncoder = Encoding.UTF8;
            server.Delimiter = 0x13;
            server.DataReceived += Server_DataReceived;
        }

        public FormDatos()
        {
            InitializeComponent();           
        }


        public void iniciarServerSockets()
        {
            bool puertoValido = false;
            int p = 31416;
            FormDatos form = new FormDatos();

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
                    textboxInfoServer.Text= String.Format("Esperando usuarios...{0,60} puerto actual {1}", p, iPEndPoint);
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
                    textboxInfoServer.Text = String.Format("El puerto {0} es invalido", p);
                    p++;
                }
            }
        }

        private void hiloCliente(Object socket)
        {
            Socket cliente = (Socket)socket;
            IPEndPoint ieCliente = (IPEndPoint)cliente.RemoteEndPoint;
            textboxInfoServer.Text = String.Format("Usuario conectado con la ip:{0} en el puerto:{1}", ieCliente.Address, ieCliente.Port);

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
                            sw.WriteLine("Hola tiene ese juego");
                        }
                        else if (mensaje.ToLower().Contains("help"))
                        {
                            sw.WriteLine("help  : Muestra el listado de comandos disponibles");
                            sw.WriteLine("juego : La consulta tiene que tener la estructura: juego=X");
                            sw.WriteLine("exit  : Corta la conexión con el servidor");
                        }
                        else
                        {
                            sw.WriteLine("Comando erróneo");
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

        public async Task<string> getHttp()
        {
            WebRequest webRequest = WebRequest.Create("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + steam_key + "&steamid=" + steam_id + "&include_appinfo=1");
            WebResponse webResponse = webRequest.GetResponse();
            StreamReader streamReader = new StreamReader(webResponse.GetResponseStream());
            return await streamReader.ReadToEndAsync();
        }
    }

    public class Game
    {
        public int appid { get; set; }
        public string name { get; set; }
        public int playtime_forever { get; set; }
        public string img_logo_url { get; set; }
        public int playtime_windows_forever { get; set; }
        public int playtime_2weeks { get; set; }
    }

    public class Response
    {
        public int game_count { get; set; }
        public List<Game> games { get; set; }
    }

    public class RootObject
    {
        public Response response { get; set; }
    }
}