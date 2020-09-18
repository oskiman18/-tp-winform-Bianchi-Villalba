using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Winforms_Pro_3
{
    public partial class Busqueda : Form
    {
        public Busqueda()
        {
            InitializeComponent();
        }

        private void txbBusqueda_Load(object sender, EventArgs e)
        {

            ConexionSQL conexion = new ConexionSQL();
            cmbTabla.DataSource = conexion.ListarBusqueda();
            cmbTabla.DisplayMember = "nombre";
            cmbTabla.ValueMember = "id";
           

        }



        private void clickCancelar(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void clickBuscar(object sender, MouseEventArgs e)
        {
            Articulo reg = new Articulo();
            Buscador(Convert.ToInt32(cmbTabla.SelectedValue),cmbTabla.Text);
            Modificar ventana = new Modificar();
            ventana.CargarArticulo(reg);
            ventana.ShowDialog();
            this.Close();
            
          
        }


        private bool Buscador(int criterio, string pclave)
        {
            ConexionSQL con = new ConexionSQL();
            switch (criterio)
            {
                case 1: con.CargarBusqueda(criterio,pclave) ; break;
                case 2: ; break;
                case 3: MessageBox.Show(criterio.ToString()); break;
                case 4: MessageBox.Show(criterio.ToString()); break;
                case 5: MessageBox.Show(criterio.ToString()); break;
            }
            return true;

        }
    }
}
