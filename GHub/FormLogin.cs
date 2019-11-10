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
using System.Net.Mail;

namespace GHub
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public string errorCuenta = "Ha ocurrido un error creando la cuenta";
        public string okCuenta = "¡ Cuenta creada con exito !";
        public string errorRecuperarPass = "No existe ninguna cuenta con ese correo asociado";
        public string okRecuperarPass = "Se ha enviado un correo con tus credenciales";
        
        public Color colorOk = Color.FromArgb(167, 231, 183);
        public Color colorError = Color.FromArgb(255, 128, 128);
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("mail", "password");

        public FormLogin()
        {
            InitializeComponent();

            //Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True; string conexion
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
            panelInfoAuxiliar.Visible = false;



            imagenAtras.BackgroundImage = Properties.Resources.atras;
            imagenPerfil.BackgroundImage = Properties.Resources.perfil;
            imagenSteam.BackgroundImage = Properties.Resources.steam;
        }

        private void labelRegistrarse_Click(object sender, EventArgs e)
        {
            panelRegistro.Visible = true;
            panelLogin.Visible = false;
            panelReestablecerPass.Visible = false;
            panelInfoAuxiliar.Visible = false;
            MessageBox.Show("Regsitrarse");
        }

        private void labelYaTengoCuenta_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
            panelInfoAuxiliar.Visible = false;
            MessageBox.Show("ya tengo cuenta");

        }

        private void labelOlvido_Click(object sender, EventArgs e)
        {
            panelReestablecerPass.Visible = true;
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
            panelInfoAuxiliar.Visible = false;
            MessageBox.Show("olvido");

        }

        private void imagenAtras_Click(object sender, EventArgs e)
        {
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
            panelInfoAuxiliar.Visible = false;
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
            if (true) //si cuenta valida
            {
                //Inserta en base de datos los credenciales                               
                labelErrorOkInfo.Text = okCuenta;
                imagenErrorOk.BackgroundImage = Properties.Resources.ok;
                panelPopupInfo.BackColor = colorOk;
            }
            else
            {
                labelErrorOkInfo.Text = errorCuenta;
                imagenErrorOk.BackgroundImage = Properties.Resources.error;
                panelPopupInfo.BackColor = colorError;

            }
            panelInfoAuxiliar.Visible = true;
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;

            MessageBox.Show("crearusuario");

        }

        private void btnEnviarEmailRecuperar_Click(object sender, EventArgs e)
        {
            if (true)
            {
                string msgCuerpo = "<html><p>Los credenciales con los que se ha registrado el usuario de email: " + email + "</p><p>Son los siguientes.</p><table style='height: 60px; width: 418px;' cellpadding='12'><tbody><tr style='height: 23px;'><td style='width: 260px; height: 23px;'>Nombre de usuario:</td><td style='width: 157px; height: 23px;'>" + user + "</td></tr><tr style='height: 9px;'><td style='width: 260px; height: 9px;'>Contrase&ntilde;a:</td><td style='width: 157px; height: 9px;'>" + pass + "</td></tr></tbody></table></html>";

                //Enviar correo con credenciales

                try
                {
                    MailMessage mail = new MailMessage("ghub.development@gmail.com", to, "Te has olvidado de tu contraseña?", msgCuerpo);
                    SmtpClient client = new SmtpClient("smtp.gmail.com");
                    client.Port = 587;
                    client.Credentials = new System.Net.NetworkCredential("ghub.development@gmail.com", "qw3rty123456");
                    client.EnableSsl = true;
                    client.Send(mail);
                    //ya ta

                }
                catch (Exception error)
                {
                    MessageBox.Show("Unexpected Error: " + error);
                }

                MessageBox.Show("Mail Send");

                //Mensaje enviado panel
                labelErrorOkInfo.Text = okRecuperarPass;
                imagenErrorOk.BackgroundImage = Properties.Resources.ok;
                panelPopupInfo.BackColor = colorOk;

            }
            else
            {
                labelErrorOkInfo.Text = errorRecuperarPass;
                imagenErrorOk.BackgroundImage = Properties.Resources.error;
                panelPopupInfo.BackColor = colorError;

            }
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
            panelInfoAuxiliar.Visible = true;
            MessageBox.Show("recuperaremail");

        }

        private void panelInfoAuxiliar_Click(object sender, EventArgs e)
        {
            panelInfoAuxiliar.Visible = false;
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //iniciarSesion();
            MessageBox.Show("iniciar sesion");
        }
        public void iniciarSesion()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT usuario, pass FROM Usuarios WHERE usuario='" + textboxUser.Text + "' AND pass='" + textboxPass.Text + "'", conexion))
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

        public bool crearCuenta()
        {
            try
            {
                if (!(txtboxNuevoUsuario.Text == "" || txtboxNuevaPass.Text == "" ||
                    txtboxRepetirPass.Text == "" || txtboxNuevoEmail.Text == "" ||
                    txtboxNuevaClave.Text == "" || txtboxNuevoSteamID.Text == "")
                    && (txtboxNuevaPass.Text == txtboxRepetirPass.Text))
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        SqlCommand sql = new SqlCommand("CrearUsuario", conexion);
                        sql.CommandType = CommandType.StoredProcedure;
                        sql.Parameters.AddWithValue("@usuario", txtboxNuevoUsuario.Text.Trim());
                        sql.Parameters.AddWithValue("@password", txtboxNuevaPass.Text.Trim());
                        sql.Parameters.AddWithValue("@email", txtboxNuevoEmail.Text.Trim());
                        sql.Parameters.AddWithValue("@steam_key", txtboxNuevaClave.Text.Trim());
                        sql.Parameters.AddWithValue("@steam_id", txtboxNuevoSteamID.Text.Trim());
                        sql.ExecuteNonQuery();

                        labelErrorCampos.Visible = false;
                        limpiarCampos();
                        return true;
                    }
                }
                labelErrorCampos.Visible = true;
                return false;
            }
            catch (Exception ex)
            {
                //En caso de error mostrar mensaje
                MessageBox.Show(ex.ToString());
                return false;
            }

        }

        public void limpiarCampos()
        {
            txtboxNuevoUsuario.Text = txtboxNuevaPass.Text = txtboxRepetirPass.Text = txtboxNuevoEmail.Text = txtboxNuevaClave.Text = txtboxNuevoSteamID.Text = "";
        }
    }
}
