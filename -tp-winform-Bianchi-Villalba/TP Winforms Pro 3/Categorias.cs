﻿using System;
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
        ConexionSQL conexion = new ConexionSQL();


        
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


        public DataTable CargarCbox()
        {
            string query = "select Id, Descripcion from CATEGORIAS";
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
