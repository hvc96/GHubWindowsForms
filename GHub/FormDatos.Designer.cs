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
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelTotalJuegos = new System.Windows.Forms.Label();
            this.materialDivider2 = new MaterialSkin.Controls.MaterialDivider();
            this.materialDivider1 = new MaterialSkin.Controls.MaterialDivider();
            this.label1 = new System.Windows.Forms.Label();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.picAccesoAjustes = new System.Windows.Forms.PictureBox();
            this.picAccesoFavoritos = new System.Windows.Forms.PictureBox();
            this.picAccesoJuegos = new System.Windows.Forms.PictureBox();
            this.panelJuegos = new System.Windows.Forms.Panel();
            this.labelNombreUsuario = new System.Windows.Forms.Label();
            this.panelFavoritos = new System.Windows.Forms.Panel();
            this.dataGridViewFavoritos = new System.Windows.Forms.DataGridView();
            this.fav = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoAjustes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoFavoritos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoJuegos)).BeginInit();
            this.panelJuegos.SuspendLayout();
            this.panelFavoritos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoritos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPrincipal
            // 
            this.dataGridViewPrincipal.AllowUserToAddRows = false;
            this.dataGridViewPrincipal.AllowUserToDeleteRows = false;
            this.dataGridViewPrincipal.AllowUserToOrderColumns = true;
            this.dataGridViewPrincipal.AllowUserToResizeRows = false;
            this.dataGridViewPrincipal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPrincipal.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridViewPrincipal.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPrincipal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fav});
            this.dataGridViewPrincipal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewPrincipal.Location = new System.Drawing.Point(0, 3);
            this.dataGridViewPrincipal.Name = "dataGridViewPrincipal";
            this.dataGridViewPrincipal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewPrincipal.Size = new System.Drawing.Size(936, 531);
            this.dataGridViewPrincipal.TabIndex = 0;
            this.dataGridViewPrincipal.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPrincipal_CellMouseUp);
            this.dataGridViewPrincipal.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPrincipal_CellValueChanged);
            this.dataGridViewPrincipal.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPrincipal_ColumnHeaderMouseClick);
            this.dataGridViewPrincipal.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewPrincipal_RowHeaderMouseClick);
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
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 50);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelTotalJuegos);
            this.panel2.Controls.Add(this.materialDivider2);
            this.panel2.Controls.Add(this.materialDivider1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.picGuardar);
            this.panel2.Controls.Add(this.picAccesoAjustes);
            this.panel2.Controls.Add(this.picAccesoFavoritos);
            this.panel2.Controls.Add(this.picAccesoJuegos);
            this.panel2.Location = new System.Drawing.Point(0, 114);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(61, 537);
            this.panel2.TabIndex = 3;
            // 
            // labelTotalJuegos
            // 
            this.labelTotalJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalJuegos.Location = new System.Drawing.Point(4, 326);
            this.labelTotalJuegos.Name = "labelTotalJuegos";
            this.labelTotalJuegos.Size = new System.Drawing.Size(51, 33);
            this.labelTotalJuegos.TabIndex = 8;
            this.labelTotalJuegos.Text = "9580";
            this.labelTotalJuegos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // materialDivider2
            // 
            this.materialDivider2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider2.Depth = 0;
            this.materialDivider2.Location = new System.Drawing.Point(7, 370);
            this.materialDivider2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider2.Name = "materialDivider2";
            this.materialDivider2.Size = new System.Drawing.Size(45, 2);
            this.materialDivider2.TabIndex = 7;
            this.materialDivider2.Text = "materialDivider2";
            // 
            // materialDivider1
            // 
            this.materialDivider1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialDivider1.Depth = 0;
            this.materialDivider1.Location = new System.Drawing.Point(7, 287);
            this.materialDivider1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialDivider1.Name = "materialDivider1";
            this.materialDivider1.Size = new System.Drawing.Size(45, 2);
            this.materialDivider1.TabIndex = 6;
            this.materialDivider1.Text = "materialDivider1";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(6, 292);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "TOTAL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picGuardar
            // 
            this.picGuardar.BackgroundImage = global::GHub.Properties.Resources.Save_Icon_icon_icons_com_69139;
            this.picGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picGuardar.Location = new System.Drawing.Point(9, 435);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(40, 40);
            this.picGuardar.TabIndex = 4;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
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
            this.picAccesoAjustes.Click += new System.EventHandler(this.picAccesoAjustes_Click);
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
            this.picAccesoFavoritos.Click += new System.EventHandler(this.picAccesoFavoritos_Click);
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
            this.picAccesoJuegos.Click += new System.EventHandler(this.picAccesoJuegos_Click);
            // 
            // panelJuegos
            // 
            this.panelJuegos.Controls.Add(this.dataGridViewPrincipal);
            this.panelJuegos.Location = new System.Drawing.Point(61, 114);
            this.panelJuegos.Name = "panelJuegos";
            this.panelJuegos.Size = new System.Drawing.Size(400, 537);
            this.panelJuegos.TabIndex = 4;
            // 
            // labelNombreUsuario
            // 
            this.labelNombreUsuario.BackColor = System.Drawing.Color.Transparent;
            this.labelNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombreUsuario.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelNombreUsuario.Location = new System.Drawing.Point(708, 28);
            this.labelNombreUsuario.Name = "labelNombreUsuario";
            this.labelNombreUsuario.Size = new System.Drawing.Size(268, 33);
            this.labelNombreUsuario.TabIndex = 9;
            this.labelNombreUsuario.Text = "Usuario";
            this.labelNombreUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panelFavoritos
            // 
            this.panelFavoritos.Controls.Add(this.dataGridViewFavoritos);
            this.panelFavoritos.Location = new System.Drawing.Point(467, 120);
            this.panelFavoritos.Name = "panelFavoritos";
            this.panelFavoritos.Size = new System.Drawing.Size(939, 537);
            this.panelFavoritos.TabIndex = 5;
            // 
            // dataGridViewFavoritos
            // 
            this.dataGridViewFavoritos.AllowUserToAddRows = false;
            this.dataGridViewFavoritos.AllowUserToDeleteRows = false;
            this.dataGridViewFavoritos.AllowUserToOrderColumns = true;
            this.dataGridViewFavoritos.AllowUserToResizeRows = false;
            this.dataGridViewFavoritos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFavoritos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenHorizontal;
            this.dataGridViewFavoritos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewFavoritos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFavoritos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridViewFavoritos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewFavoritos.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewFavoritos.Name = "dataGridViewFavoritos";
            this.dataGridViewFavoritos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridViewFavoritos.Size = new System.Drawing.Size(939, 537);
            this.dataGridViewFavoritos.TabIndex = 0;
            // 
            // fav
            // 
            this.fav.HeaderText = "Favorito";
            this.fav.Name = "fav";
            this.fav.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 650);
            this.Controls.Add(this.panelFavoritos);
            this.Controls.Add(this.labelNombreUsuario);
            this.Controls.Add(this.panelJuegos);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "FormDatos";
            this.Sizable = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormDatos_FormClosed);
            this.Load += new System.EventHandler(this.FormDatos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPrincipal)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoAjustes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoFavoritos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAccesoJuegos)).EndInit();
            this.panelJuegos.ResumeLayout(false);
            this.panelFavoritos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFavoritos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPrincipal;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox picAccesoAjustes;
        private System.Windows.Forms.PictureBox picAccesoFavoritos;
        private System.Windows.Forms.PictureBox picAccesoJuegos;
        private System.Windows.Forms.Panel panelJuegos;
        private System.Windows.Forms.PictureBox picGuardar;
        private System.Windows.Forms.Label labelTotalJuegos;
        private MaterialSkin.Controls.MaterialDivider materialDivider2;
        private MaterialSkin.Controls.MaterialDivider materialDivider1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombreUsuario;
        private System.Windows.Forms.Panel panelFavoritos;
        private System.Windows.Forms.DataGridView dataGridViewFavoritos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn fav;
    }
}