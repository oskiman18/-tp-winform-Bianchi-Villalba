using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Winforms_Pro_3;
using System.Data.SqlClient;

namespace Negocio
{
    //toda la logica de la app
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
                aux.Codigo = lector.GetString(1);
                aux.Nombre = lector.GetString(2);
                aux.Descripcion = lector.GetString(3);
                aux.Marca = lector.GetString(4);
                aux.Categoria = lector.GetString(5);
                aux.Imagen = lector.GetString(6);
                aux.Precio = lector.GetFloat(7);

                //agregro a la lista el obj cargado arriba
                lista.Add(aux);
            }
            conexion.Close();
            return lista;



            /*
            ConexionSQL conexion = new ConexionSQL(); //a donde me voy a conectar
            SqlCommand comando = new SqlCommand(); //que es lo que voy a hacer
            SqlDataReader lector; //data que vamos a leer
            List<Articulo> lista = new List<Articulo>();//lo que voy a devolver

            string query = "select * from ARTICULOS";
            conexion.EjecutarQuery(query);

            conexion.Abir();
            lector = comando.ExecuteReader();
            */


        }
    }
}
