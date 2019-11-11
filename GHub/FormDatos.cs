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

namespace GHub
{
    public partial class FormDatos : MaterialSkin.Controls.MaterialForm
    {
        public FormDatos()
        {
            InitializeComponent();
        }

        public static async Task RefreshDataAsync(string clave, string steam_id)
        {
            clave = "E47A942CE0168FE3013C26D05F7A0D23";
            steam_id = "76561197960434622";
            var uri = new Uri("https://api.steampowered.com/IPlayerService/GetOwnedGames/v1/?key="+clave+"&steamid="+steam_id+"&include_appinfo=1");
            HttpClient myClient = new HttpClient();

            var response = await myClient.GetAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                //var items = json
                //var Items = JsonConvert.DeserializeObject<List<RootObject>>(content);
                Console.WriteLine("");
            }
        }

        //Una vez logueado tiene que sacar los datos con otra consulta
        //
    }
}
