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
    public partial class frm_addcartelera : Form
    {
        public frm_addcartelera()
        {
            InitializeComponent();
        }
        Base b = new Conexiones.Base("root", "AlejandroG25", "cinemas_henry");
        int modificar = 0, fila;
        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            string r = "";
            if (modificar == 0)
            {
                r = b.imb("insert into funcion values ('" + txt_folio.Text+"','" + cmb_dia.Text+"','"+ cmb_mes.Text + "','" + cmb_ano.Text+"','"+txt_hora.Text+"','" + txt_precio.Text + "','"+cmb_peli.Text+ "','"+cmb_Sala.Text+ "');");
                MessageBox.Show("Base agregada");
            }
            else
            {
                r = b.imb("update funcion set folio = '" + txt_folio.Text + "'");
                modificar = 0;

            }
            limpiar();
            actualizar();
        }

        private void limpiar()
        {
            txt_folio.Clear();
            cmb_peli.SelectedIndex = 0;
            cmb_Sala.SelectedIndex = 0;
            txt_hora.Text = "00:00";
            txt_precio.Clear();
            txt_folio.Focus();
        }

        private void tabla_peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = e.RowIndex;
            fila = filaseleccionada;
            try
            {
                tab_cartelera.SelectedIndex = 1;
                txt_folio.Enabled = false;
                btn_Modificar.Enabled = true;
                btn_Agregar.Enabled = false;
                txt_folio.Text = tabla_funcion.Rows[fila].Cells[0].Value.ToString();
                cmb_peli.Text = tabla_funcion.Rows[fila].Cells[1].Value.ToString();
                cmb_Sala.Text = tabla_funcion.Rows[fila].Cells[3].Value.ToString();
                cmb_dia.Text = tabla_funcion.Rows[fila].Cells[4].Value.ToString();
                cmb_mes.Text = tabla_funcion.Rows[fila].Cells[5].Value.ToString();
                cmb_ano.Text = tabla_funcion.Rows[fila].Cells[6].Value.ToString();
                txt_hora.Text = tabla_funcion.Rows[fila].Cells[7].Value.ToString();
                txt_precio.Text = tabla_funcion.Rows[fila].Cells[8].Value.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("No se seleccionó ninguna fila, " + fila + "  " + tabla_funcion.Rows[fila].Cells[0].Value.ToString());

            }

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string mod;
            if (modificar == 0)
            {
                mod = b.imb("update funcion set dia = '" + cmb_dia.Text + "', mes = '" + cmb_mes.Text + "', ano ='" + cmb_ano.Text + "', hora = '" + txt_hora.Text + "', precio = '" + txt_precio.Text + "', fk_id_pelicula = '" + cmb_peli.Text + "', fk_nombre_salas= '" + cmb_Sala.Text + "'  where folio ='" + txt_folio.Text + "';");
                MessageBox.Show("Pelicula editada correctamente");
            }
            else
            {

            }
            modificar = 1;

            actualizar();
            limpiar();
            txt_folio.Enabled = true;
            modificar = 0;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void frm_addcartelera_Load(object sender, EventArgs e)
        {
            actualizar();
            llenarpeli();
            llenarsala();
        }

        private void llenarsala()
        {
            DataSet ds = new DataSet();
            ds = b.buscar("select nombre from salas;", "salas");
            cmb_Sala.DisplayMember = "nombre";
            cmb_Sala.ValueMember = "nombre";
            cmb_Sala.DataSource = ds.Tables[0];
        }

        void llenarpeli()
        {
            DataSet ds = new DataSet();
            ds = b.buscar("select id, nombre from Pelicula;", "Pelicula");
            cmb_peli.DisplayMember = "nombre";
            cmb_peli.ValueMember = "id";
            cmb_peli.DataSource = ds.Tables[0];
        }

        private void txt_Bu_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = b.buscar("select folio as Folio, pelicula.Nombre as Pelicula, salas.nombre as Salas, dia as Dia, mes as Mes, ano as Año, hora as Horario, precio as Precio from funcion,pelicula, salas where fk_id_pelicula=pelicula.id and fk_nombre_salas=salas.nombre and funcion.mes like '%" + txt_Bu.Text + "%';", "funcion,pelicula,salas");
            tabla_funcion.DataSource = ds.Tables[0];

        }

        private void btn_new_Click(object sender, EventArgs e)
        {
            tab_cartelera.SelectedIndex = 1;
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "",
MessageBoxButtons.YesNo, MessageBoxIcon.Question)
== DialogResult.Yes)
            {
                string r = b.imb("delete from funcion where folio = '" + txt_folio.Text + "';");
                MessageBox.Show("Datos Eliminados");
                limpiar();
                actualizar();
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void actualizar()
        {
            try
            {
                DataSet ds = new DataSet();
                ds = b.buscar("select folio as Folio, pelicula.ID ,pelicula.Nombre as Pelicula, salas.nombre as Salas, dia as Dia, mes as Mes, ano as Año, hora as Horario, precio as Precio from funcion,pelicula, salas where fk_id_pelicula=pelicula.id and fk_nombre_salas=salas.nombre ;", "funcion,pelicula,salas");
                tabla_funcion.DataSource = ds.Tables[0];
                tab_cartelera.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido conectar con la base de datos.");
            }
        }
    }
}
