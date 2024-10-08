namespace UI
{
    partial class frmMainMenu
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
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelDEControles = new System.Windows.Forms.Panel();
            this.btnGmail = new System.Windows.Forms.Label();
            this.btnInstagram = new System.Windows.Forms.Label();
            this.btnWhatsapp = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.btnPromotionsMain = new System.Windows.Forms.Button();
            this.btnActivitiesMain = new System.Windows.Forms.Button();
            this.btnAdministratorUserMain = new System.Windows.Forms.Button();
            this.btnAccessMain = new System.Windows.Forms.Button();
            this.panelRelleno = new System.Windows.Forms.Panel();
            this.panelImagen = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDEControles.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panelImagen.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(259, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(993, 710);
            this.panelContainer.TabIndex = 3;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1Main_Paint);
            // 
            // panelDEControles
            // 
            this.panelDEControles.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelDEControles.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelDEControles.Controls.Add(this.btnGmail);
            this.panelDEControles.Controls.Add(this.btnInstagram);
            this.panelDEControles.Controls.Add(this.btnWhatsapp);
            this.panelDEControles.Controls.Add(this.label7);
            this.panelDEControles.Controls.Add(this.MainPanel);
            this.panelDEControles.Controls.Add(this.panelRelleno);
            this.panelDEControles.Controls.Add(this.panelImagen);
            this.panelDEControles.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDEControles.Location = new System.Drawing.Point(0, 0);
            this.panelDEControles.Name = "panelDEControles";
            this.panelDEControles.Size = new System.Drawing.Size(259, 710);
            this.panelDEControles.TabIndex = 2;
            // 
            // btnGmail
            // 
            this.btnGmail.AutoSize = true;
            this.btnGmail.Image = global::UI.Properties.Resources.sobre;
            this.btnGmail.Location = new System.Drawing.Point(158, 652);
            this.btnGmail.Name = "btnGmail";
            this.btnGmail.Size = new System.Drawing.Size(73, 48);
            this.btnGmail.TabIndex = 63;
            this.btnGmail.Text = "                      \r\n\r\n                ";
            this.btnGmail.Click += new System.EventHandler(this.btnGmail_Click);
            // 
            // btnInstagram
            // 
            this.btnInstagram.AutoSize = true;
            this.btnInstagram.Image = global::UI.Properties.Resources.instagram;
            this.btnInstagram.Location = new System.Drawing.Point(88, 652);
            this.btnInstagram.Name = "btnInstagram";
            this.btnInstagram.Size = new System.Drawing.Size(73, 48);
            this.btnInstagram.TabIndex = 64;
            this.btnInstagram.Text = "                      \r\n\r\n                ";
            this.btnInstagram.Click += new System.EventHandler(this.btnInstagram_Click);
            // 
            // btnWhatsapp
            // 
            this.btnWhatsapp.AutoSize = true;
            this.btnWhatsapp.Image = global::UI.Properties.Resources.whatsapp;
            this.btnWhatsapp.Location = new System.Drawing.Point(10, 651);
            this.btnWhatsapp.Name = "btnWhatsapp";
            this.btnWhatsapp.Size = new System.Drawing.Size(97, 48);
            this.btnWhatsapp.TabIndex = 62;
            this.btnWhatsapp.Text = "                      \r\n\r\n                              ";
            this.btnWhatsapp.Click += new System.EventHandler(this.btnWhatsapp_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(67, 647);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 4);
            this.label7.TabIndex = 61;
            this.label7.Text = "                                                                                 " +
    "                                      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MainPanel.Controls.Add(this.btnPromotionsMain);
            this.MainPanel.Controls.Add(this.btnActivitiesMain);
            this.MainPanel.Controls.Add(this.btnAdministratorUserMain);
            this.MainPanel.Controls.Add(this.btnAccessMain);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.MainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainPanel.Location = new System.Drawing.Point(0, 188);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainPanel.Size = new System.Drawing.Size(255, 298);
            this.MainPanel.TabIndex = 2;
            this.MainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.MainPanel_Paint);
            // 
            // btnPromotionsMain
            // 
            this.btnPromotionsMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnPromotionsMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPromotionsMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPromotionsMain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPromotionsMain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnPromotionsMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPromotionsMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPromotionsMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPromotionsMain.Image = global::UI.Properties.Resources.porcentaje;
            this.btnPromotionsMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPromotionsMain.Location = new System.Drawing.Point(0, 192);
            this.btnPromotionsMain.Name = "btnPromotionsMain";
            this.btnPromotionsMain.Size = new System.Drawing.Size(255, 64);
            this.btnPromotionsMain.TabIndex = 3;
            this.btnPromotionsMain.Text = "Promociones";
            this.btnPromotionsMain.UseVisualStyleBackColor = false;
            this.btnPromotionsMain.Click += new System.EventHandler(this.btnPromotionsMain_Click);
            // 
            // btnActivitiesMain
            // 
            this.btnActivitiesMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnActivitiesMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnActivitiesMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActivitiesMain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActivitiesMain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnActivitiesMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivitiesMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivitiesMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnActivitiesMain.Image = global::UI.Properties.Resources.mancuerna_horizontal__1_;
            this.btnActivitiesMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActivitiesMain.Location = new System.Drawing.Point(0, 128);
            this.btnActivitiesMain.Name = "btnActivitiesMain";
            this.btnActivitiesMain.Size = new System.Drawing.Size(255, 64);
            this.btnActivitiesMain.TabIndex = 2;
            this.btnActivitiesMain.Text = "Actividades";
            this.btnActivitiesMain.UseVisualStyleBackColor = false;
            this.btnActivitiesMain.Click += new System.EventHandler(this.btnActivitiesMain_Click);
            // 
            // btnAdministratorUserMain
            // 
            this.btnAdministratorUserMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAdministratorUserMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdministratorUserMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdministratorUserMain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdministratorUserMain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAdministratorUserMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdministratorUserMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdministratorUserMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAdministratorUserMain.Image = global::UI.Properties.Resources.adm;
            this.btnAdministratorUserMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdministratorUserMain.Location = new System.Drawing.Point(0, 64);
            this.btnAdministratorUserMain.Name = "btnAdministratorUserMain";
            this.btnAdministratorUserMain.Size = new System.Drawing.Size(255, 64);
            this.btnAdministratorUserMain.TabIndex = 1;
            this.btnAdministratorUserMain.Text = "Administrar Usuario";
            this.btnAdministratorUserMain.UseVisualStyleBackColor = false;
            this.btnAdministratorUserMain.Click += new System.EventHandler(this.btnAdministratorUserMain_Click);
            // 
            // btnAccessMain
            // 
            this.btnAccessMain.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnAccessMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccessMain.FlatAppearance.BorderColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccessMain.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccessMain.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnAccessMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccessMain.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccessMain.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnAccessMain.Image = global::UI.Properties.Resources.acceso;
            this.btnAccessMain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccessMain.Location = new System.Drawing.Point(0, 0);
            this.btnAccessMain.Name = "btnAccessMain";
            this.btnAccessMain.Size = new System.Drawing.Size(255, 64);
            this.btnAccessMain.TabIndex = 0;
            this.btnAccessMain.Text = "Acceso";
            this.btnAccessMain.UseVisualStyleBackColor = false;
            this.btnAccessMain.Click += new System.EventHandler(this.btnAccessMain_Click);
            // 
            // panelRelleno
            // 
            this.panelRelleno.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelRelleno.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelRelleno.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRelleno.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelRelleno.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelRelleno.Location = new System.Drawing.Point(0, 141);
            this.panelRelleno.Name = "panelRelleno";
            this.panelRelleno.Size = new System.Drawing.Size(255, 47);
            this.panelRelleno.TabIndex = 1;
            // 
            // panelImagen
            // 
            this.panelImagen.BackColor = System.Drawing.Color.Crimson;
            this.panelImagen.Controls.Add(this.label1);
            this.panelImagen.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelImagen.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelImagen.Location = new System.Drawing.Point(0, 0);
            this.panelImagen.Name = "panelImagen";
            this.panelImagen.Size = new System.Drawing.Size(255, 141);
            this.panelImagen.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Image = global::UI.Properties.Resources.menu;
            this.label1.Location = new System.Drawing.Point(79, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "                      \r\n\r\n\r\n\r\n                              ";
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1252, 710);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panelDEControles);
            this.Name = "frmMainMenu";
            this.Text = "Form1";
            this.panelDEControles.ResumeLayout(false);
            this.panelDEControles.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panelImagen.ResumeLayout(false);
            this.panelImagen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Panel panelDEControles;
        private System.Windows.Forms.Label btnGmail;
        private System.Windows.Forms.Label btnInstagram;
        private System.Windows.Forms.Label btnWhatsapp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button btnPromotionsMain;
        private System.Windows.Forms.Button btnActivitiesMain;
        private System.Windows.Forms.Button btnAdministratorUserMain;
        private System.Windows.Forms.Button btnAccessMain;
        private System.Windows.Forms.Panel panelRelleno;
        private System.Windows.Forms.Panel panelImagen;
        private System.Windows.Forms.Label label1;
    }
}

