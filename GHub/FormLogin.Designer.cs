namespace GHub
{
    partial class FormLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLogin = new System.Windows.Forms.Panel();
            this.labelRegistrarse = new System.Windows.Forms.Label();
            this.labelOlvido = new System.Windows.Forms.Label();
            this.imagenPerfil = new System.Windows.Forms.PictureBox();
            this.textboxUser = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.textboxPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.chkRecordarcredenciales = new MaterialSkin.Controls.MaterialCheckBox();
            this.btnLogin = new MaterialSkin.Controls.MaterialRaisedButton();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.btnCrearUsuario = new MaterialSkin.Controls.MaterialRaisedButton();
            this.imagenSteam = new System.Windows.Forms.PictureBox();
            this.linkSteamId = new System.Windows.Forms.LinkLabel();
            this.linkClaveSteam = new System.Windows.Forms.LinkLabel();
            this.txtboxNuevoSteamID = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxNuevaClave = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelYaTengoCuenta = new System.Windows.Forms.Label();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.txtboxNuevoEmail = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxRepetirPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxNuevaPass = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxNuevoUsuario = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panelReestablecerPass = new System.Windows.Forms.Panel();
            this.imagenAtras = new System.Windows.Forms.PictureBox();
            this.btnEnviarEmailRecuperar = new MaterialSkin.Controls.MaterialRaisedButton();
            this.textboxEnviarCredenciales = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.labelLeyendaCorreo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelInfoAuxiliar = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panelPopupInfo = new System.Windows.Forms.Panel();
            this.labelErrorOkInfo = new System.Windows.Forms.Label();
            this.imagenErrorOk = new System.Windows.Forms.PictureBox();
            this.labelErrorCampos = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil)).BeginInit();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSteam)).BeginInit();
            this.panelReestablecerPass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAtras)).BeginInit();
            this.panelInfoAuxiliar.SuspendLayout();
            this.panelPopupInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenErrorOk)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.SystemColors.Control;
            this.panelLogin.Controls.Add(this.labelRegistrarse);
            this.panelLogin.Controls.Add(this.labelOlvido);
            this.panelLogin.Controls.Add(this.imagenPerfil);
            this.panelLogin.Controls.Add(this.textboxUser);
            this.panelLogin.Controls.Add(this.textboxPass);
            this.panelLogin.Controls.Add(this.chkRecordarcredenciales);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Location = new System.Drawing.Point(0, 64);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(882, 526);
            this.panelLogin.TabIndex = 9;
            // 
            // labelRegistrarse
            // 
            this.labelRegistrarse.AutoSize = true;
            this.labelRegistrarse.BackColor = System.Drawing.Color.Transparent;
            this.labelRegistrarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegistrarse.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelRegistrarse.Location = new System.Drawing.Point(396, 443);
            this.labelRegistrarse.Name = "labelRegistrarse";
            this.labelRegistrarse.Size = new System.Drawing.Size(91, 20);
            this.labelRegistrarse.TabIndex = 10;
            this.labelRegistrarse.Text = "Registrarse";
            this.labelRegistrarse.Click += new System.EventHandler(this.labelRegistrarse_Click);
            // 
            // labelOlvido
            // 
            this.labelOlvido.AutoSize = true;
            this.labelOlvido.BackColor = System.Drawing.Color.Transparent;
            this.labelOlvido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOlvido.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelOlvido.Location = new System.Drawing.Point(338, 373);
            this.labelOlvido.Name = "labelOlvido";
            this.labelOlvido.Size = new System.Drawing.Size(218, 20);
            this.labelOlvido.TabIndex = 9;
            this.labelOlvido.Text = "¿Has olvidado la contraseña?";
            this.labelOlvido.Click += new System.EventHandler(this.labelOlvido_Click);
            // 
            // imagenPerfil
            // 
            this.imagenPerfil.BackColor = System.Drawing.Color.Transparent;
            this.imagenPerfil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imagenPerfil.InitialImage = null;
            this.imagenPerfil.Location = new System.Drawing.Point(384, 45);
            this.imagenPerfil.Name = "imagenPerfil";
            this.imagenPerfil.Size = new System.Drawing.Size(122, 125);
            this.imagenPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.imagenPerfil.TabIndex = 8;
            this.imagenPerfil.TabStop = false;
            // 
            // textboxUser
            // 
            this.textboxUser.Depth = 0;
            this.textboxUser.Hint = "Usuario";
            this.textboxUser.Location = new System.Drawing.Point(336, 185);
            this.textboxUser.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxUser.Name = "textboxUser";
            this.textboxUser.PasswordChar = '\0';
            this.textboxUser.SelectedText = "";
            this.textboxUser.SelectionLength = 0;
            this.textboxUser.SelectionStart = 0;
            this.textboxUser.Size = new System.Drawing.Size(220, 23);
            this.textboxUser.TabIndex = 0;
            this.textboxUser.UseSystemPasswordChar = false;
            // 
            // textboxPass
            // 
            this.textboxPass.Depth = 0;
            this.textboxPass.Hint = "Contraseña";
            this.textboxPass.Location = new System.Drawing.Point(336, 214);
            this.textboxPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxPass.Name = "textboxPass";
            this.textboxPass.PasswordChar = '\0';
            this.textboxPass.SelectedText = "";
            this.textboxPass.SelectionLength = 0;
            this.textboxPass.SelectionStart = 0;
            this.textboxPass.Size = new System.Drawing.Size(220, 23);
            this.textboxPass.TabIndex = 1;
            this.textboxPass.UseSystemPasswordChar = true;
            // 
            // chkRecordarcredenciales
            // 
            this.chkRecordarcredenciales.AutoSize = true;
            this.chkRecordarcredenciales.BackColor = System.Drawing.Color.Transparent;
            this.chkRecordarcredenciales.Depth = 0;
            this.chkRecordarcredenciales.Font = new System.Drawing.Font("Roboto", 10F);
            this.chkRecordarcredenciales.Location = new System.Drawing.Point(362, 251);
            this.chkRecordarcredenciales.Margin = new System.Windows.Forms.Padding(0);
            this.chkRecordarcredenciales.MouseLocation = new System.Drawing.Point(-1, -1);
            this.chkRecordarcredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.chkRecordarcredenciales.Name = "chkRecordarcredenciales";
            this.chkRecordarcredenciales.Ripple = false;
            this.chkRecordarcredenciales.Size = new System.Drawing.Size(162, 20);
            this.chkRecordarcredenciales.TabIndex = 2;
            this.chkRecordarcredenciales.Text = "Recordar credenciales";
            this.chkRecordarcredenciales.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chkRecordarcredenciales.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            this.btnLogin.Depth = 0;
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnLogin.Location = new System.Drawing.Point(316, 295);
            this.btnLogin.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Primary = true;
            this.btnLogin.Size = new System.Drawing.Size(259, 59);
            this.btnLogin.TabIndex = 4;
            this.btnLogin.Text = "Iniciar sesión";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.labelErrorCampos);
            this.panelRegistro.Controls.Add(this.btnCrearUsuario);
            this.panelRegistro.Controls.Add(this.imagenSteam);
            this.panelRegistro.Controls.Add(this.linkSteamId);
            this.panelRegistro.Controls.Add(this.linkClaveSteam);
            this.panelRegistro.Controls.Add(this.txtboxNuevoSteamID);
            this.panelRegistro.Controls.Add(this.txtboxNuevaClave);
            this.panelRegistro.Controls.Add(this.labelYaTengoCuenta);
            this.panelRegistro.Controls.Add(this.materialDivider1);
            this.panelRegistro.Controls.Add(this.txtboxNuevoEmail);
            this.panelRegistro.Controls.Add(this.txtboxRepetirPass);
            this.panelRegistro.Controls.Add(this.txtboxNuevaPass);
            this.panelRegistro.Controls.Add(this.txtboxNuevoUsuario);
            this.panelRegistro.Location = new System.Drawing.Point(0, 64);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(882, 526);
            this.panelRegistro.TabIndex = 11;
            this.panelRegistro.Visible = false;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Depth = 0;
            this.btnCrearUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCrearUsuario.Location = new System.Drawing.Point(316, 360);
            this.btnCrearUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Primary = true;
            this.btnCrearUsuario.Size = new System.Drawing.Size(259, 59);
            this.btnCrearUsuario.TabIndex = 13;
            this.btnCrearUsuario.Text = "CREAR USUARIO";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // imagenSteam
            // 
            this.imagenSteam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenSteam.Location = new System.Drawing.Point(29, 403);
            this.imagenSteam.Name = "imagenSteam";
            this.imagenSteam.Size = new System.Drawing.Size(94, 100);
            this.imagenSteam.TabIndex = 12;
            this.imagenSteam.TabStop = false;
            // 
            // linkSteamId
            // 
            this.linkSteamId.AutoSize = true;
            this.linkSteamId.Location = new System.Drawing.Point(727, 195);
            this.linkSteamId.Name = "linkSteamId";
            this.linkSteamId.Size = new System.Drawing.Size(99, 13);
            this.linkSteamId.TabIndex = 11;
            this.linkSteamId.TabStop = true;
            this.linkSteamId.Text = "Consigue tu id aquí";
            this.linkSteamId.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkSteamId_LinkClicked);
            // 
            // linkClaveSteam
            // 
            this.linkClaveSteam.AutoSize = true;
            this.linkClaveSteam.Location = new System.Drawing.Point(709, 91);
            this.linkClaveSteam.Name = "linkClaveSteam";
            this.linkClaveSteam.Size = new System.Drawing.Size(117, 13);
            this.linkClaveSteam.TabIndex = 10;
            this.linkClaveSteam.TabStop = true;
            this.linkClaveSteam.Text = "Consigue tu clave aquí";
            this.linkClaveSteam.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkClaveSteam_LinkClicked);
            // 
            // txtboxNuevoSteamID
            // 
            this.txtboxNuevoSteamID.Depth = 0;
            this.txtboxNuevoSteamID.Hint = "Introduzca su SteamID";
            this.txtboxNuevoSteamID.Location = new System.Drawing.Point(475, 243);
            this.txtboxNuevoSteamID.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxNuevoSteamID.Name = "txtboxNuevoSteamID";
            this.txtboxNuevoSteamID.PasswordChar = '\0';
            this.txtboxNuevoSteamID.SelectedText = "";
            this.txtboxNuevoSteamID.SelectionLength = 0;
            this.txtboxNuevoSteamID.SelectionStart = 0;
            this.txtboxNuevoSteamID.Size = new System.Drawing.Size(351, 23);
            this.txtboxNuevoSteamID.TabIndex = 9;
            this.txtboxNuevoSteamID.UseSystemPasswordChar = false;
            // 
            // txtboxNuevaClave
            // 
            this.txtboxNuevaClave.Depth = 0;
            this.txtboxNuevaClave.Hint = "Introduzca su clave";
            this.txtboxNuevaClave.Location = new System.Drawing.Point(475, 134);
            this.txtboxNuevaClave.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxNuevaClave.Name = "txtboxNuevaClave";
            this.txtboxNuevaClave.PasswordChar = '\0';
            this.txtboxNuevaClave.SelectedText = "";
            this.txtboxNuevaClave.SelectionLength = 0;
            this.txtboxNuevaClave.SelectionStart = 0;
            this.txtboxNuevaClave.Size = new System.Drawing.Size(351, 23);
            this.txtboxNuevaClave.TabIndex = 8;
            this.txtboxNuevaClave.UseSystemPasswordChar = false;
            // 
            // labelYaTengoCuenta
            // 
            this.labelYaTengoCuenta.AutoSize = true;
            this.labelYaTengoCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYaTengoCuenta.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelYaTengoCuenta.Location = new System.Drawing.Point(577, 483);
            this.labelYaTengoCuenta.Name = "labelYaTengoCuenta";
            this.labelYaTengoCuenta.Size = new System.Drawing.Size(293, 20);
            this.labelYaTengoCuenta.TabIndex = 7;
            this.labelYaTengoCuenta.Text = "Ya tengo cuenta, quiero iniciar sesión →";
            this.labelYaTengoCuenta.Click += new System.EventHandler(this.labelYaTengoCuenta_Click);
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(452, 81);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(5, 190);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // txtboxNuevoEmail
            // 
            this.txtboxNuevoEmail.Depth = 0;
            this.txtboxNuevoEmail.Hint = "Introduzca su email";
            this.txtboxNuevoEmail.Location = new System.Drawing.Point(77, 243);
            this.txtboxNuevoEmail.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxNuevoEmail.Name = "txtboxNuevoEmail";
            this.txtboxNuevoEmail.PasswordChar = '\0';
            this.txtboxNuevoEmail.SelectedText = "";
            this.txtboxNuevoEmail.SelectionLength = 0;
            this.txtboxNuevoEmail.SelectionStart = 0;
            this.txtboxNuevoEmail.Size = new System.Drawing.Size(351, 23);
            this.txtboxNuevoEmail.TabIndex = 3;
            this.txtboxNuevoEmail.UseSystemPasswordChar = false;
            // 
            // txtboxRepetirPass
            // 
            this.txtboxRepetirPass.Depth = 0;
            this.txtboxRepetirPass.Hint = "Repita la contraseña";
            this.txtboxRepetirPass.Location = new System.Drawing.Point(77, 185);
            this.txtboxRepetirPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxRepetirPass.Name = "txtboxRepetirPass";
            this.txtboxRepetirPass.PasswordChar = '\0';
            this.txtboxRepetirPass.SelectedText = "";
            this.txtboxRepetirPass.SelectionLength = 0;
            this.txtboxRepetirPass.SelectionStart = 0;
            this.txtboxRepetirPass.Size = new System.Drawing.Size(351, 23);
            this.txtboxRepetirPass.TabIndex = 2;
            this.txtboxRepetirPass.UseSystemPasswordChar = false;
            // 
            // txtboxNuevaPass
            // 
            this.txtboxNuevaPass.Depth = 0;
            this.txtboxNuevaPass.Hint = "Introduzca la contraseña";
            this.txtboxNuevaPass.Location = new System.Drawing.Point(77, 134);
            this.txtboxNuevaPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxNuevaPass.Name = "txtboxNuevaPass";
            this.txtboxNuevaPass.PasswordChar = '\0';
            this.txtboxNuevaPass.SelectedText = "";
            this.txtboxNuevaPass.SelectionLength = 0;
            this.txtboxNuevaPass.SelectionStart = 0;
            this.txtboxNuevaPass.Size = new System.Drawing.Size(351, 23);
            this.txtboxNuevaPass.TabIndex = 1;
            this.txtboxNuevaPass.UseSystemPasswordChar = false;
            // 
            // txtboxNuevoUsuario
            // 
            this.txtboxNuevoUsuario.Depth = 0;
            this.txtboxNuevoUsuario.Hint = "Introduzca el nombre de usuario";
            this.txtboxNuevoUsuario.Location = new System.Drawing.Point(77, 81);
            this.txtboxNuevoUsuario.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxNuevoUsuario.Name = "txtboxNuevoUsuario";
            this.txtboxNuevoUsuario.PasswordChar = '\0';
            this.txtboxNuevoUsuario.SelectedText = "";
            this.txtboxNuevoUsuario.SelectionLength = 0;
            this.txtboxNuevoUsuario.SelectionStart = 0;
            this.txtboxNuevoUsuario.Size = new System.Drawing.Size(351, 23);
            this.txtboxNuevoUsuario.TabIndex = 0;
            this.txtboxNuevoUsuario.UseSystemPasswordChar = false;
            // 
            // panelReestablecerPass
            // 
            this.panelReestablecerPass.Controls.Add(this.imagenAtras);
            this.panelReestablecerPass.Controls.Add(this.btnEnviarEmailRecuperar);
            this.panelReestablecerPass.Controls.Add(this.textboxEnviarCredenciales);
            this.panelReestablecerPass.Controls.Add(this.labelLeyendaCorreo);
            this.panelReestablecerPass.Controls.Add(this.label1);
            this.panelReestablecerPass.Location = new System.Drawing.Point(0, 64);
            this.panelReestablecerPass.Name = "panelReestablecerPass";
            this.panelReestablecerPass.Size = new System.Drawing.Size(882, 526);
            this.panelReestablecerPass.TabIndex = 14;
            this.panelReestablecerPass.Visible = false;
            // 
            // imagenAtras
            // 
            this.imagenAtras.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenAtras.Location = new System.Drawing.Point(3, 0);
            this.imagenAtras.Name = "imagenAtras";
            this.imagenAtras.Size = new System.Drawing.Size(47, 55);
            this.imagenAtras.TabIndex = 15;
            this.imagenAtras.TabStop = false;
            this.imagenAtras.Click += new System.EventHandler(this.imagenAtras_Click);
            // 
            // btnEnviarEmailRecuperar
            // 
            this.btnEnviarEmailRecuperar.Depth = 0;
            this.btnEnviarEmailRecuperar.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnEnviarEmailRecuperar.Location = new System.Drawing.Point(311, 355);
            this.btnEnviarEmailRecuperar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEnviarEmailRecuperar.Name = "btnEnviarEmailRecuperar";
            this.btnEnviarEmailRecuperar.Primary = true;
            this.btnEnviarEmailRecuperar.Size = new System.Drawing.Size(253, 58);
            this.btnEnviarEmailRecuperar.TabIndex = 14;
            this.btnEnviarEmailRecuperar.Text = "ENVIAR";
            this.btnEnviarEmailRecuperar.UseVisualStyleBackColor = true;
            this.btnEnviarEmailRecuperar.Click += new System.EventHandler(this.btnEnviarEmailRecuperar_Click);
            // 
            // textboxEnviarCredenciales
            // 
            this.textboxEnviarCredenciales.Depth = 0;
            this.textboxEnviarCredenciales.Hint = "Correo electrónico";
            this.textboxEnviarCredenciales.Location = new System.Drawing.Point(252, 194);
            this.textboxEnviarCredenciales.MouseState = MaterialSkin.MouseState.HOVER;
            this.textboxEnviarCredenciales.Name = "textboxEnviarCredenciales";
            this.textboxEnviarCredenciales.PasswordChar = '\0';
            this.textboxEnviarCredenciales.SelectedText = "";
            this.textboxEnviarCredenciales.SelectionLength = 0;
            this.textboxEnviarCredenciales.SelectionStart = 0;
            this.textboxEnviarCredenciales.Size = new System.Drawing.Size(361, 23);
            this.textboxEnviarCredenciales.TabIndex = 10;
            this.textboxEnviarCredenciales.UseSystemPasswordChar = false;
            // 
            // labelLeyendaCorreo
            // 
            this.labelLeyendaCorreo.AutoSize = true;
            this.labelLeyendaCorreo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLeyendaCorreo.Location = new System.Drawing.Point(230, 152);
            this.labelLeyendaCorreo.Name = "labelLeyendaCorreo";
            this.labelLeyendaCorreo.Size = new System.Drawing.Size(403, 18);
            this.labelLeyendaCorreo.TabIndex = 9;
            this.labelLeyendaCorreo.Text = "Introduce el correo electrónico con el que te has registrado: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(307, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(257, 24);
            this.label1.TabIndex = 8;
            this.label1.Text = "¿Has olvidado tu contraseña?";
            // 
            // panelInfoAuxiliar
            // 
            this.panelInfoAuxiliar.Controls.Add(this.label3);
            this.panelInfoAuxiliar.Controls.Add(this.panelPopupInfo);
            this.panelInfoAuxiliar.Location = new System.Drawing.Point(0, 64);
            this.panelInfoAuxiliar.Name = "panelInfoAuxiliar";
            this.panelInfoAuxiliar.Size = new System.Drawing.Size(882, 526);
            this.panelInfoAuxiliar.TabIndex = 15;
            this.panelInfoAuxiliar.Click += new System.EventHandler(this.panelInfoAuxiliar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(194, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "(Haz click en la pantalla para continuar)";
            // 
            // panelPopupInfo
            // 
            this.panelPopupInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(231)))), ((int)(((byte)(183)))));
            this.panelPopupInfo.Controls.Add(this.labelErrorOkInfo);
            this.panelPopupInfo.Controls.Add(this.imagenErrorOk);
            this.panelPopupInfo.Location = new System.Drawing.Point(154, 171);
            this.panelPopupInfo.Name = "panelPopupInfo";
            this.panelPopupInfo.Size = new System.Drawing.Size(601, 80);
            this.panelPopupInfo.TabIndex = 17;
            this.panelPopupInfo.Click += new System.EventHandler(this.panelInfoAuxiliar_Click);
            // 
            // labelErrorOkInfo
            // 
            this.labelErrorOkInfo.AutoSize = true;
            this.labelErrorOkInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorOkInfo.Location = new System.Drawing.Point(77, 28);
            this.labelErrorOkInfo.Name = "labelErrorOkInfo";
            this.labelErrorOkInfo.Size = new System.Drawing.Size(498, 25);
            this.labelErrorOkInfo.TabIndex = 1;
            this.labelErrorOkInfo.Text = "No exites ninguna cuenta con ese correo asociado";
            // 
            // imagenErrorOk
            // 
            this.imagenErrorOk.BackgroundImage = global::GHub.Properties.Resources.ok;
            this.imagenErrorOk.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenErrorOk.Location = new System.Drawing.Point(19, 14);
            this.imagenErrorOk.Name = "imagenErrorOk";
            this.imagenErrorOk.Size = new System.Drawing.Size(41, 56);
            this.imagenErrorOk.TabIndex = 0;
            this.imagenErrorOk.TabStop = false;
            // 
            // labelErrorCampos
            // 
            this.labelErrorCampos.AutoSize = true;
            this.labelErrorCampos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelErrorCampos.ForeColor = System.Drawing.Color.Red;
            this.labelErrorCampos.Location = new System.Drawing.Point(306, 321);
            this.labelErrorCampos.Name = "labelErrorCampos";
            this.labelErrorCampos.Size = new System.Drawing.Size(290, 16);
            this.labelErrorCampos.TabIndex = 16;
            this.labelErrorCampos.Text = "Error, asegurate de introducir todos los campos";
            this.labelErrorCampos.Visible = false;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 589);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.panelInfoAuxiliar);
            this.Controls.Add(this.panelReestablecerPass);
            this.Controls.Add(this.panelLogin);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenPerfil)).EndInit();
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenSteam)).EndInit();
            this.panelReestablecerPass.ResumeLayout(false);
            this.panelReestablecerPass.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenAtras)).EndInit();
            this.panelInfoAuxiliar.ResumeLayout(false);
            this.panelInfoAuxiliar.PerformLayout();
            this.panelPopupInfo.ResumeLayout(false);
            this.panelPopupInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenErrorOk)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.PictureBox imagenPerfil;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxUser;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxPass;
        private MaterialSkin.Controls.MaterialCheckBox chkRecordarcredenciales;
        private MaterialSkin.Controls.MaterialRaisedButton btnLogin;
        private System.Windows.Forms.Label labelRegistrarse;
        private System.Windows.Forms.Label labelOlvido;
        private System.Windows.Forms.Panel panelRegistro;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxNuevoEmail;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxRepetirPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxNuevaPass;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxNuevoUsuario;
        private System.Windows.Forms.Label labelYaTengoCuenta;
        private System.Windows.Forms.PictureBox imagenSteam;
        private System.Windows.Forms.LinkLabel linkSteamId;
        private System.Windows.Forms.LinkLabel linkClaveSteam;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxNuevoSteamID;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxNuevaClave;
        private MaterialSkin.Controls.MaterialRaisedButton btnCrearUsuario;
        private System.Windows.Forms.Panel panelReestablecerPass;
        private MaterialSkin.Controls.MaterialRaisedButton btnEnviarEmailRecuperar;
        private MaterialSkin.Controls.MaterialSingleLineTextField textboxEnviarCredenciales;
        private System.Windows.Forms.Label labelLeyendaCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox imagenAtras;
        private System.Windows.Forms.Panel panelInfoAuxiliar;
        private System.Windows.Forms.Panel panelPopupInfo;
        private System.Windows.Forms.PictureBox imagenErrorOk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelErrorOkInfo;
        private System.Windows.Forms.Label labelErrorCampos;
    }
}

