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

namespace GHub
{
    public partial class FormDatos : MaterialSkin.Controls.MaterialForm
    {
        public string steam_key, steam_id, url;
        public int user_id;
        public List<Game> juegosFav;
        public bool borrado;

        private async void FormDatos_Load(object sender, EventArgs e)
        {
            string respuesta = await getHttp();
            var source = new BindingSource();
            RootObject rootDatos = JsonConvert.DeserializeObject<RootObject>(respuesta);
            Response response = rootDatos.response;

            List<Game> games = response.games;
            source.DataSource = games;

            labelTotalJuegos.Text = response.game_count.ToString();

            dataGridViewPrincipal.DataSource = source;
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

                    if (dataGridViewPrincipal.Rows[i].Cells[0].Value != null && dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString()=="True")
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

        private void picAccesoFavoritos_Click(object sender, EventArgs e)
        {
            panelJuegos.Visible = false;
            panelFavoritos.Visible = true;
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                SqlCommand comando = new SqlCommand("select distinct user_id,appid,name, playtime_forever, img_logo_url, playtime_windows_forever,playtime_2weeks from t_juegosFavoritos where user_id=" + user_id, conexion);
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
        }

        private void picAccesoAjustes_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Programa realizado por Hadrián Villar Cuadrado \r\nEn un futuro se podrá elegir desde un panel la configuracion de la cuenta y las plataformas de videojuegos con las que te estes conectado, por el momento está WIP\r\n", "- - - - INFORMACIÓN - - - -", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormDatos_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        private void dataGridViewPrincipal_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridViewPrincipal.Rows.Count - 1 > 0)
            {
                for (int i = 0; i < dataGridViewPrincipal.Rows.Count - 1; i++)
                {

                    if (dataGridViewPrincipal.Rows[i].Cells[0].Value != null)
                    {
                        if (dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString().Equals("False"))
                        {
                            string a = dataGridViewPrincipal.Rows[i].Cells[0].Value.ToString();
                            MessageBox.Show(a);
                            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                            using (SqlConnection conexion = new SqlConnection(cnn))
                            {
                                conexion.Open();
                                SqlCommand comando = new SqlCommand("delete from t_juegosFavoritos where @appid && @user_id", conexion);
                                //SqlCommand comando2 = new SqlCommand("select * from t_juegosFavoritos where user_id=" + user_id, conexion);
                                comando.Parameters.AddWithValue("@appid", dataGridViewPrincipal.Rows[i].Cells[2]);
                                comando.Parameters.AddWithValue("@user_id", user_id);
                                comando.ExecuteNonQuery();
                                conexion.Close();
                                MessageBox.Show("eliminado");



                                //SqlCommand comando = new SqlCommand("insert into Arope(REGION,DEPENDENCIA,OPERACION,SIGLAUNIDAD,SECCION,DEPARTAMENTO,MUNICIPIO,[OF],SUB,PT,TOTALFD,GR,NOMBRESYAPELLIDOS,CEDULA,CARGO,UBICACION,MISION,ACTOADMIN,LATITUD,LONGITUD) values (@region,@dependencia,@operacion,@siglaUnidad,@seccion,@departamento,@municipio,@of,@sub,@pt,@totalFd,@gr,@nombresyapellidos,@cedula,@cargo,@ubicacion,@mision,@actoAdmin,@latitud,@longitud)", conec);

                            }
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
            labelNombreUsuario.Text = user;


            panelFavoritos.Location = new Point(61, 114);
            panelFavoritos.Size = new Size(939, 537);
            panelJuegos.Location = new Point(61, 114);
            panelJuegos.Size = new Size(939, 537);

            panelJuegos.Visible = true;
            panelFavoritos.Visible = false;
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