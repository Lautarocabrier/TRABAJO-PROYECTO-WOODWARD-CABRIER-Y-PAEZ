namespace UI
{
    partial class frmNewUser
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCrearAlumnos = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.btnCloseNU = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvNU = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PayNU = new System.Windows.Forms.ComboBox();
            this.btnCancelNU = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.DNINU = new System.Windows.Forms.TextBox();
            this.GmailNU = new System.Windows.Forms.TextBox();
            this.btnSaveNU = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.ActivitiesNU = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DNISearchNU = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeNU = new System.Windows.Forms.TextBox();
            this.Puesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NameNU = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEliminateNU = new System.Windows.Forms.Button();
            this.btnSaveEditNU = new System.Windows.Forms.Button();
            this.btnSearchNU = new System.Windows.Forms.Button();
            this.panelCrearAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNU)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 10);
            this.panel2.TabIndex = 9;
            // 
            // panelCrearAlumnos
            // 
            this.panelCrearAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCrearAlumnos.Controls.Add(this.label11);
            this.panelCrearAlumnos.Controls.Add(this.btnCloseNU);
            this.panelCrearAlumnos.Controls.Add(this.panel1);
            this.panelCrearAlumnos.Controls.Add(this.groupBox1);
            this.panelCrearAlumnos.Location = new System.Drawing.Point(20, 27);
            this.panelCrearAlumnos.Margin = new System.Windows.Forms.Padding(9);
            this.panelCrearAlumnos.Name = "panelCrearAlumnos";
            this.panelCrearAlumnos.Size = new System.Drawing.Size(937, 627);
            this.panelCrearAlumnos.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(907, 539);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 32);
            this.label11.TabIndex = 67;
            this.label11.Text = "\r\n      ";
            // 
            // btnCloseNU
            // 
            this.btnCloseNU.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseNU.FlatAppearance.BorderSize = 0;
            this.btnCloseNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCloseNU.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseNU.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseNU.Location = new System.Drawing.Point(856, 576);
            this.btnCloseNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseNU.Name = "btnCloseNU";
            this.btnCloseNU.Size = new System.Drawing.Size(65, 35);
            this.btnCloseNU.TabIndex = 45;
            this.btnCloseNU.Text = "Salir";
            this.btnCloseNU.UseVisualStyleBackColor = false;
            this.btnCloseNU.Click += new System.EventHandler(this.btnCloseNU_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.dgvNU);
            this.panel1.Controls.Add(this.btnEliminateNU);
            this.panel1.Controls.Add(this.btnSaveEditNU);
            this.panel1.Location = new System.Drawing.Point(56, 370);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(786, 238);
            this.panel1.TabIndex = 52;
            // 
            // dgvNU
            // 
            this.dgvNU.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvNU.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNU.Location = new System.Drawing.Point(41, 29);
            this.dgvNU.Name = "dgvNU";
            this.dgvNU.RowHeadersWidth = 51;
            this.dgvNU.Size = new System.Drawing.Size(551, 187);
            this.dgvNU.TabIndex = 39;
            this.dgvNU.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNU_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.PayNU);
            this.groupBox1.Controls.Add(this.btnCancelNU);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.DNINU);
            this.groupBox1.Controls.Add(this.GmailNU);
            this.groupBox1.Controls.Add(this.btnSaveNU);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ActivitiesNU);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.DNISearchNU);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AgeNU);
            this.groupBox1.Controls.Add(this.btnSearchNU);
            this.groupBox1.Controls.Add(this.Puesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.NameNU);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(19, 16);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(900, 346);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.SteelBlue;
            this.label9.Location = new System.Drawing.Point(33, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(157, 22);
            this.label9.TabIndex = 63;
            this.label9.Text = "Edicion de datos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(9, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 4);
            this.label7.TabIndex = 62;
            this.label7.Text = "                                                                                 " +
    "                                      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PayNU
            // 
            this.PayNU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayNU.FormattingEnabled = true;
            this.PayNU.Items.AddRange(new object[] {
            "Cursando",
            "Finalizado "});
            this.PayNU.Location = new System.Drawing.Point(534, 229);
            this.PayNU.Margin = new System.Windows.Forms.Padding(4);
            this.PayNU.Name = "PayNU";
            this.PayNU.Size = new System.Drawing.Size(211, 29);
            this.PayNU.TabIndex = 58;
            this.PayNU.SelectedIndexChanged += new System.EventHandler(this.PayNU_SelectedIndexChanged);
            // 
            // btnCancelNU
            // 
            this.btnCancelNU.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelNU.FlatAppearance.BorderSize = 0;
            this.btnCancelNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelNU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelNU.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelNU.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelNU.Location = new System.Drawing.Point(761, 164);
            this.btnCancelNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelNU.Name = "btnCancelNU";
            this.btnCancelNU.Size = new System.Drawing.Size(108, 37);
            this.btnCancelNU.TabIndex = 40;
            this.btnCancelNU.Text = "Cancelar";
            this.btnCancelNU.UseVisualStyleBackColor = false;
            this.btnCancelNU.Click += new System.EventHandler(this.btnCancelNU_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 20);
            this.label6.TabIndex = 57;
            this.label6.Text = "Pago";
            // 
            // DNINU
            // 
            this.DNINU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.DNINU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DNINU.Location = new System.Drawing.Point(534, 152);
            this.DNINU.Margin = new System.Windows.Forms.Padding(4);
            this.DNINU.Name = "DNINU";
            this.DNINU.Size = new System.Drawing.Size(166, 27);
            this.DNINU.TabIndex = 56;
            this.DNINU.TextChanged += new System.EventHandler(this.DNINU_TextChanged);
            // 
            // GmailNU
            // 
            this.GmailNU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.GmailNU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GmailNU.Location = new System.Drawing.Point(277, 152);
            this.GmailNU.Margin = new System.Windows.Forms.Padding(4);
            this.GmailNU.Name = "GmailNU";
            this.GmailNU.Size = new System.Drawing.Size(203, 27);
            this.GmailNU.TabIndex = 55;
            this.GmailNU.TextChanged += new System.EventHandler(this.GmailNU_TextChanged);
            // 
            // btnSaveNU
            // 
            this.btnSaveNU.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveNU.FlatAppearance.BorderColor = System.Drawing.Color.SteelBlue;
            this.btnSaveNU.FlatAppearance.BorderSize = 0;
            this.btnSaveNU.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveNU.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveNU.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSaveNU.Location = new System.Drawing.Point(545, 299);
            this.btnSaveNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveNU.Name = "btnSaveNU";
            this.btnSaveNU.Size = new System.Drawing.Size(244, 37);
            this.btnSaveNU.TabIndex = 48;
            this.btnSaveNU.Text = "Guardar nuevo usuario";
            this.btnSaveNU.UseVisualStyleBackColor = false;
            this.btnSaveNU.Click += new System.EventHandler(this.btnSaveNU_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "DNI";
            // 
            // ActivitiesNU
            // 
            this.ActivitiesNU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActivitiesNU.FormattingEnabled = true;
            this.ActivitiesNU.Items.AddRange(new object[] {
            "Cursando",
            "Finalizado "});
            this.ActivitiesNU.Location = new System.Drawing.Point(277, 229);
            this.ActivitiesNU.Margin = new System.Windows.Forms.Padding(4);
            this.ActivitiesNU.Name = "ActivitiesNU";
            this.ActivitiesNU.Size = new System.Drawing.Size(211, 29);
            this.ActivitiesNU.TabIndex = 53;
            this.ActivitiesNU.SelectedIndexChanged += new System.EventHandler(this.ActivitiesNU_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 52;
            this.label4.Text = "Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "DNI:";
            // 
            // DNISearchNU
            // 
            this.DNISearchNU.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.DNISearchNU.Location = new System.Drawing.Point(287, 40);
            this.DNISearchNU.Margin = new System.Windows.Forms.Padding(5);
            this.DNISearchNU.Name = "DNISearchNU";
            this.DNISearchNU.Size = new System.Drawing.Size(398, 23);
            this.DNISearchNU.TabIndex = 12;
            this.DNISearchNU.TextChanged += new System.EventHandler(this.DNISearchNU_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 48;
            this.label3.Text = "Gmail";
            // 
            // AgeNU
            // 
            this.AgeNU.Location = new System.Drawing.Point(16, 229);
            this.AgeNU.Name = "AgeNU";
            this.AgeNU.Size = new System.Drawing.Size(203, 27);
            this.AgeNU.TabIndex = 50;
            this.AgeNU.TextChanged += new System.EventHandler(this.AgeNU_TextChanged);
            // 
            // Puesto
            // 
            this.Puesto.AutoSize = true;
            this.Puesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puesto.Location = new System.Drawing.Point(30, 201);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(47, 20);
            this.Puesto.TabIndex = 49;
            this.Puesto.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre y Apellido";
            // 
            // NameNU
            // 
            this.NameNU.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.NameNU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameNU.Location = new System.Drawing.Point(16, 152);
            this.NameNU.Margin = new System.Windows.Forms.Padding(4);
            this.NameNU.Name = "NameNU";
            this.NameNU.Size = new System.Drawing.Size(203, 27);
            this.NameNU.TabIndex = 45;
            this.NameNU.TextChanged += new System.EventHandler(this.NameNU_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Image = global::UI.Properties.Resources.rayo_con_mancuernas__3_;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label8.Location = new System.Drawing.Point(862, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 42);
            this.label8.TabIndex = 69;
            this.label8.Text = "\r\n      ";
            // 
            // btnEliminateNU
            // 
            this.btnEliminateNU.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEliminateNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminateNU.FlatAppearance.BorderSize = 0;
            this.btnEliminateNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminateNU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateNU.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminateNU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminateNU.Image = global::UI.Properties.Resources.basura1;
            this.btnEliminateNU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminateNU.Location = new System.Drawing.Point(631, 65);
            this.btnEliminateNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminateNU.Name = "btnEliminateNU";
            this.btnEliminateNU.Size = new System.Drawing.Size(135, 37);
            this.btnEliminateNU.TabIndex = 43;
            this.btnEliminateNU.Text = "   Eliminar";
            this.btnEliminateNU.UseVisualStyleBackColor = false;
            this.btnEliminateNU.Click += new System.EventHandler(this.btnEliminateNU_Click);
            // 
            // btnSaveEditNU
            // 
            this.btnSaveEditNU.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSaveEditNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditNU.FlatAppearance.BorderSize = 0;
            this.btnSaveEditNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveEditNU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditNU.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditNU.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveEditNU.Image = global::UI.Properties.Resources.disco1;
            this.btnSaveEditNU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEditNU.Location = new System.Drawing.Point(631, 130);
            this.btnSaveEditNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveEditNU.Name = "btnSaveEditNU";
            this.btnSaveEditNU.Size = new System.Drawing.Size(135, 37);
            this.btnSaveEditNU.TabIndex = 44;
            this.btnSaveEditNU.Text = "   Guardar";
            this.btnSaveEditNU.UseVisualStyleBackColor = false;
            this.btnSaveEditNU.Click += new System.EventHandler(this.btnSaveEditNU_Click);
            // 
            // btnSearchNU
            // 
            this.btnSearchNU.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchNU.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNU.FlatAppearance.BorderSize = 0;
            this.btnSearchNU.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchNU.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchNU.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNU.Image = global::UI.Properties.Resources.busqueda;
            this.btnSearchNU.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchNU.Location = new System.Drawing.Point(727, 38);
            this.btnSearchNU.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchNU.Name = "btnSearchNU";
            this.btnSearchNU.Size = new System.Drawing.Size(127, 29);
            this.btnSearchNU.TabIndex = 10;
            this.btnSearchNU.Text = "Buscar";
            this.btnSearchNU.UseVisualStyleBackColor = false;
            this.btnSearchNU.Click += new System.EventHandler(this.btnSearchNU_Click);
            // 
            // frmNewUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCrearAlumnos);
            this.Name = "frmNewUser";
            this.Text = "frmNewUser";
            this.panelCrearAlumnos.ResumeLayout(false);
            this.panelCrearAlumnos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNU)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelCrearAlumnos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnCloseNU;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvNU;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox PayNU;
        private System.Windows.Forms.Button btnCancelNU;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DNINU;
        private System.Windows.Forms.TextBox GmailNU;
        private System.Windows.Forms.Button btnSaveNU;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ActivitiesNU;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DNISearchNU;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeNU;
        private System.Windows.Forms.Button btnSearchNU;
        private System.Windows.Forms.Label Puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameNU;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnEliminateNU;
        private System.Windows.Forms.Button btnSaveEditNU;
    }
}