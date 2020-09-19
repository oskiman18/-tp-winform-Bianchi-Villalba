using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_Winforms_Pro_3
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            //objetos
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            //configuro la conexión y el tipo de comando a ejecutar
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = "select * from ARTICULOS";
            //select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.IdMarca, A.IdCategoria, A.ImagenUrl, A.Precio from ARTICULOS as A
            comando.Connection = conexion;

            //ejecuto
            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Articulo aux = new Articulo();

                aux.Id = (int)lector["Id"];
                aux.Codigo = lector.GetString(1);
                aux.Nombre = lector.GetString(2);
                aux.Descripcion = (string)lector["Descripcion"];
                aux.IdMarca = lector.GetInt32(4);
                aux.IdCategoria = lector.GetInt32(5);
                aux.Imagen = (string)lector["ImagenUrl"];
                aux.Precio = lector.GetSqlMoney(7);

                //agregro a la lista el obj cargado arriba
                lista.Add(aux);
            }
            conexion.Close();
            return lista;
        }
    }
}
