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
    public partial class frm_salas : Form
    {
        public frm_salas()
        {
            InitializeComponent();
        }
        Base b = new Base("root", "AlejandroG25", "cinemas_henry");
        int modificar = 0, fila;

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tab_cartelera.SelectedIndex = 1;
            limpiar();
            btn_Modificar.Enabled = false;
            btn_Agregar.Enabled = true;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string r = "";
            if (modificar == 0)
            {
                r = b.imb("insert into Salas values ('" + txt_nombresala.Text + "','" + txt_asiento.Text + "');");
                MessageBox.Show("Base agregada");
            }
            else
            {
                r = b.imb("update Salas set codigo = '" + txt_nombresala.Text + "'");
                modificar = 0;

            }
            limpiar();
            actualizar();
        }

        private void actualizar()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = b.buscar("select * from Salas;", "Salas");
                tabla_salas.DataSource = ds.Tables[0];
                tab_cartelera.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido conectar con la base de datos.");
            }
        }
    
        private void limpiar()
        {
            txt_nombresala.Clear();
            txt_asiento.Clear();
            txt_nombresala.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "",MessageBoxButtons.YesNo, MessageBoxIcon.Question)== DialogResult.Yes)
            {
                string r = b.imb("delete from Salas where Nombre = '" + txt_nombresala.Text + "';");
                MessageBox.Show("Datos Eliminados");

                limpiar(); actualizar();
            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string mod;
            if (modificar == 0)
            {
                mod = b.imb("update salas set Asientos ='" + txt_asiento.Text + "' where Nombre = '" + txt_nombresala.Text + "';");
                MessageBox.Show("Sala editada correctamente");
            }
            else
            {

            }

            modificar = 1;

            txt_nombresala.Enabled = true;
            actualizar();
            limpiar();
            modificar = 0;
        }

        private void frm_salas_Load(object sender, EventArgs e)
        {
            actualizar();
        }

        private void tabla_salas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tabla_salas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = e.RowIndex;
            fila = filaseleccionada;
            try
            {
                tab_cartelera.SelectedIndex = 1;
                txt_nombresala.Enabled = false;
                btn_Modificar.Enabled = true;
                btn_Agregar.Enabled = false;
                txt_nombresala.Text= tabla_salas.Rows[fila].Cells[0].Value.ToString();
                txt_asiento.Text = tabla_salas.Rows[fila].Cells[1].Value.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("No se seleccionó ninguna fila, " + fila + "  " + tabla_salas.Rows[fila].Cells[0].Value.ToString());

            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
