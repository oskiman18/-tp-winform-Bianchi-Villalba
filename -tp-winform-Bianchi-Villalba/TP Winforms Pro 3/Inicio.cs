using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Winforms_Pro_3
{
    public partial class Inicio : Form
    {

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnAgregar_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Agrega un articulo nuevo al Catalogo";
        }

        private void btnModificar_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Modifica un articulo existente en el Catalogo";

        }

        private void btnAgregar_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción";

        }

        private void btnModificar_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción";
        }

        private void btnListar_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción"; 
        }

        private void btnListar_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Muestra todos los articulos existentes en el Catalogo";
        }

        private void btnBusqueda_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción";
        }

        private void btnBusqueda_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Busca y lista articulos por criterios elegidos";

        }

        private void btnDetalle_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción";

        }

        private void btnDetalle_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Muestra los detalles de un artículo";

        }

        private void btnEliminar_MouseLeave(object sender, EventArgs e)
        {
            Descripcion.Text = "Elija una Opción";

        }

        private void btnEliminar_MouseMove(object sender, MouseEventArgs e)
        {
            Descripcion.Text = "Elimina un articulo seleccionado del Catálogo";

        }

        private void btnClick(object sender, MouseEventArgs e)
        {
            Agregar ventana = new Agregar();
            ventana.ShowDialog();
        }

        private void dgvArticulo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            /*falta!!! :P*/
           // SqlConnection conexion = new SqlConnection("server=LAPTOP-HERNANVI\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
            SqlConnection conexion = new SqlConnection("server=DESKTOP-I91JBL3\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from ARTICULOS" , conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvArticulo.DataSource = tabla;
            
        }

        private void btnConectarBD_Click(object sender, EventArgs e)
        {
           // SqlConnection conexion = new SqlConnection("server=LAPTOP-HERNANVI\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
             SqlConnection conexion = new SqlConnection("server=DESKTOP-I91JBL3\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");

            try
            {
                conexion.Open();
                MessageBox.Show("Conectado!");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo conectar! :(");
            }
        }

        private void clickModificar(object sender, MouseEventArgs e)
        {
            Modificar ventana = new Modificar();
            ventana.ShowDialog();
        }
    }
}
