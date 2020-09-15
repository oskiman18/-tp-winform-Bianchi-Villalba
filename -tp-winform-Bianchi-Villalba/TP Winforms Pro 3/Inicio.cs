using System;
using System.Data;
using System.Data.SqlClient;
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
            SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
            SqlCommand comando = new SqlCommand("select A.Id, A.Codigo,A.Nombre, C.Descripcion as Categorias, M.Descripcion as Marca,A.ImagenUrl as Imagen,A.Precio from ARTICULOS as A join CATEGORIAS as C on C.Id=A.IdCategoria join MARCAS as M on M.Id = A.IdMarca", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvArticulo.DataSource = tabla;

        }

        private void clickModificar(object sender, MouseEventArgs e)
        {
            Modificar ventana = new Modificar();
            ventana.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");

            try
            {
                conexion.Open();
                textEstado.Text = "Conectado";
            }
            catch (Exception)
            {
                MessageBox.Show("Conectame la Base papu! :(");
            }
        }
    }
}
