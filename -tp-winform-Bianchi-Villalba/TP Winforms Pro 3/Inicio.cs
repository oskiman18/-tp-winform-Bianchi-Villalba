using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Reflection;
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

        bool listar = false;
        private void btnListar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
           // ConexionSQL aux = new ConexionSQL();
            if (!listar)
            {
                listar = true;
                btnListar.Text = "Actualizar lista";
            }

            try
            {
                //string query = "select * from ARTICULOS";
                string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS as A";
                //string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS as A join MARCAS as M on M.Id=A.IdMarca join CATEGORIAS as C on C.Id=A.IdCategoria";
                dgbArticulo.DataSource = negocio.listar(query);
                dgbArticulo.Columns[6].Visible = false;
                dgbArticulo.Columns[7].Visible = false;
                dgbArticulo.Columns[8].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abir la conexion para listar");
            }
            
        }

        private void clickModificar(object sender, MouseEventArgs e)
        {
            Modificar ventana = new Modificar();
            ventana.ShowDialog();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            try
            {
                conexion.Abir();
                textEstado.Text = "Conectado";

            }
            catch (Exception)
            {
                MessageBox.Show("Conectame la Base papu! :(");
            }
            finally
            {
                conexion.Cerrar();
            }
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            //listar todo en el inicio
            try
            {
                Articulo art = (Articulo)dgbArticulo.CurrentRow.DataBoundItem;
                pbArticulo.Load(art.Imagen);
            }
            catch (Exception)
            {
                
            }
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Detalle ventana = new Detalle();
            ventana.ShowDialog();
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

        }
    }
}
