namespace Cinemas_Hnry
{
    partial class frm_addcartelera
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
            this.btn_Close = new System.Windows.Forms.Button();
            this.tab_cartelera = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_Bu = new System.Windows.Forms.TextBox();
            this.tabla_funcion = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_hora = new System.Windows.Forms.TextBox();
            this.cmb_ano = new System.Windows.Forms.ComboBox();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.cmb_dia = new System.Windows.Forms.ComboBox();
            this.cmb_Sala = new System.Windows.Forms.ComboBox();
            this.cmb_peli = new System.Windows.Forms.ComboBox();
            this.btn_Borrar = new System.Windows.Forms.Button();
            this.txt_precio = new System.Windows.Forms.TextBox();
            this.txt_folio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_new = new System.Windows.Forms.Button();
            this.tab_cartelera.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_funcion)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Close
            // 
            this.btn_Close.Location = new System.Drawing.Point(12, 10);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(75, 23);
            this.btn_Close.TabIndex = 3;
            this.btn_Close.Text = "Cerrar";
            this.btn_Close.UseVisualStyleBackColor = true;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            // 
            // tab_cartelera
            // 
            this.tab_cartelera.Controls.Add(this.tabPage1);
            this.tab_cartelera.Controls.Add(this.tabPage2);
            this.tab_cartelera.Location = new System.Drawing.Point(12, 39);
            this.tab_cartelera.Name = "tab_cartelera";
            this.tab_cartelera.SelectedIndex = 0;
            this.tab_cartelera.Size = new System.Drawing.Size(726, 300);
            this.tab_cartelera.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txt_Bu);
            this.tabPage1.Controls.Add(this.tabla_funcion);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(718, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Cartelera";
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
            this.txt_Bu.Size = new System.Drawing.Size(442, 20);
            this.txt_Bu.TabIndex = 4;
            this.txt_Bu.TextChanged += new System.EventHandler(this.txt_Bu_TextChanged);
            // 
            // tabla_funcion
            // 
            this.tabla_funcion.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.tabla_funcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabla_funcion.Location = new System.Drawing.Point(6, 32);
            this.tabla_funcion.Name = "tabla_funcion";
            this.tabla_funcion.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tabla_funcion.Size = new System.Drawing.Size(706, 236);
            this.tabla_funcion.TabIndex = 0;
            this.tabla_funcion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabla_peliculas_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txt_hora);
            this.tabPage2.Controls.Add(this.cmb_ano);
            this.tabPage2.Controls.Add(this.cmb_mes);
            this.tabPage2.Controls.Add(this.cmb_dia);
            this.tabPage2.Controls.Add(this.cmb_Sala);
            this.tabPage2.Controls.Add(this.cmb_peli);
            this.tabPage2.Controls.Add(this.btn_Borrar);
            this.tabPage2.Controls.Add(this.txt_precio);
            this.tabPage2.Controls.Add(this.txt_folio);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btn_Cancelar);
            this.tabPage2.Controls.Add(this.btn_Agregar);
            this.tabPage2.Controls.Add(this.btn_Modificar);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(718, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar/Editar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 40;
            this.label4.Text = "Fecha";
            // 
            // txt_hora
            // 
            this.txt_hora.Location = new System.Drawing.Point(235, 86);
            this.txt_hora.Name = "txt_hora";
            this.txt_hora.Size = new System.Drawing.Size(100, 20);
            this.txt_hora.TabIndex = 39;
            this.txt_hora.Text = "00:00";
            // 
            // cmb_ano
            // 
            this.cmb_ano.FormattingEnabled = true;
            this.cmb_ano.Items.AddRange(new object[] {
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmb_ano.Location = new System.Drawing.Point(161, 86);
            this.cmb_ano.Name = "cmb_ano";
            this.cmb_ano.Size = new System.Drawing.Size(67, 21);
            this.cmb_ano.TabIndex = 38;
            // 
            // cmb_mes
            // 
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "",
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(81, 86);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(74, 21);
            this.cmb_mes.TabIndex = 37;
            // 
            // cmb_dia
            // 
            this.cmb_dia.FormattingEnabled = true;
            this.cmb_dia.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cmb_dia.Location = new System.Drawing.Point(28, 87);
            this.cmb_dia.Name = "cmb_dia";
            this.cmb_dia.Size = new System.Drawing.Size(47, 21);
            this.cmb_dia.TabIndex = 36;
            // 
            // cmb_Sala
            // 
            this.cmb_Sala.FormattingEnabled = true;
            this.cmb_Sala.Location = new System.Drawing.Point(347, 37);
            this.cmb_Sala.Name = "cmb_Sala";
            this.cmb_Sala.Size = new System.Drawing.Size(103, 21);
            this.cmb_Sala.TabIndex = 35;
            // 
            // cmb_peli
            // 
            this.cmb_peli.FormattingEnabled = true;
            this.cmb_peli.Location = new System.Drawing.Point(134, 38);
            this.cmb_peli.Name = "cmb_peli";
            this.cmb_peli.Size = new System.Drawing.Size(200, 21);
            this.cmb_peli.TabIndex = 34;
            // 
            // btn_Borrar
            // 
            this.btn_Borrar.Location = new System.Drawing.Point(637, 245);
            this.btn_Borrar.Name = "btn_Borrar";
            this.btn_Borrar.Size = new System.Drawing.Size(75, 23);
            this.btn_Borrar.TabIndex = 3;
            this.btn_Borrar.Text = "Borrar";
            this.btn_Borrar.UseVisualStyleBackColor = true;
            this.btn_Borrar.Click += new System.EventHandler(this.btn_Borrar_Click);
            // 
            // txt_precio
            // 
            this.txt_precio.Location = new System.Drawing.Point(347, 86);
            this.txt_precio.Name = "txt_precio";
            this.txt_precio.Size = new System.Drawing.Size(103, 20);
            this.txt_precio.TabIndex = 27;
            // 
            // txt_folio
            // 
            this.txt_folio.Location = new System.Drawing.Point(28, 38);
            this.txt_folio.Name = "txt_folio";
            this.txt_folio.Size = new System.Drawing.Size(100, 20);
            this.txt_folio.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(344, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Sala";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(344, 71);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Precio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(232, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Horario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(131, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Pelicula";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Folio";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(171, 198);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancelar.TabIndex = 18;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Location = new System.Drawing.Point(90, 198);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_Agregar.TabIndex = 17;
            this.btn_Agregar.Text = "Listo";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Enabled = false;
            this.btn_Modificar.Location = new System.Drawing.Point(9, 198);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_Modificar.TabIndex = 2;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_new
            // 
            this.btn_new.Location = new System.Drawing.Point(644, 12);
            this.btn_new.Name = "btn_new";
            this.btn_new.Size = new System.Drawing.Size(90, 23);
            this.btn_new.TabIndex = 4;
            this.btn_new.Text = "Nuevo";
            this.btn_new.UseVisualStyleBackColor = true;
            this.btn_new.Click += new System.EventHandler(this.btn_new_Click);
            // 
            // frm_addcartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(750, 349);
            this.ControlBox = false;
            this.Controls.Add(this.btn_new);
            this.Controls.Add(this.btn_Close);
            this.Controls.Add(this.tab_cartelera);
            this.Name = "frm_addcartelera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregue funciones";
            this.Load += new System.EventHandler(this.frm_addcartelera_Load);
            this.tab_cartelera.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabla_funcion)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Close;
        private System.Windows.Forms.TabControl tab_cartelera;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_Bu;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.DataGridView tabla_funcion;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.TextBox txt_precio;
        private System.Windows.Forms.TextBox txt_folio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_Sala;
        private System.Windows.Forms.ComboBox cmb_peli;
        private System.Windows.Forms.Button btn_Borrar;
        private System.Windows.Forms.ComboBox cmb_ano;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.ComboBox cmb_dia;
        private System.Windows.Forms.Button btn_new;
        private System.Windows.Forms.TextBox txt_hora;
        private System.Windows.Forms.Label label4;
    }
}