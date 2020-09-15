using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_Winforms_Pro_3
{
    class ConexionSQL
    {
        public SqlConnection directorio;

        public ConexionSQL()
        {
           directorio = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
        }
        public void Abir()
        {
            directorio.Open();
        }
        public void Cerrar()
        {
            directorio.Close();
        }
        public void ListarTodo(DataTable tabla)
        {
            /*
            SqlCommand comando = new SqlCommand("select A.Id, A.Codigo,A.Nombre, C.Descripcion as Categoria, M.Descripcion as Marca,A.ImagenUrl as Imagen,A.Precio from ARTICULOS as A left join CATEGORIAS as C on C.Id=A.IdCategoria left join MARCAS as M on M.Id = A.IdMarca", conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter();
            adaptador.SelectCommand = comando;
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dgvArticulo.DataSource = tabla;
            */
        }


    }
}
