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
    public partial class Modificar : Form
    {
        Articulo reg = new Articulo();
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            codArt.Text = reg.Codigo.ToString();
            nomArt.Text = reg.Nombre;
            catArt.Text = reg.Categoria;
            marcArt.Text = reg.Marca;
            precArt.Text = reg.Precio.ToString();
            descArt.Text = reg.Descripcion;
            urlImagen.Text = reg.Imagen;
            Categorias aux = new Categorias();
            newCat.DataSource = aux.Listar();
            Marcas aux1 = new Marcas();
            newMarca.DataSource = aux1.Listar();


        }

        private void clickCancelar(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void clickConfirmar(object sender, MouseEventArgs e)
        {

            if (!checkBox1.Checked) reg.Codigo = int.Parse(newCod.Text);
            if (!checkBox2.Checked) reg.Nombre = newNombre.Text;
            if (!checkBox3.Checked) reg.Categoria = newCat.SelectedItem.ToString();
            if (!checkBox4.Checked) reg.Marca = newMarca.SelectedItem.ToString();
            if (!checkBox5.Checked) reg.Precio = float.Parse(newPrecio.Text);
            if (!checkBox6.Checked) reg.Descripcion = newDesc.Text;
            this.Close();
        }



    }
}
