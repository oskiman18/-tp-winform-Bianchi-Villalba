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
    }
}
