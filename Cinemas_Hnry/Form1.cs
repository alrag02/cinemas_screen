using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Cinemas_Hnry
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            registro();
        }

        private void registro()
        {
            if ((txt_Nombre.Text == "Nestor") && (txt_Contraseña.Text == "1234"))
            {
                frm_Menu m = new frm_Menu();
                m.Show();
                this.Hide();
            }
            else
            {
                lbl_Mensaje.Text = "Intentelo de Nuevo";
                txt_Nombre.Clear();
                txt_Contraseña.Clear();
                txt_Nombre.Focus();
            }
        }
        private void txt_Contraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                registro();
            }
        }
        private void txt_Nombre_KeyPress(object sender, KeyPressEventArgs e)
        {

            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                txt_Contraseña.Focus();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
