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
        }

        private void Agregar_Load(object sender, EventArgs e)
        {
            Categorias aux = new Categorias();
            boxCat.DataSource = aux.Listar();
            Marcas aux1 = new Marcas();
            boxMarca.DataSource = aux1.Listar();
                
        }


        
        public void CargarBoxs()
        {
            /* Agregar aux = new Agregar();
             int codArt = int.Parse(aux.boxCod.Text);
             string nombre = aux.boxCod.Text;
             string descripcion = aux.boxDesc.Text;
             string marca = aux.boxMarca.Text;
             string categoria = aux.boxCat.Text;
             string imagenLink = aux.boxImage.Text;
             float precio = float.Parse(aux.boxPrecio.Text);*/
            Articulo aux = new Articulo();
            aux.CargarArticulo(int.Parse(boxCod.Text), boxNombre.Text, boxDesc.Text, boxMarca.SelectedItem.ToString(), boxCat.SelectedItem.ToString(), boxImage.Text, float.Parse(boxPrecio.Text)); ;

            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
