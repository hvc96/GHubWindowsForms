namespace Cliente
{
    partial class FormCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCliente));
            this.label1 = new System.Windows.Forms.Label();
            this.txtboxPreguntaServer = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.txtboxDataServer = new System.Windows.Forms.TextBox();
            this.btnConsultarServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "¿Que juego desea consultar para saber si le pertenece?";
            // 
            // txtboxPreguntaServer
            // 
            this.txtboxPreguntaServer.Depth = 0;
            this.txtboxPreguntaServer.Hint = "Nombre del juego a consultar";
            this.txtboxPreguntaServer.Location = new System.Drawing.Point(23, 117);
            this.txtboxPreguntaServer.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtboxPreguntaServer.Name = "txtboxPreguntaServer";
            this.txtboxPreguntaServer.PasswordChar = '\0';
            this.txtboxPreguntaServer.SelectedText = "";
            this.txtboxPreguntaServer.SelectionLength = 0;
            this.txtboxPreguntaServer.SelectionStart = 0;
            this.txtboxPreguntaServer.Size = new System.Drawing.Size(263, 23);
            this.txtboxPreguntaServer.TabIndex = 1;
            this.txtboxPreguntaServer.UseSystemPasswordChar = false;
            // 
            // txtboxDataServer
            // 
            this.txtboxDataServer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtboxDataServer.Location = new System.Drawing.Point(0, 167);
            this.txtboxDataServer.Multiline = true;
            this.txtboxDataServer.Name = "txtboxDataServer";
            this.txtboxDataServer.ReadOnly = true;
            this.txtboxDataServer.Size = new System.Drawing.Size(409, 334);
            this.txtboxDataServer.TabIndex = 2;
            // 
            // btnConsultarServer
            // 
            this.btnConsultarServer.Location = new System.Drawing.Point(292, 117);
            this.btnConsultarServer.Name = "btnConsultarServer";
            this.btnConsultarServer.Size = new System.Drawing.Size(96, 23);
            this.btnConsultarServer.TabIndex = 3;
            this.btnConsultarServer.Text = "Consultar";
            this.btnConsultarServer.UseVisualStyleBackColor = true;
            this.btnConsultarServer.Click += new System.EventHandler(this.btnConsultarServer_Click);
            // 
            // FormCliente
            // 
            this.AcceptButton = this.btnConsultarServer;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 501);
            this.Controls.Add(this.btnConsultarServer);
            this.Controls.Add(this.txtboxDataServer);
            this.Controls.Add(this.txtboxPreguntaServer);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtboxPreguntaServer;
        private System.Windows.Forms.TextBox txtboxDataServer;
        private System.Windows.Forms.Button btnConsultarServer;
    }
}

