using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace GHub
{
    public partial class FormDatos : MaterialSkin.Controls.MaterialForm
    {
        public string key, id;
        public FormDatos(string steam_key, string steam_id)
        {
            InitializeComponent();
            recogerDatos(steam_key, steam_id);
        }

        public static async Task recogerDatos(string steam_key, string steam_id)
        {
            steam_key = "E47A942CE0168FE3013C26D05F7A0D23";
            steam_id = "76561197960434622";
            var uri = new Uri("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key=" + steam_key + "&steamid=" + steam_id + "&include_appinfo=1");
            HttpClient myClient = new HttpClient();

            var response = await myClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                var juegos = JsonConvert.DeserializeObject<List<Juego>>(content);
                
            }
        }






    }

    public class Juego
    {
        public int appid { get; set; }              //appid             int
        public string name { get; set; }            //name              varchar(50)
        public string developer { get; set; }       //developer         varchar(50)
        public int average_forever { get; set; }    //average_forever   int
        public string genre { get; set; }           //genre             varchar(50)
    }
}
