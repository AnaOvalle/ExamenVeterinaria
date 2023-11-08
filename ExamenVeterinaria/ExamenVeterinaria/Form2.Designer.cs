namespace ExamenVeterinaria
{
    partial class Form2
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.registro = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbEspecie = new System.Windows.Forms.ComboBox();
            this.especieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaDataSet = new ExamenVeterinaria.VeterinariaDataSet();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPropietario = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtRaza = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.subir = new System.Windows.Forms.Button();
            this.pbImagen = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblcerrar = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.btnActua = new System.Windows.Forms.Button();
            this.btnElimi = new System.Windows.Forms.Button();
            this.especieTableAdapter = new ExamenVeterinaria.VeterinariaDataSetTableAdapters.EspecieTableAdapter();
            this.veterinariaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.veterinariaDataSet1 = new ExamenVeterinaria.VeterinariaDataSet1();
            this.pacientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pacientesTableAdapter = new ExamenVeterinaria.VeterinariaDataSet1TableAdapters.PacientesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = global::ExamenVeterinaria.Properties.Resources.Captura_de_pantalla_2023_11_03_154826;
            this.pictureBox2.Location = new System.Drawing.Point(339, -1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(311, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // registro
            // 
            this.registro.AutoSize = true;
            this.registro.BackColor = System.Drawing.Color.Transparent;
            this.registro.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.registro.Font = new System.Drawing.Font("Rockwell Extra Bold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registro.ForeColor = System.Drawing.Color.Black;
            this.registro.Location = new System.Drawing.Point(45, 10);
            this.registro.Name = "registro";
            this.registro.Size = new System.Drawing.Size(263, 74);
            this.registro.TabIndex = 5;
            this.registro.Text = "Registro \r\nde pacientes";
            this.registro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbEspecie);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPropietario);
            this.panel1.Controls.Add(this.registro);
            this.panel1.Controls.Add(this.txtColor);
            this.panel1.Controls.Add(this.dtpFecha);
            this.panel1.Controls.Add(this.txtEdad);
            this.panel1.Controls.Add(this.txtRaza);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.subir);
            this.panel1.Controls.Add(this.pbImagen);
            this.panel1.Location = new System.Drawing.Point(1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 573);
            this.panel1.TabIndex = 6;
            // 
            // cbEspecie
            // 
            this.cbEspecie.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.especieBindingSource, "TipoEspecie", true));
            this.cbEspecie.DataSource = this.especieBindingSource;
            this.cbEspecie.DisplayMember = "TipoEspecie";
            this.cbEspecie.FormattingEnabled = true;
            this.cbEspecie.Location = new System.Drawing.Point(127, 319);
            this.cbEspecie.Name = "cbEspecie";
            this.cbEspecie.Size = new System.Drawing.Size(198, 27);
            this.cbEspecie.TabIndex = 33;
            this.cbEspecie.ValueMember = "TipoEspecie";
            this.cbEspecie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cbEspecie_KeyDown);
            // 
            // especieBindingSource
            // 
            this.especieBindingSource.DataMember = "Especie";
            this.especieBindingSource.DataSource = this.veterinariaDataSet;
            // 
            // veterinariaDataSet
            // 
            this.veterinariaDataSet.DataSetName = "VeterinariaDataSet";
            this.veterinariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(127, 228);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(125, 26);
            this.txtID.TabIndex = 32;
            this.txtID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtID_KeyDown);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 231);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 31;
            this.label8.Text = "IDPaciente: ";
            // 
            // txtPropietario
            // 
            this.txtPropietario.Location = new System.Drawing.Point(127, 538);
            this.txtPropietario.Name = "txtPropietario";
            this.txtPropietario.Size = new System.Drawing.Size(198, 26);
            this.txtPropietario.TabIndex = 30;
            this.txtPropietario.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPropietario_KeyDown);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(127, 497);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(125, 26);
            this.txtColor.TabIndex = 29;
            this.txtColor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtColor_KeyDown);
            // 
            // dtpFecha
            // 
            this.dtpFecha.CalendarFont = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFecha.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpFecha.CustomFormat = "DD/MM/AA";
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(127, 453);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(198, 26);
            this.dtpFecha.TabIndex = 28;
            this.dtpFecha.Value = new System.DateTime(2023, 11, 5, 0, 0, 0, 0);
            this.dtpFecha.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dtpFecha_KeyDown);
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(127, 407);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(125, 26);
            this.txtEdad.TabIndex = 27;
            this.txtEdad.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtEdad_KeyDown);
            // 
            // txtRaza
            // 
            this.txtRaza.Location = new System.Drawing.Point(127, 364);
            this.txtRaza.Name = "txtRaza";
            this.txtRaza.Size = new System.Drawing.Size(156, 26);
            this.txtRaza.TabIndex = 26;
            this.txtRaza.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtRaza_KeyDown);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(127, 271);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(198, 26);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombre_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 541);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 19);
            this.label6.TabIndex = 22;
            this.label6.Text = "Propietario:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 441);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 38);
            this.label5.TabIndex = 21;
            this.label5.Text = "Fecha \r\nnacimiento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 410);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 19);
            this.label4.TabIndex = 20;
            this.label4.Text = "Edad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 367);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "Raza:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 322);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 19);
            this.label2.TabIndex = 18;
            this.label2.Text = "Especie:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 274);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nombre:";
            // 
            // subir
            // 
            this.subir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.subir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subir.Location = new System.Drawing.Point(118, 112);
            this.subir.Name = "subir";
            this.subir.Size = new System.Drawing.Size(92, 27);
            this.subir.TabIndex = 16;
            this.subir.Text = "Subir archivo...";
            this.subir.UseVisualStyleBackColor = true;
            this.subir.Click += new System.EventHandler(this.subir_Click);
            // 
            // pbImagen
            // 
            this.pbImagen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pbImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImagen.Location = new System.Drawing.Point(23, 112);
            this.pbImagen.Name = "pbImagen";
            this.pbImagen.Size = new System.Drawing.Size(89, 99);
            this.pbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImagen.TabIndex = 15;
            this.pbImagen.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(372, 184);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(639, 356);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lblcerrar
            // 
            this.lblcerrar.AutoSize = true;
            this.lblcerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblcerrar.Font = new System.Drawing.Font("Rockwell", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.lblcerrar.Location = new System.Drawing.Point(864, 12);
            this.lblcerrar.Name = "lblcerrar";
            this.lblcerrar.Size = new System.Drawing.Size(147, 23);
            this.lblcerrar.TabIndex = 8;
            this.lblcerrar.Text = "Cerrar sesión.";
            this.lblcerrar.Click += new System.EventHandler(this.lblcerrar_Click);
            // 
            // btnRegis
            // 
            this.btnRegis.BackgroundImage = global::ExamenVeterinaria.Properties.Resources.Captura_de_pantalla_2023_10_23_211500;
            this.btnRegis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegis.Location = new System.Drawing.Point(372, 142);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(38, 36);
            this.btnRegis.TabIndex = 9;
            this.btnRegis.UseVisualStyleBackColor = true;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // btnActua
            // 
            this.btnActua.BackgroundImage = global::ExamenVeterinaria.Properties.Resources.Captura_de_pantalla_2023_10_23_211238;
            this.btnActua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActua.Location = new System.Drawing.Point(416, 142);
            this.btnActua.Name = "btnActua";
            this.btnActua.Size = new System.Drawing.Size(38, 36);
            this.btnActua.TabIndex = 10;
            this.btnActua.UseVisualStyleBackColor = true;
            this.btnActua.Click += new System.EventHandler(this.btnActua_Click);
            // 
            // btnElimi
            // 
            this.btnElimi.BackgroundImage = global::ExamenVeterinaria.Properties.Resources.Captura_de_pantalla_2023_10_23_211523;
            this.btnElimi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnElimi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnElimi.Location = new System.Drawing.Point(460, 142);
            this.btnElimi.Name = "btnElimi";
            this.btnElimi.Size = new System.Drawing.Size(38, 36);
            this.btnElimi.TabIndex = 11;
            this.btnElimi.UseVisualStyleBackColor = true;
            this.btnElimi.Click += new System.EventHandler(this.btnElimi_Click);
            // 
            // especieTableAdapter
            // 
            this.especieTableAdapter.ClearBeforeFill = true;
            // 
            // veterinariaDataSetBindingSource
            // 
            this.veterinariaDataSetBindingSource.DataSource = this.veterinariaDataSet;
            this.veterinariaDataSetBindingSource.Position = 0;
            // 
            // veterinariaDataSet1
            // 
            this.veterinariaDataSet1.DataSetName = "VeterinariaDataSet1";
            this.veterinariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pacientesBindingSource
            // 
            this.pacientesBindingSource.DataMember = "Pacientes";
            this.pacientesBindingSource.DataSource = this.veterinariaDataSet1;
            // 
            // pacientesTableAdapter
            // 
            this.pacientesTableAdapter.ClearBeforeFill = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BackgroundImage = global::ExamenVeterinaria.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1034, 572);
            this.Controls.Add(this.btnElimi);
            this.Controls.Add(this.btnActua);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.lblcerrar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.especieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImagen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.veterinariaDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pacientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label registro;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button subir;
        private System.Windows.Forms.PictureBox pbImagen;
        private System.Windows.Forms.TextBox txtRaza;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtPropietario;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblcerrar;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.Button btnActua;
        private System.Windows.Forms.Button btnElimi;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbEspecie;
        private VeterinariaDataSet veterinariaDataSet;
        private System.Windows.Forms.BindingSource especieBindingSource;
        private VeterinariaDataSetTableAdapters.EspecieTableAdapter especieTableAdapter;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.BindingSource veterinariaDataSetBindingSource;
        private VeterinariaDataSet1 veterinariaDataSet1;
        private System.Windows.Forms.BindingSource pacientesBindingSource;
        private VeterinariaDataSet1TableAdapters.PacientesTableAdapter pacientesTableAdapter;
    }
}