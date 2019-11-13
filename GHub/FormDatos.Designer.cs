namespace GHub
{
    partial class FormDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatos));
            this.dataGridViewPrincipal = new System.Windows.Forms.DataGridView();
            this.appid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.img_logo_url = new System.Windows.Forms.DataGridViewImageColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playtime_forever = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.link = new System.Windows.Forms.DataGridViewLinkColumn();
            this.favoritos = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.imagenBuscador = new System.Windows.Forms.PictureBox();
            this.materialSingleLineTextField1 = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.panel2 = new System.Windows.Forms.Panel();
            this.picAccesoAjustes = new System.Windows.Forms.PictureBox();
            this.picAccesoFavoritos = new System.Windows.Forms.PictureBox();
            this.picAccesoJuegos = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imagenBuscador)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoJuegos)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AllowUserToAddRows = false;
            this.dataGridViewPrincipal.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appid,
            this.img_logo_url,
            this.name,
            this.playtime_forever,
            this.link,
            this.favoritos});
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.ReadOnly = true;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(936, 531);
            this.dataGridViewPrincipal.TabIndex = 0;
            // 
            // appid
            // 
            this.appid.HeaderText = "ID";
            this.appid.Name = "appid";
            this.appid.ReadOnly = true;
            // 
            // img_logo_url
            // 
            this.img_logo_url.HeaderText = "Logo";
            this.img_logo_url.Name = "img_logo_url";
            this.img_logo_url.ReadOnly = true;
            this.img_logo_url.Width = 150;
            // 
            // name
            // 
            this.name.HeaderText = "Nombre";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.Width = 250;
            // 
            // playtime_forever
            // 
            this.playtime_forever.HeaderText = "Horas jugadas";
            this.playtime_forever.Name = "playtime_forever";
            this.playtime_forever.ReadOnly = true;
            // 
            // link
            // 
            this.link.HeaderText = "Enlace compra";
            this.link.Name = "link";
            this.link.ReadOnly = true;
            this.link.Width = 273;
            // 
            // favoritos
            // 
            this.favoritos.HeaderText = "♥";
            this.favoritos.Name = "favoritos";
            this.favoritos.ReadOnly = true;
            this.favoritos.Width = 20;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1486503759-book-bookmark-education-school-favorite-mark_81266.png");
            this.imageList1.Images.SetKeyName(1, "gamecontroller_23912.png");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.imagenBuscador);
            this.panel1.Controls.Add(this.materialSingleLineTextField1);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 2;
            // 
            // imagenBuscador
            // 
            this.imagenBuscador.BackgroundImage = global::GHub.Properties.Resources.go;
            this.imagenBuscador.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.imagenBuscador.Location = new System.Drawing.Point(954, 10);
            this.imagenBuscador.Name = "imagenBuscador";
            this.imagenBuscador.Size = new System.Drawing.Size(34, 34);
            this.imagenBuscador.TabIndex = 2;
            this.imagenBuscador.TabStop = false;
            this.imagenBuscador.Click += new System.EventHandler(this.imagenBuscador_Click);
            // 
            // materialSingleLineTextField1
            // 
            this.materialSingleLineTextField1.Depth = 0;
            this.materialSingleLineTextField1.Hint = "Buscar en la base de datos";
            this.materialSingleLineTextField1.Location = new System.Drawing.Point(67, 14);
            this.materialSingleLineTextField1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialSingleLineTextField1.Name = "materialSingleLineTextField1";
            this.materialSingleLineTextField1.PasswordChar = '\0';
            this.materialSingleLineTextField1.SelectedText = "";
            this.materialSingleLineTextField1.SelectionLength = 0;
            this.materialSingleLineTextField1.SelectionStart = 0;
            this.materialSingleLineTextField1.Size = new System.Drawing.Size(859, 23);
            this.materialSingleLineTextField1.TabIndex = 0;
            this.materialSingleLineTextField1.UseSystemPasswordChar = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.picAccesoAjustes);
            this.panel2.Controls.Add(this.picAccesoFavoritos);
            this.panel2.Controls.Add(this.picAccesoJuegos);
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 537);
            this.panel2.TabIndex = 3;
            // 
            // picAccesoAjustes
            // 
            this.picAccesoAjustes.BackgroundImage = global::GHub.Properties.Resources.code;
            this.picAccesoAjustes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picAccesoAjustes.Location = new System.Drawing.Point(5, 481);
            this.picAccesoAjustes.Name = "picAccesoAjustes";
            this.picAccesoAjustes.Size = new System.Drawing.Size(50, 50);
            this.picAccesoAjustes.TabIndex = 3;
            this.picAccesoAjustes.TabStop = false;
            // 
            // picAccesoFavoritos
            // 
            this.picAccesoFavoritos.BackgroundImage = global::GHub.Properties.Resources.lazo;
            this.picAccesoFavoritos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAccesoFavoritos.Location = new System.Drawing.Point(9, 80);
            this.picAccesoFavoritos.Name = "picAccesoFavoritos";
            this.picAccesoFavoritos.Size = new System.Drawing.Size(40, 40);
            this.picAccesoFavoritos.TabIndex = 1;
            this.picAccesoFavoritos.TabStop = false;
            // 
            // picAccesoJuegos
            // 
            this.picAccesoJuegos.BackgroundImage = global::GHub.Properties.Resources.alien;
            this.picAccesoJuegos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picAccesoJuegos.Location = new System.Drawing.Point(9, 16);
            this.picAccesoJuegos.Name = "picAccesoJuegos";
            this.picAccesoJuegos.Size = new System.Drawing.Size(40, 40);
            this.picAccesoJuegos.TabIndex = 0;
            this.picAccesoJuegos.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dataGridViewPrincipal);
            this.panel3.Location = new System.Drawing.Point(61, 114);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 537);
            this.panel3.TabIndex = 4;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormDatos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imagenBuscador)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoJuegos)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox imagenBuscador;
        private MaterialSkin.Controls.MaterialSingleLineTextField materialSingleLineTextField1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appid;
        private System.Windows.Forms.DataGridViewImageColumn img_logo_url;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn playtime_forever;
        private System.Windows.Forms.DataGridViewLinkColumn link;
        private System.Windows.Forms.DataGridViewCheckBoxColumn favoritos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAccesoAjustes;
        private System.Windows.Forms.PictureBox picAccesoFavoritos;
        private System.Windows.Forms.PictureBox picAccesoJuegos;
        private System.Windows.Forms.Panel panel3;
    }
}