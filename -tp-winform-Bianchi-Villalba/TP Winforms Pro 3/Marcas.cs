using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable CargarCbox()
        {
          /*  string directorio = "server=.\\SQLEXPRESS; database=CATALOGO_DB; Integrated Security=True";
            SqlConnection conexion = new SqlConnection(directorio);
            SqlCommand comando = new SqlCommand("Select * from Marcas", conexion);
            SqlDataReader lector;
            List<Marcas> lista = new List<Marcas>();

            conexion.ConnectionString = directorio;
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

            conexion.Open();
            lector = comando.ExecuteReader();
            while (lector.Read())
            {
                lista.Add(new Marcas((int)lector["Id"], (string)lector["Descripcion"]));
            }
            lector.Close();
            return lista;*/
            
            string query = "select Id, Descripcion from MARCAS";
            ConexionSQL conexion = new ConexionSQL();
            conexion.Abir();
            SqlCommand comando = new SqlCommand(query, conexion.directorio);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            conexion.Cerrar();

            return tabla;   

        }

    }
}
