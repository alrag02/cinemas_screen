using System;
using System.Data;
using System.Windows.Forms;
using Conexiones;


namespace Cinemas_Hnry
{
    public partial class frm_Cartelera : Form
    {

        public frm_Cartelera()
        {
            InitializeComponent();
        }
        Base b = new Base("root", "AlejandroG25", "cinemas_henry");
        int modificar = 0, fila;
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void frm_Cartelera_Load(object sender, EventArgs e)
        {
            actualizar();

        }

        private void actualizar()
        {
            try
            {
                DataSet ds = new DataSet();
                //ds = b.buscar("select ID,Nombre,Clasificacion,Genero,Duracion from pelicula;", "pelicula");
                ds = b.buscar("select * from pelicula;", "pelicula");
             tabla_peliculas.DataSource = ds.Tables[0]; tab_cartelera.SelectedIndex = 0;
            }
            catch (Exception)
            {
                MessageBox.Show("No se ha podido conectar con la base de datos.");
            }
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string r = "";
            if (modificar == 0)
            {
                r = b.imb("insert into Pelicula values (null,'" + txt_Nombre.Text + "','" + cmb_Clasi.Text + "','" + cmb_Gnero.Text + "','"+txt_Director.Text+"','"+txt_Reparto.Text+"','"+txt_Duracion.Text+"','"+txt_Sinopsis.Text+"');");
                MessageBox.Show("Base agregada");
            }
            else
            {
                r = b.imb("update Pelicula set codigo = '" + txt_ID.Text + "'");
                modificar = 0;

            }
            limpiar();
            actualizar();
        }

        private void limpiar()
        {
            txt_Director.Clear();
            txt_Duracion.Clear();
            txt_ID.Clear();
            txt_Nombre.Clear();
            txt_Reparto.Clear();
            txt_Sinopsis.Clear();
            cmb_Clasi.SelectedIndex = 0;
            cmb_Gnero.SelectedIndex= 0;
            txt_Nombre.Focus();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_Bu_TextChanged(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            ds = b.buscar("select * from pelicula where Nombre like '%" + txt_Bu.Text + "%';", "pelicula");
            tabla_peliculas.DataSource = ds.Tables[0];
        }

        private void btn_Borrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro?", "",
         MessageBoxButtons.YesNo, MessageBoxIcon.Question)
         == DialogResult.Yes)
            {
                string r = b.imb("delete from pelicula where Nombre = '" + txt_Nombre.Text + "';");
                MessageBox.Show("Datos Eliminados");

                limpiar(); actualizar();
            }

            
        }

        private void tabla_peliculas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tabla_peliculas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int filaseleccionada = e.RowIndex;
            fila = filaseleccionada;
            try
            {
                tab_cartelera.SelectedIndex = 1;
                btn_Modificar.Enabled = true;
                btn_Agregar.Enabled = false;
                txt_ID.Text = tabla_peliculas.Rows[fila].Cells[0].Value.ToString();
                txt_Nombre.Text = tabla_peliculas.Rows[fila].Cells[1].Value.ToString();
                cmb_Clasi.Text = tabla_peliculas.Rows[fila].Cells[2].Value.ToString();
                cmb_Gnero.Text = tabla_peliculas.Rows[fila].Cells[3].Value.ToString();
                txt_Director.Text = tabla_peliculas.Rows[fila].Cells[4].Value.ToString();
                txt_Reparto.Text = tabla_peliculas.Rows[fila].Cells[5].Value.ToString();
                txt_Duracion.Text = tabla_peliculas.Rows[fila].Cells[6].Value.ToString();
                txt_Sinopsis.Text = tabla_peliculas.Rows[fila].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("No se seleccionó ninguna fila, " + fila + "  " + tabla_peliculas.Rows[fila].Cells[0].Value.ToString());

            }

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            tab_cartelera.SelectedIndex = 1;
            limpiar();
            btn_Modificar.Enabled = false;
            btn_Agregar.Enabled = true;
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            string mod;
            if (modificar == 0)
            {

               mod = b.imb("update Pelicula set nombre = '" + txt_Nombre.Text + "',clasificacion ='" + cmb_Clasi.Text + "', genero = '" + cmb_Gnero.Text + "', director ='" + txt_Director.Text + "', reparto ='" + txt_Reparto.Text+ "', duracion ='" + txt_Duracion.Text+ "', sinopsis ='" + txt_Sinopsis.Text+"' where id = " + tabla_peliculas.Rows[fila].Cells[0].Value.ToString() + ";");
                MessageBox.Show("Pelicula editada correctamente");

            }
            else
            {

            }

            modificar = 1;
            
            actualizar();
            limpiar();
            modificar = 0;
        }
    }
}
