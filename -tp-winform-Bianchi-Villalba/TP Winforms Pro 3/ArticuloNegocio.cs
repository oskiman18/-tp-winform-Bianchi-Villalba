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
        public List<Articulo> listar(string query)
        {
            //objetos
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            //configuro la conexión y el tipo de comando a ejecutar
            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
            comando.Connection = conexion;

            //ejecuto
            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Articulo aux = new Articulo();

                aux.Id = lector.GetInt32(0);
                aux.Codigo = lector.GetString(1);
                aux.Nombre = lector.GetString(2);
                aux.Descripcion = (string)lector["Descripcion"];
                aux.IdMarca = lector.GetInt32(4);
                aux.IdCategoria = lector.GetInt32(5);
                aux.ImagenUrl = (string)lector["ImagenUrl"];
                aux.Precio = lector.GetSqlMoney(7);

                //agregro a la lista el obj cargado arriba
                lista.Add(aux);
            }
            conexion.Close();
            return lista;
        }


        public List<Articulo> listarJoin(string query)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;
            List<Articulo> lista = new List<Articulo>();

            conexion.ConnectionString = "server =.\\SQLEXPRESS; database = CATALOGO_DB; Integrated Security = True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
            comando.Connection = conexion;
            //select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS
            //          0       1       2           3           4                           5                       6           7

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Articulo art = new Articulo();

                art.Id = lector.GetInt32(0);
                art.Codigo = lector.GetString(1);
                art.Nombre = lector.GetString(2);
                art.Descripcion = lector.GetString(3);
                art.Marca = lector.GetString(4);
                art.Categoria = lector.GetString(5);
                art.ImagenUrl = lector.GetString(6);
                art.Precio = lector.GetSqlMoney(7);

                lista.Add(art);

            }
            conexion.Close();
            return lista;
        }
        public bool Eliminar(string query)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "Server=.\\SQLEXPRESS; Database = CATALOGO_DB; Integrated Security =True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
            comando.Connection = conexion;

            conexion.Open();
            try
            {
                lector = comando.ExecuteReader();
                conexion.Close();
                return true;
            }
            catch (Exception)
            {
                conexion.Close();
                return false;
            }
        }

        public Articulo ArticuloDetalle(string query)
        {
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            conexion.ConnectionString = "Server=.\\SQLEXPRESS; Database = CATALOGO_DB; Integrated Security =True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = query;
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            //select A.Id, A.Codigo, A.Nombre, A.Descripcion, M.Descripcion as Marca, C.Descripcion as Categoria, A.ImagenUrl, A.Precio from ARTICULOS
            //          0       1       2           3           4                           5                       6           7

            Articulo art = new Articulo();
            while (lector.Read())
            {
                
                art.Id = lector.GetInt32(0);
                art.Codigo = lector.GetString(1);
                art.Nombre = lector.GetString(2);
                art.Descripcion = lector.GetString(3);
                art.Marca = lector.GetString(4);
                art.Categoria = lector.GetString(5);
                art.ImagenUrl = lector.GetString(6);
                art.Precio = lector.GetSqlMoney(7);

            }
            conexion.Close();
            return art;
        }

        public void Modificarart(Articulo reg)
        {
            ConexionSQL conexion = new ConexionSQL();
            string query = "update ARTICULOS  Set codigo=@codigo,nombre =@nombre, descripcion= @descripcion, idmarca=@idmarca, idcategoria=@idcategoria, imagenurl=@imagenurl, precio=@precio where id=@id";
            conexion.Abir();
            SqlCommand comando = new SqlCommand(query, conexion.directorio);

            comando.Parameters.AddWithValue("@Codigo", reg.Codigo);
            comando.Parameters.AddWithValue("@Nombre", reg.Nombre);
            comando.Parameters.AddWithValue("@Descripcion", reg.Descripcion);
            comando.Parameters.AddWithValue("@IdMarca", reg.IdMarca);
            comando.Parameters.AddWithValue("@IdCategoria", reg.IdCategoria);
            comando.Parameters.AddWithValue("@ImagenUrl", reg.ImagenUrl);
            comando.Parameters.AddWithValue("@Precio", reg.Precio);
            comando.Parameters.AddWithValue("@id", reg.Id);
            comando.ExecuteNonQuery();
        }


    }
}
