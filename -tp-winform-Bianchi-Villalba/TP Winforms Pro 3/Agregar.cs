using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TP_Winforms_Pro_3
{
    public partial class Agregar : Form
    {
        public Agregar()
        {
            InitializeComponent();
            CargarCboCat();
            CargarCboMarca();
        }

        public void CargarCboCat()
        {
            string query = "select Id, Descripcion from CATEGORIAS";
            ConexionSQL conexion = new ConexionSQL();
            conexion.Abir();
            SqlCommand comando = new SqlCommand(query, conexion.directorio);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            //conexion.Cerrar();
            cboCat.ValueMember = "Id";
            cboCat.DisplayMember = "Descripcion";
            cboCat.DataSource = tabla;
        }

        public void CargarCboMarca()
        {
            string query = "select Id, Descripcion from MARCAS";
            ConexionSQL conexion = new ConexionSQL();
            conexion.Abir();
            SqlCommand comando = new SqlCommand(query, conexion.directorio);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.DataSource = tabla;

            conexion.Cerrar();

        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            /*
            Categorias aux = new Categorias();
            cboCat.DataSource = aux.Listar();
            Marcas aux1 = new Marcas();
            cboMarca.DataSource = aux1.Listar();
            */

                
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");

            string query = "INSERT INTO ARTICULOS (Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES (@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)";
            conexion.Open();

            SqlCommand comando = new SqlCommand(query, conexion);
            comando.Parameters.AddWithValue("@Nombre", boxNombre.Text);
            comando.Parameters.AddWithValue("@Descripcion", boxPrecio.Text);
            comando.Parameters.AddWithValue("@IdMarca", 1);
            comando.Parameters.AddWithValue("@IdCategoria", 4);
            comando.Parameters.AddWithValue("@ImagenUrl", boxImage.Text);
            comando.Parameters.AddWithValue("@Precio", boxPrecio.Text);
            comando.ExecuteNonQuery();

            try
            {
                MessageBox.Show("¡Insertado a la BD!");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo insertar el articulo");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
