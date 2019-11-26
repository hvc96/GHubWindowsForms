using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Net.Mail;
using System.Text.RegularExpressions;
using System.Security.Cryptography;

namespace GHub
{
    public partial class FormLogin : MaterialSkin.Controls.MaterialForm
    {
        public string errorCuenta = "Ha ocurrido un error creando la cuenta";
        public string okCuenta = "¡ Cuenta creada con exito !";
        public string errorEnvioCorreo = "Ha ocurrido un error enviando el correo, comprueba la red";
        public string errorRecuperarPass = "No existe ninguna cuenta con ese correo asociado";
        public string okRecuperarPass = "Se ha enviado un correo con tus credenciales";

        string hash = "Ghub_HVillar";
        public bool ver1 = false, ver2 = false, errorCrear = false;

        public Color colorOk = Color.FromArgb(167, 231, 183);
        public Color colorError = Color.FromArgb(255, 128, 128);
        public SmtpClient client = new SmtpClient();
        public MailMessage msg = new MailMessage();
        public System.Net.NetworkCredential smtpCreds = new System.Net.NetworkCredential("mail", "password");

        public FormLogin()
        {
            InitializeComponent();
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
        }

        private void labelYaTengoCuenta_Click(object sender, EventArgs e)
        {
            errorCrear = false;
            panelLogin.Visible = true;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
            panelInfoAuxiliar.Visible = false;
        }

        private void labelOlvido_Click(object sender, EventArgs e)
        {
            panelReestablecerPass.Visible = true;
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
            panelInfoAuxiliar.Visible = false;
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
            //Inserta en base de datos los credenciales       
            crearCuenta();
            if (errorCrear)
            {
                labelErrorOkInfo.Text = errorCuenta;
                imagenErrorOk.BackgroundImage = Properties.Resources.error;
                panelPopupInfo.BackColor = colorError;
            }
            else
            {
                labelErrorOkInfo.Text = okCuenta;
                imagenErrorOk.BackgroundImage = Properties.Resources.ok;
                panelPopupInfo.BackColor = colorOk;
            }
            panelInfoAuxiliar.Visible = true;
            panelLogin.Visible = false;
            panelRegistro.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void btnEnviarEmailRecuperar_Click(object sender, EventArgs e)
        {
            if (!textboxEnviarCredenciales.Text.Equals(""))
            {
                try
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        string usuarioParametro = "", passwordParametro = "", emailParametro = "";
                        conexion.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT usuario, password, email FROM t_usuarios WHERE email='" + textboxEnviarCredenciales.Text.Trim() + "'", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();

                            while (dr.Read())
                            {
                                usuarioParametro = dr.GetString(0);
                                passwordParametro = dr.GetString(1);
                                emailParametro = dr.GetString(2);
                            }

                            if (textboxEnviarCredenciales.Text == emailParametro)//Email es correcto
                            {
                                string msgCuerpo = "<html><p>Los credenciales con los que se ha registrado el usuario de email: "
                                    + emailParametro + "</p><p>Son los siguientes.</p><table style='height: 60px; width: 418px;' cellpadding='12'><tbody><tr style='height: 23px;'><td style='width: 260px; height: 23px;'>Nombre de usuario:</td><td style='width: 157px; height: 23px;'>"
                                    + usuarioParametro + "</td></tr><tr style='height: 9px;'><td style='width: 260px; height: 9px;'>Contrase&ntilde;a:</td><td style='width: 157px; height: 9px;'>"
                                    + decrypt(passwordParametro) + "</td></tr></tbody></table></html>";

                                MailMessage msg = new MailMessage();
                                msg.To.Add(emailParametro);
                                msg.Subject = "Te has olvidado de tu contraseña?";
                                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                                msg.Body = msgCuerpo;
                                msg.BodyEncoding = System.Text.Encoding.UTF8;
                                msg.IsBodyHtml = true;
                                msg.From = new System.Net.Mail.MailAddress("ghub.dev@gmail.com");

                                System.Net.Mail.SmtpClient client = new System.Net.Mail.SmtpClient();
                                client.UseDefaultCredentials = false;
                                client.Credentials = new System.Net.NetworkCredential("ghub.dev@gmail.com", "qw3rty123456");
                                client.Port = 587;
                                client.EnableSsl = true;
                                client.Host = "smtp.gmail.com";

                                try
                                {
                                    client.Send(msg);

                                    //Mensaje enviado , mostrar panel
                                    labelErrorOkInfo.Text = okRecuperarPass;
                                    imagenErrorOk.BackgroundImage = Properties.Resources.ok;
                                    panelPopupInfo.BackColor = colorOk;

                                }
                                catch (Exception err)
                                {
                                    //Error enviando correo (Sin conexión)
                                    //MessageBox.Show("Unexpected Error: " + err.Message);
                                    labelErrorOkInfo.Text = errorEnvioCorreo;
                                    imagenErrorOk.BackgroundImage = Properties.Resources.error;
                                    panelPopupInfo.BackColor = colorError;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //Por si acaso excepcion SQL
                    MessageBox.Show(ex.ToString());
                }
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
        }

        private void panelInfoAuxiliar_Click(object sender, EventArgs e)
        {
            if (errorCrear)
            {
                panelLogin.Visible = false;
                panelRegistro.Visible = true;
            }
            else
            {
                panelLogin.Visible = true;
                panelRegistro.Visible = false;
            }
            panelInfoAuxiliar.Visible = false;
            panelReestablecerPass.Visible = false;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            iniciarSesion();
        }

        public void iniciarSesion()
        {
            string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
            using (SqlConnection conexion = new SqlConnection(cnn))
            {
                conexion.Open();
                using (SqlCommand cmd = new SqlCommand("SELECT id, usuario, password, steam_key, steam_id FROM t_usuarios WHERE usuario='" + textboxUser.Text + "' AND password='" + encrypt(textboxPass.Text) + "'", conexion))
                {
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read()) //Si devuelve alguna fila, tiene datos
                    {
                        int id = dr.GetInt32(0);
                        string usuario = dr.GetString(1);
                        string password = dr.GetString(2);
                        string steam_key = dr.GetString(3);
                        string steam_id = dr.GetString(4);

                        if (usuario == textboxUser.Text.Trim() && password == encrypt(textboxPass.Text.Trim()))
                        {

                            FormDatos formSteamData = new FormDatos(id, steam_key, steam_id, usuario);
                            this.Hide();
                            formSteamData.ShowDialog(this);
                            this.Dispose();
                        }

                    }
                }
                labelLoginError.Visible = true;
            }
        }

        public void crearCuenta()
        {
            //Gmail valido
            Regex r = new Regex(@"^[a-z0-9](\.?[a-z0-9]){5,}@g(oogle)?mail\.com$");
            errorCrear = false;
            try
            {
                if (!(txtboxNuevoUsuario.Text == "" && txtboxNuevaPass.Text == "" &&
                    txtboxRepetirPass.Text == "" && txtboxNuevoEmail.Text == "" &&
                    txtboxNuevaClave.Text == "" && txtboxNuevoSteamID.Text == "")
                    && (txtboxNuevaPass.Text == txtboxRepetirPass.Text)
                    && (r.Match(txtboxNuevoEmail.Text).Success))
                {
                    string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                    using (SqlConnection conexion = new SqlConnection(cnn))
                    {
                        conexion.Open();
                        SqlCommand sql = new SqlCommand("CrearUsuario", conexion);
                        sql.CommandType = CommandType.StoredProcedure;
                        sql.Parameters.AddWithValue("@usuario", txtboxNuevoUsuario.Text.Trim());
                        sql.Parameters.AddWithValue("@password", encrypt(txtboxNuevaPass.Text.Trim())); 
                        sql.Parameters.AddWithValue("@email", txtboxNuevoEmail.Text.Trim());
                        sql.Parameters.AddWithValue("@steam_key", txtboxNuevaClave.Text.Trim());
                        sql.Parameters.AddWithValue("@steam_id", txtboxNuevoSteamID.Text.Trim());
                        sql.ExecuteNonQuery();

                        labelErrorCampos.Visible = false;
                        limpiarCampos();
                    }
                }
                labelErrorCampos.Visible = true;
                errorCrear = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                errorCrear = true;
            }

        }

        public void limpiarCampos()
        {
            txtboxNuevoUsuario.Text = txtboxNuevaPass.Text = txtboxRepetirPass.Text = txtboxNuevoEmail.Text = txtboxNuevaClave.Text = txtboxNuevoSteamID.Text = "";
        }

        private void ojoRepetirPass_Click(object sender, EventArgs e)
        {
            ver1 = !ver1;
            if (ver1)
            {
                ojoRepetirPass.BackgroundImage = GHub.Properties.Resources.nover;
                txtboxRepetirPass.UseSystemPasswordChar = false;
            }
            else
            {
                ojoRepetirPass.BackgroundImage = GHub.Properties.Resources.ver;
                txtboxRepetirPass.UseSystemPasswordChar = true;
            }
        }

        private void ojoPass_Click(object sender, EventArgs e)
        {
            ver2 = !ver2;
            if (ver2)
            {
                ojoPass.BackgroundImage = GHub.Properties.Resources.nover;
                txtboxNuevaPass.UseSystemPasswordChar = false;
            }
            else
            {
                ojoPass.BackgroundImage = GHub.Properties.Resources.ver;
                txtboxNuevaPass.UseSystemPasswordChar = true;
            }
        }

        private string encrypt(string password)
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string passwordEncrypt = Convert.ToBase64String(results, 0, results.Length);
                    return passwordEncrypt;
                }
            }
        }

        private void textboxUser_Click(object sender, EventArgs e)
        {
            labelLoginError.Visible = false;
        }

        private void textboxPass_Click(object sender, EventArgs e)
        {
            labelLoginError.Visible = false;
        }

        private string decrypt(string password)
        {
            byte[] data = Convert.FromBase64String(password);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));
                using (TripleDESCryptoServiceProvider tripleDES = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripleDES.CreateDecryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    string passwordDecrypt = UTF8Encoding.UTF8.GetString(results);
                    return passwordDecrypt;
                }
            }
        }

    }
}
