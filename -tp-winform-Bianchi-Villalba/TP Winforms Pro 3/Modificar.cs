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
using System.Data.SqlTypes;

namespace TP_Winforms_Pro_3
{
    public partial class Modificar : Form
    {
        private Articulo reg = null;
        public Modificar(Articulo registro)
        {
            InitializeComponent();
            reg = registro;
            
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            codArt.Text = reg.Codigo;
            nomArt.Text = reg.Nombre;
            catArt.Text = reg.IdCategoria.ToString();
            marcArt.Text = reg.IdMarca.ToString();
            precArt.Text = reg.Precio.ToString();
            descArt.Text = reg.Descripcion;
            urlImagen.Text = reg.ImagenUrl;
            if(reg.ImagenUrl != null)
            imagArt.Load(reg.ImagenUrl);

            Categorias aux = new Categorias();
            newIdCat.DataSource = aux.CargarCbox();
            newIdCat.ValueMember = "id";
            newIdCat.DisplayMember = "descripcion";
            Marcas aux1 = new Marcas();
            newIdMarca.ValueMember = "id";
            newIdMarca.DataSource = aux1.CargarCbox();
            newIdMarca.DisplayMember = "descripcion";


        }



        private void clickConfirmar(object sender, MouseEventArgs e)
        {

            if (!checkBox1.Checked) reg.Codigo = newCod.Text;
            if (!checkBox2.Checked) reg.Nombre = newNombre.Text;
            if (!checkBox3.Checked) reg.IdCategoria = Convert.ToInt32(newIdCat.SelectedValue);
            if (!checkBox4.Checked) reg.IdMarca = Convert.ToInt32(newIdMarca.SelectedValue);
            if (!checkBox5.Checked) reg.Precio = SqlMoney.Parse(newPrecio.Text);
            if (!checkBox6.Checked) reg.Descripcion = newDesc.Text;
            if (!checkBox6.Checked) reg.Descripcion = newDesc.Text;

            impactoBD();
            this.Close();
        }

        public void impactoBD()
        {
            ArticuloNegocio aux = new ArticuloNegocio();
            aux.Modificarart(reg);


            try
            {
                MessageBox.Show("¡Actualizado!");
                Close();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo alterar el Producto");
                Close();
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
