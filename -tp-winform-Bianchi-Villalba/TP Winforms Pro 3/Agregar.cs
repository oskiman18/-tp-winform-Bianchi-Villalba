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
using System.Security.Cryptography;

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
            
        }

        public void CargarCboMarca()
        {
       
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Marcas aux = new Marcas();
            cboMarca.ValueMember = "Id";
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.DataSource = aux.CargarCbox(); 
            Categorias aux1 = new Categorias();
            cboCat.ValueMember = "Id";
            cboCat.DisplayMember = "Descripcion";
            cboCat.DataSource = aux1.CargarCbox();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ValidarIngresoEnComboBox();
            Insert();
        }
        public void ValidarIngresoEnComboBox()
        {
            //--------------------------------falta validar los ingresos!!!-------------------------

        }

        public void Insert()
        {
            ConexionSQL conexion = new ConexionSQL();
            string query = "INSERT INTO ARTICULOS (Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) VALUES (@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,@Precio)";
            conexion.Abir();
            SqlCommand comando = new SqlCommand(query, conexion.directorio);
            comando.Parameters.AddWithValue("@Nombre", boxNombre.Text);
            comando.Parameters.AddWithValue("@Descripcion", boxPrecio.Text);
            comando.Parameters.AddWithValue("@IdMarca", Convert.ToInt32(cboMarca.SelectedValue));
            comando.Parameters.AddWithValue("@IdCategoria", Convert.ToInt32(cboCat.SelectedValue));
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
            this.Close();
        }
    }
}
