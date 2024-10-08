namespace UI
{
    partial class frmPromotions
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
            this.panelCrearAlumnos = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCloseProm = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.listPromotions = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeeList = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnEditProm = new System.Windows.Forms.Button();
            this.btnEliminateProm = new System.Windows.Forms.Button();
            this.panelCrearAlumnos.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelCrearAlumnos
            // 
            this.panelCrearAlumnos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelCrearAlumnos.Controls.Add(this.label4);
            this.panelCrearAlumnos.Controls.Add(this.label11);
            this.panelCrearAlumnos.Controls.Add(this.label2);
            this.panelCrearAlumnos.Controls.Add(this.label3);
            this.panelCrearAlumnos.Controls.Add(this.btnCloseProm);
            this.panelCrearAlumnos.Controls.Add(this.panel1);
            this.panelCrearAlumnos.Controls.Add(this.groupBox1);
            this.panelCrearAlumnos.Location = new System.Drawing.Point(25, 18);
            this.panelCrearAlumnos.Margin = new System.Windows.Forms.Padding(9);
            this.panelCrearAlumnos.Name = "panelCrearAlumnos";
            this.panelCrearAlumnos.Size = new System.Drawing.Size(925, 627);
            this.panelCrearAlumnos.TabIndex = 6;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label11.Location = new System.Drawing.Point(881, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 32);
            this.label11.TabIndex = 67;
            this.label11.Text = "\r\n      ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 1.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label2.Location = new System.Drawing.Point(32, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 4);
            this.label2.TabIndex = 63;
            this.label2.Text = "                                                                                 " +
    "                                      ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.SteelBlue;
            this.label3.Location = new System.Drawing.Point(71, 39);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 22);
            this.label3.TabIndex = 62;
            this.label3.Text = "Lista de Promociones";
            // 
            // btnCloseProm
            // 
            this.btnCloseProm.BackColor = System.Drawing.Color.Crimson;
            this.btnCloseProm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseProm.FlatAppearance.BorderSize = 0;
            this.btnCloseProm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGreen;
            this.btnCloseProm.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCloseProm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCloseProm.Location = new System.Drawing.Point(855, 587);
            this.btnCloseProm.Margin = new System.Windows.Forms.Padding(5);
            this.btnCloseProm.Name = "btnCloseProm";
            this.btnCloseProm.Size = new System.Drawing.Size(65, 35);
            this.btnCloseProm.TabIndex = 29;
            this.btnCloseProm.Text = "Salir";
            this.btnCloseProm.UseVisualStyleBackColor = false;
            this.btnCloseProm.Click += new System.EventHandler(this.btnCloseProm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnEditProm);
            this.panel1.Controls.Add(this.btnEliminateProm);
            this.panel1.Controls.Add(this.listPromotions);
            this.panel1.Location = new System.Drawing.Point(53, 221);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(774, 358);
            this.panel1.TabIndex = 31;
            // 
            // listPromotions
            // 
            this.listPromotions.BackColor = System.Drawing.Color.Azure;
            this.listPromotions.FormattingEnabled = true;
            this.listPromotions.ItemHeight = 16;
            this.listPromotions.Location = new System.Drawing.Point(38, 25);
            this.listPromotions.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listPromotions.Name = "listPromotions";
            this.listPromotions.Size = new System.Drawing.Size(558, 292);
            this.listPromotions.TabIndex = 15;
            this.listPromotions.SelectedIndexChanged += new System.EventHandler(this.listPromotions_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSeeList);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Location = new System.Drawing.Point(0, 101);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(925, 77);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SteelBlue;
            this.label1.Location = new System.Drawing.Point(45, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 23);
            this.label1.TabIndex = 28;
            // 
            // btnSeeList
            // 
            this.btnSeeList.BackColor = System.Drawing.Color.Azure;
            this.btnSeeList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSeeList.FlatAppearance.BorderSize = 0;
            this.btnSeeList.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSeeList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSeeList.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeeList.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSeeList.Location = new System.Drawing.Point(719, 21);
            this.btnSeeList.Margin = new System.Windows.Forms.Padding(5);
            this.btnSeeList.Name = "btnSeeList";
            this.btnSeeList.Size = new System.Drawing.Size(108, 37);
            this.btnSeeList.TabIndex = 26;
            this.btnSeeList.Text = "Ver Lista";
            this.btnSeeList.UseVisualStyleBackColor = false;
            this.btnSeeList.Click += new System.EventHandler(this.btnSeeList_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Image = global::UI.Properties.Resources.rayo_con_mancuernas__3_;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Location = new System.Drawing.Point(881, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 32);
            this.label4.TabIndex = 69;
            this.label4.Text = "\r\n      ";
            // 
            // btnEditProm
            // 
            this.btnEditProm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEditProm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProm.FlatAppearance.BorderSize = 0;
            this.btnEditProm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEditProm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditProm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditProm.Image = global::UI.Properties.Resources.editar__1_;
            this.btnEditProm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditProm.Location = new System.Drawing.Point(622, 125);
            this.btnEditProm.Margin = new System.Windows.Forms.Padding(5);
            this.btnEditProm.Name = "btnEditProm";
            this.btnEditProm.Size = new System.Drawing.Size(129, 37);
            this.btnEditProm.TabIndex = 44;
            this.btnEditProm.Text = "  Editar";
            this.btnEditProm.UseVisualStyleBackColor = false;
            this.btnEditProm.Click += new System.EventHandler(this.btnEditProm_Click);
            // 
            // btnEliminateProm
            // 
            this.btnEliminateProm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnEliminateProm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminateProm.FlatAppearance.BorderSize = 0;
            this.btnEliminateProm.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminateProm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminateProm.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminateProm.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEliminateProm.Image = global::UI.Properties.Resources.basura;
            this.btnEliminateProm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminateProm.Location = new System.Drawing.Point(622, 187);
            this.btnEliminateProm.Margin = new System.Windows.Forms.Padding(5);
            this.btnEliminateProm.Name = "btnEliminateProm";
            this.btnEliminateProm.Size = new System.Drawing.Size(129, 37);
            this.btnEliminateProm.TabIndex = 45;
            this.btnEliminateProm.Text = "   Eliminar";
            this.btnEliminateProm.UseVisualStyleBackColor = false;
            this.btnEliminateProm.Click += new System.EventHandler(this.btnEliminateProm_Click);
            // 
            // frmPromotions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(975, 663);
            this.Controls.Add(this.panelCrearAlumnos);
            this.Name = "frmPromotions";
            this.Text = "frmPromotions";
            this.panelCrearAlumnos.ResumeLayout(false);
            this.panelCrearAlumnos.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelCrearAlumnos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCloseProm;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox listPromotions;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeeList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnEditProm;
        private System.Windows.Forms.Button btnEliminateProm;
    }
}