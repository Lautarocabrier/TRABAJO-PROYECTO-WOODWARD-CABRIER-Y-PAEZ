namespace UI
{
    partial class frmAccess
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccess));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.panelCrearAlumnos = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.btnCloseAccess = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelAccess = new System.Windows.Forms.Button();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnMarckAccess = new System.Windows.Forms.Button();
            this.btnSearchAccess = new System.Windows.Forms.Button();
            this.txtDNIMarkAccess = new System.Windows.Forms.TextBox();
            this.btnUserNew = new System.Windows.Forms.Button();
            this.btnEditAccess_click = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelCrearAlumnos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.label11);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 41);
            this.panel1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Image = global::UI.Properties.Resources.rayo_con_mancuernas__3_;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(932, 9);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 32);
            this.label11.TabIndex = 68;
            this.label11.Text = "\r\n      ";
            // 
            // panelCrearAlumnos
            // 
            this.panelCrearAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCrearAlumnos.Controls.Add(this.label8);
            this.panelCrearAlumnos.Controls.Add(this.btnCloseAccess);
            this.panelCrearAlumnos.Controls.Add(this.label5);
            this.panelCrearAlumnos.Controls.Add(this.btnCancelAccess);
            this.panelCrearAlumnos.Controls.Add(this.dgvDocentes);
            this.panelCrearAlumnos.Controls.Add(this.groupBox1);
            this.panelCrearAlumnos.Controls.Add(this.btnUserNew);
            this.panelCrearAlumnos.Controls.Add(this.btnEditAccess_click);
            this.panelCrearAlumnos.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelCrearAlumnos.Location = new System.Drawing.Point(19, 62);
            this.panelCrearAlumnos.Margin = new System.Windows.Forms.Padding(9, 9, 9, 9);
            this.panelCrearAlumnos.Name = "panelCrearAlumnos";
            this.panelCrearAlumnos.Size = new System.Drawing.Size(939, 592);
            this.panelCrearAlumnos.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Crimson;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label8.Location = new System.Drawing.Point(19, 21);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 4);
            this.label8.TabIndex = 64;
            this.label8.Text = "                                                                                 " +
    "                                      ";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCloseAccess
            // 
            this.btnCloseAccess.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseAccess.FlatAppearance.BorderSize = 0;
            this.btnCloseAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCloseAccess.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseAccess.Location = new System.Drawing.Point(859, 545);
            this.btnCloseAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCloseAccess.Name = "btnCloseAccess";
            this.btnCloseAccess.Size = new System.Drawing.Size(65, 34);
            this.btnCloseAccess.TabIndex = 30;
            this.btnCloseAccess.Text = "Salir";
            this.btnCloseAccess.UseVisualStyleBackColor = false;
            this.btnCloseAccess.Click += new System.EventHandler(this.btnCloseAccess_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SteelBlue;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 1.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label5.Location = new System.Drawing.Point(109, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(442, 2);
            this.label5.TabIndex = 55;
            this.label5.Text = resources.GetString("label5.Text");
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btnCancelAccess
            // 
            this.btnCancelAccess.BackColor = System.Drawing.Color.SteelBlue;
            this.btnCancelAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelAccess.FlatAppearance.BorderSize = 0;
            this.btnCancelAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCancelAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelAccess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAccess.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancelAccess.Image = global::UI.Properties.Resources.cruz__2_;
            this.btnCancelAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelAccess.Location = new System.Drawing.Point(789, 432);
            this.btnCancelAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnCancelAccess.Name = "btnCancelAccess";
            this.btnCancelAccess.Size = new System.Drawing.Size(117, 37);
            this.btnCancelAccess.TabIndex = 40;
            this.btnCancelAccess.Text = "   Cancelar";
            this.btnCancelAccess.UseVisualStyleBackColor = false;
            this.btnCancelAccess.Click += new System.EventHandler(this.btnCancelAccess_Click);
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Location = new System.Drawing.Point(36, 273);
            this.dgvDocentes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.RowHeadersWidth = 51;
            this.dgvDocentes.Size = new System.Drawing.Size(731, 295);
            this.dgvDocentes.TabIndex = 39;
            this.dgvDocentes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccess_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.btnMarckAccess);
            this.groupBox1.Controls.Add(this.btnSearchAccess);
            this.groupBox1.Controls.Add(this.txtDNIMarkAccess);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(20, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.groupBox1.Size = new System.Drawing.Size(888, 153);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SteelBlue;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label6.Location = new System.Drawing.Point(205, -5);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 4);
            this.label6.TabIndex = 63;
            this.label6.Text = "                                                                                 " +
    "                                      ";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(218, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "DNI:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.SteelBlue;
            this.label7.Location = new System.Drawing.Point(36, 0);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(181, 22);
            this.label7.TabIndex = 62;
            this.label7.Text = "Listado de accesos";
            // 
            // btnMarckAccess
            // 
            this.btnMarckAccess.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnMarckAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMarckAccess.FlatAppearance.BorderSize = 0;
            this.btnMarckAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnMarckAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarckAccess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMarckAccess.Location = new System.Drawing.Point(592, 97);
            this.btnMarckAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnMarckAccess.Name = "btnMarckAccess";
            this.btnMarckAccess.Size = new System.Drawing.Size(172, 30);
            this.btnMarckAccess.TabIndex = 11;
            this.btnMarckAccess.Text = "Marcar acceso";
            this.btnMarckAccess.UseVisualStyleBackColor = false;
            this.btnMarckAccess.Click += new System.EventHandler(this.btnMarckAccess_Click);
            // 
            // btnSearchAccess
            // 
            this.btnSearchAccess.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSearchAccess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchAccess.FlatAppearance.BorderSize = 0;
            this.btnSearchAccess.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSearchAccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchAccess.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAccess.Image = global::UI.Properties.Resources.busqueda;
            this.btnSearchAccess.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearchAccess.Location = new System.Drawing.Point(609, 43);
            this.btnSearchAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnSearchAccess.Name = "btnSearchAccess";
            this.btnSearchAccess.Size = new System.Drawing.Size(127, 30);
            this.btnSearchAccess.TabIndex = 10;
            this.btnSearchAccess.Text = "Buscar";
            this.btnSearchAccess.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearchAccess.UseVisualStyleBackColor = false;
            this.btnSearchAccess.Click += new System.EventHandler(this.btnSearchAccess_Click);
            // 
            // txtDNIMarkAccess
            // 
            this.txtDNIMarkAccess.Location = new System.Drawing.Point(278, 74);
            this.txtDNIMarkAccess.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.txtDNIMarkAccess.Name = "txtDNIMarkAccess";
            this.txtDNIMarkAccess.Size = new System.Drawing.Size(253, 27);
            this.txtDNIMarkAccess.TabIndex = 5;
            this.txtDNIMarkAccess.TextChanged += new System.EventHandler(this.txtMarkAccess_TextChanged);
            // 
            // btnUserNew
            // 
            this.btnUserNew.BackColor = System.Drawing.Color.SteelBlue;
            this.btnUserNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUserNew.FlatAppearance.BorderSize = 0;
            this.btnUserNew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnUserNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserNew.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUserNew.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUserNew.Image = global::UI.Properties.Resources.agregar_usuario__1_;
            this.btnUserNew.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserNew.Location = new System.Drawing.Point(629, 209);
            this.btnUserNew.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnUserNew.Name = "btnUserNew";
            this.btnUserNew.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnUserNew.Size = new System.Drawing.Size(244, 37);
            this.btnUserNew.TabIndex = 43;
            this.btnUserNew.Text = "Nuevo Usuario";
            this.btnUserNew.UseVisualStyleBackColor = false;
            this.btnUserNew.Click += new System.EventHandler(this.btnUserNew_Click);
            // 
            // btnEditAccess_click
            // 
            this.btnEditAccess_click.BackColor = System.Drawing.Color.SteelBlue;
            this.btnEditAccess_click.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditAccess_click.FlatAppearance.BorderSize = 0;
            this.btnEditAccess_click.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditAccess_click.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditAccess_click.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditAccess_click.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEditAccess_click.Image = global::UI.Properties.Resources.editar__2_;
            this.btnEditAccess_click.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditAccess_click.Location = new System.Drawing.Point(789, 368);
            this.btnEditAccess_click.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.btnEditAccess_click.Name = "btnEditAccess_click";
            this.btnEditAccess_click.Size = new System.Drawing.Size(117, 37);
            this.btnEditAccess_click.TabIndex = 42;
            this.btnEditAccess_click.Text = "   Editar";
            this.btnEditAccess_click.UseVisualStyleBackColor = false;
            this.btnEditAccess_click.Click += new System.EventHandler(this.btnEditAccess_click_Click);
            // 
            // frmAccess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 663);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelCrearAlumnos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAccess";
            this.Text = "frmAccess";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelCrearAlumnos.ResumeLayout(false);
            this.panelCrearAlumnos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelCrearAlumnos;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCloseAccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancelAccess;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnMarckAccess;
        private System.Windows.Forms.Button btnSearchAccess;
        private System.Windows.Forms.TextBox txtDNIMarkAccess;
        private System.Windows.Forms.Button btnUserNew;
        private System.Windows.Forms.Button btnEditAccess_click;
        private System.Windows.Forms.Label label11;
    }
}