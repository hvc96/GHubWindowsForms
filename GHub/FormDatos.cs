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

namespace GHub
{
    public partial class FormDatos : MaterialSkin.Controls.MaterialForm
    {
        public string steam_key, steam_id, url;

        private async void FormDatos_Load(object sender, EventArgs e)
        {
            string respuesta = await getHttp();            
            RootObject rootDatos = JsonConvert.DeserializeObject<RootObject>(respuesta);

            ////Una vez recoja los datos, mostrarlos y usar api de steamspy para los tags. 
            ////Una vez hecha esa parte, hacer socket y rematar haciendo expresiones regulares para el control de datos 

            MessageBox.Show("Tienes "+rootDatos.response.game_count + " juegos");

            for (int i = 0; i < rootDatos.response.game_count; i++)
            {
                //dataGridViewPrincipal.Columns.Add
                // dataGridViewPrincipal.Rows.Add(rootDatos.response.games[i]);
                //MessageBox.Show("A " + dataJuegos.games[i]);
            }




        }

        private void imagenBuscador_Click(object sender, EventArgs e)
        {
            //realizar la busqueda
        }

        public FormDatos(string key, string id)
        {
            InitializeComponent();
            steam_id = id;
            steam_key = key;

            imagenBuscador.BackgroundImage = GHub.Properties.Resources.go;

            dataGridViewPrincipal.Columns[0].SortMode = DataGridViewColumnSortMode.NotSortable;
            dataGridViewPrincipal.Columns[0].HeaderCell.Style.Alignment=DataGridViewContentAlignment.MiddleCenter;

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
        public string img_icon_url { get; set; }
        public string img_logo_url { get; set; }
        public bool has_community_visible_stats { get; set; }
        public int playtime_windows_forever { get; set; }
        public int playtime_mac_forever { get; set; }
        public int playtime_linux_forever { get; set; }
        public int? playtime_2weeks { get; set; }
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



    //appid             int
    //name              varchar(50)
    //developer         varchar(50)
    //average_forever   int
    //genre             varchar(50)


    /*
     {  
       "response":{  
          "game_count":948,
          "games":[  
             {  
                "appid":10,
                "name":"Counter-Strike",
                "playtime_forever":32,
                "img_icon_url":"6b0312cda02f5f777efa2f3318c307ff9acafbb5",
                "img_logo_url":"af890f848dd606ac2fd4415de3c3f5e7a66fcb9f",
                "has_community_visible_stats":true,
                "playtime_windows_forever":0,
                "playtime_mac_forever":0,
                "playtime_linux_forever":0
             },
     */
}
