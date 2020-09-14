using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Winforms_Pro_3
{
    public partial class Modificar : Form
    {
        Articulo aux = new Articulo();
        public Modificar()
        {
            InitializeComponent();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {
            

            codArt.Text = aux.Codigo.ToString();
            nomArt.Text = aux.Nombre;
            catArt.Text = aux.Categoria;
            marcArt.Text = aux.Marca;
            precArt.Text = aux.Precio.ToString();
            descArt.Text = aux.Descripcion;
            if (checkBox1.Checked) aux.Codigo = int.Parse(newCod.Text);
            if (checkBox2.Checked) aux.Nombre = newNombre.Text;
            if (checkBox3.Checked) aux.Categoria = newCat.SelectedItem.ToString();
        }

        private void clickCancelar(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void clickConfirmar(object sender, MouseEventArgs e)
        {
            

            this.Close();
        }
    }
}
