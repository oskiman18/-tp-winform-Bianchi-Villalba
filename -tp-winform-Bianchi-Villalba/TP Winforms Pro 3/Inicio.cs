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
        private List<Articulo> lOriginal;
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

        private void btnListar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
        
            try
            {
                string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS as A";//string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS as A join MARCAS as M on M.Id=A.IdMarca join CATEGORIAS as C on C.Id=A.IdCategoria";
                lOriginal = negocio.listar(query);

                dgbArticulo.DataSource = lOriginal;

                dgbArticulo.Columns[3].Visible = false; //descripcion
                dgbArticulo.Columns[6].Visible = false; //marca
                dgbArticulo.Columns[7].Visible = false; //categoria
                dgbArticulo.Columns[8].Visible = false; //urlimagen
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo abir la conexion para listar");
            }
            
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            ConexionSQL conexion = new ConexionSQL();
            ArticuloNegocio negocio = new ArticuloNegocio();
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
            Articulo art = (Articulo)dgbArticulo.CurrentRow.DataBoundItem;          
            try
            {
                pbArticulo.Load(art.ImagenUrl);
            }
            catch (Exception)
            {
                
            }
        }
        public int IDActualDGV()
        {
            var filaSeleccionada = dgbArticulo.CurrentRow;
            int id;
            if (filaSeleccionada != null) //¿Existe una referencia?
            {
                id = Convert.ToInt32(filaSeleccionada.Cells[0].Value);
                return id;
            }
            return -1;
        }
        private void clickModificar(object sender, MouseEventArgs e)
        {
            Articulo reg = null;
            if (dgbArticulo.DataSource != null)
            {
                reg = (Articulo)dgbArticulo.CurrentRow.DataBoundItem;

                if (reg != null)
                {
                    Modificar ventana = new Modificar(reg);
                    ventana.ShowDialog();
                }
            }
            else MessageBox.Show("No selecciono ningun Item");

        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulo art = null;
            if(dgbArticulo.DataSource != null)
            {
                art = (Articulo)dgbArticulo.CurrentRow.DataBoundItem;
                if(art != null)
                {
                    Detalle ventana = new Detalle(art);
                    ventana.ShowDialog();
                }
            }
            else MessageBox.Show("Selecciona un articulo primero!");
        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            if (dgbArticulo.DataSource != null)
            {
                List<Articulo> lfiltro = lOriginal.FindAll(reg => reg.Nombre.ToUpper().Contains(txtBuscar.Text.ToUpper()));
                dgbArticulo.DataSource = lfiltro;
            }
            else MessageBox.Show("Primero liste los productos");
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int id = -1;
            DataGridViewRow row = dgbArticulo.CurrentRow;

            if (row != null)
            {
                id = Convert.ToInt32(row.Cells["id"].Value);
            }


            if (id >= 0)
            {
                eliminar(id);
            }
            else 
            {
                MessageBox.Show("Seleccione un articulo!!!");
            }
            

        }

        void eliminar(int id)
        {
            ArticuloNegocio artNeg = new ArticuloNegocio();

            DialogResult result = MessageBox.Show("Seguro que dese eliminar?", "Eliminar", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                string query = "delete ARTICULOS where id=" + id;

                if (artNeg.Eliminar(query))
                {
                    MessageBox.Show("Eliminado correctamente.");
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar.");
                }
            }
        }

        
    }
}
