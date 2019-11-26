namespace GHub
{
    partial class FormSockets
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSockets));
            this.textboxInfoServerSockets = new System.Windows.Forms.TextBox();
            this.labelIpServer = new System.Windows.Forms.Label();
            this.labelPuertoServer = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStartServer = new System.Windows.Forms.Button();
            this.btnStopServer = new System.Windows.Forms.Button();
            this.btnCopiarIp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textboxInfoServerSockets
            // 
            this.textboxInfoServerSockets.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textboxInfoServerSockets.Location = new System.Drawing.Point(0, 127);
            this.textboxInfoServerSockets.Multiline = true;
            this.textboxInfoServerSockets.Name = "textboxInfoServerSockets";
            this.textboxInfoServerSockets.ReadOnly = true;
            this.textboxInfoServerSockets.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textboxInfoServerSockets.Size = new System.Drawing.Size(381, 328);
            this.textboxInfoServerSockets.TabIndex = 4;
            // 
            // labelIpServer
            // 
            this.labelIpServer.AutoSize = true;
            this.labelIpServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIpServer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelIpServer.Location = new System.Drawing.Point(64, 73);
            this.labelIpServer.Name = "labelIpServer";
            this.labelIpServer.Size = new System.Drawing.Size(68, 16);
            this.labelIpServer.TabIndex = 12;
            this.labelIpServer.Text = "127.0.0.7";
            // 
            // labelPuertoServer
            // 
            this.labelPuertoServer.AutoSize = true;
            this.labelPuertoServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoServer.Location = new System.Drawing.Point(64, 95);
            this.labelPuertoServer.Name = "labelPuertoServer";
            this.labelPuertoServer.Size = new System.Drawing.Size(48, 16);
            this.labelPuertoServer.TabIndex = 11;
            this.labelPuertoServer.Text = "31416";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Puerto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "IP:";
            // 
            // btnStartServer
            // 
            this.btnStartServer.Location = new System.Drawing.Point(235, 71);
            this.btnStartServer.Name = "btnStartServer";
            this.btnStartServer.Size = new System.Drawing.Size(134, 23);
            this.btnStartServer.TabIndex = 13;
            this.btnStartServer.Text = "ENCENDER";
            this.btnStartServer.UseVisualStyleBackColor = true;
            this.btnStartServer.Click += new System.EventHandler(this.btnStartServer_Click);
            // 
            // btnStopServer
            // 
            this.btnStopServer.Enabled = false;
            this.btnStopServer.Location = new System.Drawing.Point(235, 97);
            this.btnStopServer.Name = "btnStopServer";
            this.btnStopServer.Size = new System.Drawing.Size(134, 23);
            this.btnStopServer.TabIndex = 14;
            this.btnStopServer.Text = "APAGAR";
            this.btnStopServer.UseVisualStyleBackColor = true;
            this.btnStopServer.Click += new System.EventHandler(this.btnStopServer_Click);
            // 
            // btnCopiarIp
            // 
            this.btnCopiarIp.BackColor = System.Drawing.Color.Transparent;
            this.btnCopiarIp.BackgroundImage = global::GHub.Properties.Resources.copiar;
            this.btnCopiarIp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCopiarIp.Location = new System.Drawing.Point(156, 71);
            this.btnCopiarIp.Name = "btnCopiarIp";
            this.btnCopiarIp.Size = new System.Drawing.Size(48, 49);
            this.btnCopiarIp.TabIndex = 15;
            this.btnCopiarIp.UseVisualStyleBackColor = false;
            this.btnCopiarIp.Click += new System.EventHandler(this.btnCopiarIp_Click);
            // 
            // FormSockets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 455);
            this.Controls.Add(this.btnCopiarIp);
            this.Controls.Add(this.btnStopServer);
            this.Controls.Add(this.btnStartServer);
            this.Controls.Add(this.labelIpServer);
            this.Controls.Add(this.labelPuertoServer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textboxInfoServerSockets);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSockets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FormSockets_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textboxInfoServerSockets;
        private System.Windows.Forms.Label labelIpServer;
        private System.Windows.Forms.Label labelPuertoServer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStartServer;
        private System.Windows.Forms.Button btnStopServer;
        private System.Windows.Forms.Button btnCopiarIp;
    }
}