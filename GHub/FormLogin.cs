using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace GHub
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public FormLogin()
        {
            InitializeComponent();

            //Referencia para los colores https://www.materialui.co/colors

            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.AddFormToManage(this);
            skinManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new MaterialSkin.ColorScheme
                (
                MaterialSkin.Primary.Teal900,
                MaterialSkin.Primary.Teal800,
                MaterialSkin.Primary.Teal700,
                MaterialSkin.Accent.Teal400,
                MaterialSkin.TextShade.BLACK
                );

            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;

            imagenAtras.BackgroundImage = Properties.Resources.atras;
            imagenPerfil.BackgroundImage = Properties.Resources.perfil;
            imagenSteam.BackgroundImage = Properties.Resources.steam;
            
        }


        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM usuarios WHERE usuario='" + textboxUser.Text + "' AND pass='" + textboxPass.Text + "'", conexion))
                    {
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("Login exitoso.");
                        }
                        else
                        {
                            MessageBox.Show("Datos incorrectos.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }



        private void labelRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            panelLogin.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void labelYaTengoCuenta_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;

        }

        private void labelOlvido_Click(object sender, EventArgs e)
        {
            panelReestablecerPass.Visible = true;
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
        }
        
        private void imagenAtras_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void linkClaveSteam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkClaveSteam.LinkVisited = true;
            System.Diagnostics.Process.Start("https://steamcommunity.com/dev/apikey");
        }

        

        private void linkSteamId_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkSteamId.LinkVisited = true;
            System.Diagnostics.Process.Start("https://steamdb.info/calculator/");
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            //Inserta en base de datos los credenciales
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void btnEnviarEmailRecuperar_Click(object sender, EventArgs e)
        {
            //Enviar correo con credenciales
        }


    }
}
