namespace Cinemas_Hnry
{
    partial class frm_Cartelera
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
            this.tab_cartelera = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Bu = new System.Windows.Forms.TextBox();
            this.tabla_peliculas = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.txt_Sinopsis = new System.Windows.Forms.TextBox();
            this.txt_Reparto = new System.Windows.Forms.TextBox();
            this.txt_Duracion = new System.Windows.Forms.TextBox();
            this.txt_Director = new System.Windows.Forms.TextBox();
            this.cmb_Gnero = new System.Windows.Forms.ComboBox();
            this.cmb_Clasi = new System.Windows.Forms.ComboBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Close = new System.Windows.Forms.Button();
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.tab_cartelera.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_peliculas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_cartelera
            // 
            this.tab_cartelera.Controls.Add(this.tabPage1);
            this.tab_cartelera.Controls.Add(this.tabPage2);
            this.tab_cartelera.Location = new System.Drawing.Point(12, 41);
            this.tab_cartelera.Name = "tab_cartelera";
            this.tab_cartelera.SelectedIndex = 0;
            this.tab_cartelera.Size = new System.Drawing.Size(694, 311);
            this.tab_cartelera.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_Bu);
            this.tabPage1.Controls.Add(this.tabla_peliculas);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 285);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cartelera";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(249, 13);
            this.label7.TabIndex = 5;
            this.label7.Text = "Escriba el nombre de la película que desea buscar:";
            // 
            // txt_Bu
            // 
            this.txt_Bu.Location = new System.Drawing.Point(270, 6);
            this.txt_Bu.Name = "txt_Bu";
            this.txt_Bu.Size = new System.Drawing.Size(410, 20);
            this.txt_Bu.TabIndex = 4;
            this.txt_Bu.TextChanged += new System.EventHandler(this.txt_Bu_TextChanged);
            // 
            // tabla_peliculas
            // 
            this.tabla_peliculas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_peliculas.Location = new System.Drawing.Point(6, 32);
            this.tabla_peliculas.Name = "tabla_peliculas";
            this.tabla_peliculas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_peliculas.Size = new System.Drawing.Size(674, 236);
            this.tabla_peliculas.TabIndex = 0;
            this.tabla_peliculas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_peliculas_CellContentClick);
            this.tabla_peliculas.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_peliculas_CellContentDoubleClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_Cancelar);
            this.tabPage2.Controls.Add(this.btn_Agregar);
            this.tabPage2.Controls.Add(this.btn_Borrar);
            this.tabPage2.Controls.Add(this.btn_Modificar);
            this.tabPage2.Controls.Add(this.txt_Sinopsis);
            this.tabPage2.Controls.Add(this.txt_Reparto);
            this.tabPage2.Controls.Add(this.txt_Duracion);
            this.tabPage2.Controls.Add(this.txt_Director);
            this.tabPage2.Controls.Add(this.cmb_Gnero);
            this.tabPage2.Controls.Add(this.cmb_Clasi);
            this.tabPage2.Controls.Add(this.txt_Nombre);
            this.tabPage2.Controls.Add(this.txt_ID);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 285);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar/Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(193, 241);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(112, 241);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(579, 241);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Location = new System.Drawing.Point(31, 241);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // txt_Sinopsis
            // 
            this.txt_Sinopsis.Location = new System.Drawing.Point(31, 179);
            this.txt_Sinopsis.Multiline = true;
            this.txt_Sinopsis.Name = "txt_Sinopsis";
            this.txt_Sinopsis.Size = new System.Drawing.Size(623, 56);
            this.txt_Sinopsis.TabIndex = 16;
            // 
            // txt_Reparto
            // 
            this.txt_Reparto.Location = new System.Drawing.Point(31, 130);
            this.txt_Reparto.Name = "txt_Reparto";
            this.txt_Reparto.Size = new System.Drawing.Size(623, 20);
            this.txt_Reparto.TabIndex = 15;
            // 
            // txt_Duracion
            // 
            this.txt_Duracion.Location = new System.Drawing.Point(535, 77);
            this.txt_Duracion.Name = "txt_Duracion";
            this.txt_Duracion.Size = new System.Drawing.Size(121, 20);
            this.txt_Duracion.TabIndex = 14;
            // 
            // txt_Director
            // 
            this.txt_Director.Location = new System.Drawing.Point(171, 78);
            this.txt_Director.Name = "txt_Director";
            this.txt_Director.Size = new System.Drawing.Size(334, 20);
            this.txt_Director.TabIndex = 13;
            // 
            // cmb_Gnero
            // 
            this.cmb_Gnero.FormattingEnabled = true;
            this.cmb_Gnero.Items.AddRange(new object[] {
            "",
            "Aventura y acción",
            "Bélico",
            "Biográfico",
            "Ciencia ficción",
            "Comedia",
            "Documental",
            "Drama",
            "Histórico",
            "Infantil",
            "Musical",
            "Porno-erótico",
            "Terror / horror",
            "Western"});
            this.cmb_Gnero.Location = new System.Drawing.Point(31, 77);
            this.cmb_Gnero.Name = "cmb_Gnero";
            this.cmb_Gnero.Size = new System.Drawing.Size(121, 21);
            this.cmb_Gnero.TabIndex = 12;
            // 
            // cmb_Clasi
            // 
            this.cmb_Clasi.FormattingEnabled = true;
            this.cmb_Clasi.Items.AddRange(new object[] {
            "",
            "AA",
            "A",
            "B",
            "B15",
            "C",
            "D"});
            this.cmb_Clasi.Location = new System.Drawing.Point(535, 21);
            this.cmb_Clasi.Name = "cmb_Clasi";
            this.cmb_Clasi.Size = new System.Drawing.Size(121, 21);
            this.cmb_Clasi.TabIndex = 11;
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Location = new System.Drawing.Point(171, 22);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(334, 20);
            this.txt_Nombre.TabIndex = 10;
            // 
            // txt_ID
            // 
            this.txt_ID.Enabled = false;
            this.txt_ID.Location = new System.Drawing.Point(31, 22);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(121, 20);
            this.txt_ID.TabIndex = 9;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 6);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Sinopsis";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(532, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Duración (minutos)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Reparto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(168, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Director";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Genero";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(532, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Clasificación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(168, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(16, 12);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 1;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.btn_Nuevo.Location = new System.Drawing.Point(530, 12);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(172, 24);
            this.btn_Nuevo.TabIndex = 6;
            this.btn_Nuevo.Text = "Agregar un nueva película";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // frm_Cartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(718, 384);
            this.ControlBox = false;
            this.Controls.Add(this.btn_Nuevo);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tab_cartelera);
            this.Name = "frm_Cartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar la cartelera";
            this.Load += new System.EventHandler(this.frm_Cartelera_Load);
            this.tab_cartelera.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_peliculas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tab_cartelera;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView tabla_peliculas;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_Sinopsis;
        private System.Windows.Forms.TextBox txt_Reparto;
        private System.Windows.Forms.TextBox txt_Duracion;
        private System.Windows.Forms.TextBox txt_Director;
        private System.Windows.Forms.ComboBox cmb_Gnero;
        private System.Windows.Forms.ComboBox cmb_Clasi;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Bu;
        private System.Windows.Forms.Button btn_Nuevo;
    }
}