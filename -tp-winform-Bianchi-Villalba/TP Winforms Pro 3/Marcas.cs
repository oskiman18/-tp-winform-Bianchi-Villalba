using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace TP_Winforms_Pro_3
{
    public class Marcas
    {
        public int id { get; set; }
        public String nombre { get; set; }

        public Marcas(int ID, string desc)
        {
            id = ID;
            nombre = desc;
        }

        public Marcas() { }
        
        public override string ToString()
        {
            return nombre;
        }

        public List<Marcas> Listar()
        {
            SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True");
            SqlCommand comando = new SqlCommand("Select * from Marcas", conexion);
            SqlDataReader lector;
            List<Marcas> lista = new List<Marcas>();

            conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True";
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new Marcas((int)lector["Id"], (string)lector["Descripcion"]));
            }
            lector.Close();
            return lista;

        }

    }
}
