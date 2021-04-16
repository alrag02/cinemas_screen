namespace Cinemas_Hnry
{
    partial class frm_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar_Pelicula = new System.Windows.Forms.Button();
            this.btn_logout = new System.Windows.Forms.Button();
            this.btn_salas = new System.Windows.Forms.Button();
            this.btn_configurar_funciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(74, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 56);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(54, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 21);
            this.label1.TabIndex = 16;
            this.label1.Text = "¿QUÉ DESEA HACER?";
            // 
            // btn_Agregar_Pelicula
            // 
            this.btn_Agregar_Pelicula.BackColor = System.Drawing.Color.DarkRed;
            this.btn_Agregar_Pelicula.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_Agregar_Pelicula.Location = new System.Drawing.Point(54, 165);
            this.btn_Agregar_Pelicula.Name = "btn_Agregar_Pelicula";
            this.btn_Agregar_Pelicula.Size = new System.Drawing.Size(161, 38);
            this.btn_Agregar_Pelicula.TabIndex = 17;
            this.btn_Agregar_Pelicula.Text = "Modificar cartelera";
            this.btn_Agregar_Pelicula.UseVisualStyleBackColor = false;
            this.btn_Agregar_Pelicula.Click += new System.EventHandler(this.btn_Agregar_Pelicula_Click);
            // 
            // btn_logout
            // 
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btn_logout.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_logout.Location = new System.Drawing.Point(74, 308);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(115, 41);
            this.btn_logout.TabIndex = 18;
            this.btn_logout.Text = "Cerrar Sesión";
            this.btn_logout.UseVisualStyleBackColor = true;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // btn_salas
            // 
            this.btn_salas.BackColor = System.Drawing.Color.DarkRed;
            this.btn_salas.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_salas.Location = new System.Drawing.Point(54, 225);
            this.btn_salas.Name = "btn_salas";
            this.btn_salas.Size = new System.Drawing.Size(161, 36);
            this.btn_salas.TabIndex = 19;
            this.btn_salas.Text = "Actualizar las salas";
            this.btn_salas.UseVisualStyleBackColor = false;
            this.btn_salas.Click += new System.EventHandler(this.btn_salas_Click);
            // 
            // btn_configurar_funciones
            // 
            this.btn_configurar_funciones.BackColor = System.Drawing.Color.Maroon;
            this.btn_configurar_funciones.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Bold);
            this.btn_configurar_funciones.Location = new System.Drawing.Point(54, 113);
            this.btn_configurar_funciones.Name = "btn_configurar_funciones";
            this.btn_configurar_funciones.Size = new System.Drawing.Size(161, 34);
            this.btn_configurar_funciones.TabIndex = 20;
            this.btn_configurar_funciones.Text = "Configurar funciones";
            this.btn_configurar_funciones.UseVisualStyleBackColor = false;
            this.btn_configurar_funciones.Click += new System.EventHandler(this.btn_configurar_funciones_Click);
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(262, 361);
            this.ControlBox = false;
            this.Controls.Add(this.btn_configurar_funciones);
            this.Controls.Add(this.btn_salas);
            this.Controls.Add(this.btn_logout);
            this.Controls.Add(this.btn_Agregar_Pelicula);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.White;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar_Pelicula;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Button btn_salas;
        private System.Windows.Forms.Button btn_configurar_funciones;
    }
}