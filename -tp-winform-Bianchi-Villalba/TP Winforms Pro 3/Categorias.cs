using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TP_Winforms_Pro_3
{
    class Categorias
    {

        public int id { get; set; }

        public String nombre { get; set; }

        public Categorias(int ID, string desc)
        {
            id = ID;
            nombre = desc;
        }
        public Categorias(){}

        public override string ToString()
        {
            return nombre;
        }


        public List<Categorias> Listar()
        {
            SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from Categorias", conexion);
            SqlDataReader lector;
            List<Categorias> lista = new List<Categorias>();

            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new Categorias((int)lector["Id"], (string)lector["Descripcion"]));
            }
            lector.Close();
            return lista;

        }




    }
}
