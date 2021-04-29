using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Conexiones;

namespace Cinemas_Hnry
{
    public partial class frm_Menu : Form
    {
        public frm_Menu()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            frm_login f1 = new frm_login();
            f1.Show();
            Close();
        }

        private void btn_Agregar_Pelicula_Click(object sender, EventArgs e)
        {
            frm_Cartelera fc = new frm_Cartelera();
            fc.Show();
        }

        private void btn_ModCartelera_Click(object sender, EventArgs e)
        {
            frm_Cartelera fo = new frm_Cartelera();
            fo.Show();
        }

        private void btn_salas_Click(object sender, EventArgs e)
        {
            frm_salas fs = new frm_salas();
            fs.Show();
        }

        private void btn_configurar_funciones_Click(object sender, EventArgs e)
        {
            frm_addcartelera fac = new frm_addcartelera();
            fac.Show();
        }
    }
}
