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
        Articulo reg = new Articulo();
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            codArt.Text = reg.Codigo;
            nomArt.Text = reg.Nombre;
            catArt.Text = reg.IdCategoria.ToString();
            marcArt.Text = reg.IdMarca.ToString();
            precArt.Text = reg.Precio.ToString();
            descArt.Text = reg.Descripcion;
            urlImagen.Text = reg.Imagen;
            Categorias aux = new Categorias();
            newIdCat.DataSource = aux.CargarCbox();
            Marcas aux1 = new Marcas();
            newIdMarca.DataSource = aux1.CargarCbox();


        }

        private void clickCancelar(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void clickConfirmar(object sender, MouseEventArgs e)
        {

            if (!checkBox1.Checked) reg.Codigo = newCod.Text;
            if (!checkBox2.Checked) reg.Nombre = newNombre.Text;
            //if (!checkBox3.Checked) reg.IdCategoria = newCat.SelectedItem.ToString();
            //if (!checkBox4.Checked) reg.IdMarca = newMarca.SelectedItem.ToString();
            if (!checkBox3.Checked) reg.IdCategoria = int.Parse(newIdCat.Text);
            if (!checkBox4.Checked) reg.IdMarca = int.Parse(newIdMarca.Text);
            if (!checkBox5.Checked) reg.Precio = SqlMoney.Parse(newPrecio.Text);
            if (!checkBox6.Checked) reg.Descripcion = newDesc.Text;
            this.Close();
        }

        public void CargarArticulo (Articulo aux)
        {
            reg.IdCategoria = aux.IdCategoria;
            reg.Codigo = aux.Codigo;
            reg.Descripcion = aux.Descripcion;
            reg.Imagen = aux.Imagen;
            reg.IdMarca = aux.IdMarca;
            reg.Nombre = aux.Nombre;
            reg.Precio = aux.Precio;
        }

    }
}
