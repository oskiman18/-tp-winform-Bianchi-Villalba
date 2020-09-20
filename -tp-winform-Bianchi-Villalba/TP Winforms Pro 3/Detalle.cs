using System;
using System.Data;
using System.Windows.Forms;

namespace TP_Winforms_Pro_3
{
    public partial class Detalle : Form
    {
        private int id { set; get; }
        public Detalle()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {   
            ArticuloNegocio artNeg = new ArticuloNegocio();
            string busqueda = tbBuscar.Text;
            string query = "select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS as A join MARCAS as M on A.IdMarca=M.Id join CATEGORIAS as C on A.IdCategoria=C.Id where A.Id like '%" + busqueda + "%' or A.Codigo like '%" + busqueda + "%' or A.Nombre like '%" + busqueda + "%' or A.Descripcion like '%" + busqueda + "%' or M.Descripcion like '%" + busqueda + "%' or C.Descripcion like '%" + busqueda + "%' or A.ImagenUrl like '%" + busqueda + "%' or A.Precio like '%" + busqueda + "%'";
            try
            {
                dgvDetalle.DataSource = artNeg.listarJoin(query);
                dgvDetalle.Columns[4].Visible = false;
                dgvDetalle.Columns[5].Visible = false;
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo listar el query");
            }
            
            Articulo art = (Articulo)dgvDetalle.CurrentRow.DataBoundItem;
            pbDetalle.Load(art.ImagenUrl);
        }
    }
}
