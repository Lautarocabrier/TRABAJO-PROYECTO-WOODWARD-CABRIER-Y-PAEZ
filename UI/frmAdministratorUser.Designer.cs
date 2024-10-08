namespace UI
{
    partial class frmAdministratorUser
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
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelCrearAlumnos = new System.Windows.Forms.Panel();
            this.btnCloseAdm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvAdm = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PayAdm = new System.Windows.Forms.ComboBox();
            this.btnCancelAdm = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDNIAdm = new System.Windows.Forms.TextBox();
            this.btnGmailAdm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ActivitiesAdm = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDNISearchAdm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AgeAdm = new System.Windows.Forms.TextBox();
            this.Puesto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNameAdm = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnEditAdm = new System.Windows.Forms.Button();
            this.btnEliminateAdm = new System.Windows.Forms.Button();
            this.btnSaveEditAdm = new System.Windows.Forms.Button();
            this.btnSearchAdm = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panelCrearAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.SteelBlue;
            this.label8.Location = new System.Drawing.Point(12, 0);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(215, 22);
            this.label8.TabIndex = 62;
            this.label8.Text = "Administrador de datos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.label11);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(975, 40);
            this.panel2.TabIndex = 61;
            // 
            // panelCrearAlumnos
            // 
            this.panelCrearAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCrearAlumnos.Controls.Add(this.btnCloseAdm);
            this.panelCrearAlumnos.Controls.Add(this.label7);
            this.panelCrearAlumnos.Controls.Add(this.panel1);
            this.panelCrearAlumnos.Controls.Add(this.groupBox1);
            this.panelCrearAlumnos.Location = new System.Drawing.Point(20, 61);
            this.panelCrearAlumnos.Margin = new System.Windows.Forms.Padding(9);
            this.panelCrearAlumnos.Name = "panelCrearAlumnos";
            this.panelCrearAlumnos.Size = new System.Drawing.Size(937, 593);
            this.panelCrearAlumnos.TabIndex = 60;
            // 
            // btnCloseAdm
            // 
            this.btnCloseAdm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAdm.FlatAppearance.BorderSize = 0;
            this.btnCloseAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCloseAdm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseAdm.Location = new System.Drawing.Point(857, 541);
            this.btnCloseAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseAdm.Name = "btnCloseAdm";
            this.btnCloseAdm.Size = new System.Drawing.Size(65, 35);
            this.btnCloseAdm.TabIndex = 45;
            this.btnCloseAdm.Text = "Salir";
            this.btnCloseAdm.UseVisualStyleBackColor = false;
            this.btnCloseAdm.Click += new System.EventHandler(this.btnCloseAdm_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Crimson;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label7.Location = new System.Drawing.Point(4, 9);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 4);
            this.label7.TabIndex = 60;
            this.label7.Text = "                                                                                 " +
    "                                      ";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.dgvAdm);
            this.panel1.Controls.Add(this.btnEditAdm);
            this.panel1.Controls.Add(this.btnEliminateAdm);
            this.panel1.Controls.Add(this.btnSaveEditAdm);
            this.panel1.Location = new System.Drawing.Point(59, 314);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(787, 262);
            this.panel1.TabIndex = 52;
            // 
            // dgvAdm
            // 
            this.dgvAdm.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dgvAdm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdm.Location = new System.Drawing.Point(41, 29);
            this.dgvAdm.Name = "dgvAdm";
            this.dgvAdm.RowHeadersWidth = 51;
            this.dgvAdm.Size = new System.Drawing.Size(551, 202);
            this.dgvAdm.TabIndex = 39;
            this.dgvAdm.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAdm_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.PayAdm);
            this.groupBox1.Controls.Add(this.btnCancelAdm);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnDNIAdm);
            this.groupBox1.Controls.Add(this.btnGmailAdm);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ActivitiesAdm);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnDNISearchAdm);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.AgeAdm);
            this.groupBox1.Controls.Add(this.btnSearchAdm);
            this.groupBox1.Controls.Add(this.Puesto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnNameAdm);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(22, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(900, 288);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            // 
            // PayAdm
            // 
            this.PayAdm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PayAdm.FormattingEnabled = true;
            this.PayAdm.Items.AddRange(new object[] {
            "Cursando",
            "Finalizado "});
            this.PayAdm.Location = new System.Drawing.Point(534, 229);
            this.PayAdm.Margin = new System.Windows.Forms.Padding(4);
            this.PayAdm.Name = "PayAdm";
            this.PayAdm.Size = new System.Drawing.Size(211, 29);
            this.PayAdm.TabIndex = 58;
            this.PayAdm.SelectedIndexChanged += new System.EventHandler(this.PayAdm_SelectedIndexChanged);
            // 
            // btnCancelAdm
            // 
            this.btnCancelAdm.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAdm.FlatAppearance.BorderSize = 0;
            this.btnCancelAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAdm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAdm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelAdm.Location = new System.Drawing.Point(761, 164);
            this.btnCancelAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnCancelAdm.Name = "btnCancelAdm";
            this.btnCancelAdm.Size = new System.Drawing.Size(108, 37);
            this.btnCancelAdm.TabIndex = 40;
            this.btnCancelAdm.Text = "Cancelar";
            this.btnCancelAdm.UseVisualStyleBackColor = false;
            this.btnCancelAdm.Click += new System.EventHandler(this.btnCancelAdm_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(548, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Pago";
            // 
            // btnDNIAdm
            // 
            this.btnDNIAdm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDNIAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnDNIAdm.Location = new System.Drawing.Point(534, 152);
            this.btnDNIAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnDNIAdm.Name = "btnDNIAdm";
            this.btnDNIAdm.Size = new System.Drawing.Size(166, 27);
            this.btnDNIAdm.TabIndex = 56;
            this.btnDNIAdm.TextChanged += new System.EventHandler(this.DNIAdm_TextChanged);
            // 
            // btnGmailAdm
            // 
            this.btnGmailAdm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGmailAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnGmailAdm.Location = new System.Drawing.Point(277, 152);
            this.btnGmailAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnGmailAdm.Name = "btnGmailAdm";
            this.btnGmailAdm.Size = new System.Drawing.Size(203, 27);
            this.btnGmailAdm.TabIndex = 55;
            this.btnGmailAdm.TextChanged += new System.EventHandler(this.GmailAdm_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(541, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 54;
            this.label5.Text = "DNI";
            // 
            // ActivitiesAdm
            // 
            this.ActivitiesAdm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ActivitiesAdm.FormattingEnabled = true;
            this.ActivitiesAdm.Items.AddRange(new object[] {
            "Cursando",
            "Finalizado "});
            this.ActivitiesAdm.Location = new System.Drawing.Point(277, 229);
            this.ActivitiesAdm.Margin = new System.Windows.Forms.Padding(4);
            this.ActivitiesAdm.Name = "ActivitiesAdm";
            this.ActivitiesAdm.Size = new System.Drawing.Size(211, 29);
            this.ActivitiesAdm.TabIndex = 53;
            this.ActivitiesAdm.SelectedIndexChanged += new System.EventHandler(this.ActivitiesAdm_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 18);
            this.label4.TabIndex = 52;
            this.label4.Text = "Actividades";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(237, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "DNI:";
            // 
            // btnDNISearchAdm
            // 
            this.btnDNISearchAdm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btnDNISearchAdm.Location = new System.Drawing.Point(287, 40);
            this.btnDNISearchAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnDNISearchAdm.Name = "btnDNISearchAdm";
            this.btnDNISearchAdm.Size = new System.Drawing.Size(398, 23);
            this.btnDNISearchAdm.TabIndex = 12;
            this.btnDNISearchAdm.TextChanged += new System.EventHandler(this.btnDNISearchAdm_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(291, 123);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 48;
            this.label3.Text = "Gmail";
            // 
            // AgeAdm
            // 
            this.AgeAdm.Location = new System.Drawing.Point(16, 229);
            this.AgeAdm.Name = "AgeAdm";
            this.AgeAdm.Size = new System.Drawing.Size(203, 27);
            this.AgeAdm.TabIndex = 50;
            this.AgeAdm.TextChanged += new System.EventHandler(this.AgeAdm_TextChanged);
            // 
            // Puesto
            // 
            this.Puesto.AutoSize = true;
            this.Puesto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Puesto.Location = new System.Drawing.Point(30, 201);
            this.Puesto.Name = "Puesto";
            this.Puesto.Size = new System.Drawing.Size(46, 18);
            this.Puesto.TabIndex = 49;
            this.Puesto.Text = "Edad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 18);
            this.label2.TabIndex = 47;
            this.label2.Text = "Nombre y Apellido";
            // 
            // btnNameAdm
            // 
            this.btnNameAdm.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNameAdm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.btnNameAdm.Location = new System.Drawing.Point(16, 152);
            this.btnNameAdm.Margin = new System.Windows.Forms.Padding(4);
            this.btnNameAdm.Name = "btnNameAdm";
            this.btnNameAdm.Size = new System.Drawing.Size(203, 27);
            this.btnNameAdm.TabIndex = 45;
            this.btnNameAdm.TextChanged += new System.EventHandler(this.NameAdm_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = global::UI.Properties.Resources.rayo_con_mancuernas__3_;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(932, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 32);
            this.label11.TabIndex = 67;
            this.label11.Text = "\r\n      ";
            // 
            // btnEditAdm
            // 
            this.btnEditAdm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAdm.FlatAppearance.BorderSize = 0;
            this.btnEditAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAdm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditAdm.Image = global::UI.Properties.Resources.editar__1_;
            this.btnEditAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAdm.Location = new System.Drawing.Point(621, 43);
            this.btnEditAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditAdm.Name = "btnEditAdm";
            this.btnEditAdm.Size = new System.Drawing.Size(129, 37);
            this.btnEditAdm.TabIndex = 42;
            this.btnEditAdm.Text = "  Editar";
            this.btnEditAdm.UseVisualStyleBackColor = false;
            this.btnEditAdm.Click += new System.EventHandler(this.btnEditAdm_Click);
            // 
            // btnEliminateAdm
            // 
            this.btnEliminateAdm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminateAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminateAdm.FlatAppearance.BorderSize = 0;
            this.btnEliminateAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminateAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateAdm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminateAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminateAdm.Image = global::UI.Properties.Resources.basura;
            this.btnEliminateAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminateAdm.Location = new System.Drawing.Point(621, 105);
            this.btnEliminateAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminateAdm.Name = "btnEliminateAdm";
            this.btnEliminateAdm.Size = new System.Drawing.Size(129, 37);
            this.btnEliminateAdm.TabIndex = 43;
            this.btnEliminateAdm.Text = "   Eliminar";
            this.btnEliminateAdm.UseVisualStyleBackColor = false;
            this.btnEliminateAdm.Click += new System.EventHandler(this.btnEliminateAdm_Click);
            // 
            // btnSaveEditAdm
            // 
            this.btnSaveEditAdm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnSaveEditAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveEditAdm.FlatAppearance.BorderSize = 0;
            this.btnSaveEditAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSaveEditAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveEditAdm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveEditAdm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveEditAdm.Image = global::UI.Properties.Resources.disco;
            this.btnSaveEditAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSaveEditAdm.Location = new System.Drawing.Point(621, 169);
            this.btnSaveEditAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveEditAdm.Name = "btnSaveEditAdm";
            this.btnSaveEditAdm.Size = new System.Drawing.Size(129, 37);
            this.btnSaveEditAdm.TabIndex = 44;
            this.btnSaveEditAdm.Text = "    Guardar";
            this.btnSaveEditAdm.UseVisualStyleBackColor = false;
            this.btnSaveEditAdm.Click += new System.EventHandler(this.btnSaveEditAdm_Click);
            // 
            // btnSearchAdm
            // 
            this.btnSearchAdm.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchAdm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAdm.FlatAppearance.BorderSize = 0;
            this.btnSearchAdm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchAdm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAdm.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAdm.Image = global::UI.Properties.Resources.busqueda;
            this.btnSearchAdm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAdm.Location = new System.Drawing.Point(727, 38);
            this.btnSearchAdm.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearchAdm.Name = "btnSearchAdm";
            this.btnSearchAdm.Size = new System.Drawing.Size(127, 29);
            this.btnSearchAdm.TabIndex = 10;
            this.btnSearchAdm.Text = "Buscar";
            this.btnSearchAdm.UseVisualStyleBackColor = false;
            this.btnSearchAdm.Click += new System.EventHandler(this.btnSearchAdm_Click);
            // 
            // frmAdministratorUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 663);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelCrearAlumnos);
            this.Name = "frmAdministratorUser";
            this.Text = "frmAdministratorUser";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelCrearAlumnos.ResumeLayout(false);
            this.panelCrearAlumnos.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdm)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panelCrearAlumnos;
        private System.Windows.Forms.Button btnCloseAdm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvAdm;
        private System.Windows.Forms.Button btnEditAdm;
        private System.Windows.Forms.Button btnEliminateAdm;
        private System.Windows.Forms.Button btnSaveEditAdm;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox PayAdm;
        private System.Windows.Forms.Button btnCancelAdm;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox btnDNIAdm;
        private System.Windows.Forms.TextBox btnGmailAdm;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ActivitiesAdm;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox btnDNISearchAdm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox AgeAdm;
        private System.Windows.Forms.Button btnSearchAdm;
        private System.Windows.Forms.Label Puesto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox btnNameAdm;
    }
}