using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Winforms_Pro_3
{
    class Articulo
    {
        private int CodArt;
        private string Nombre;
        private string Descripcion;
        private string Marca;
        private string Categoria;
        private string ImagenLink;
        private float Precio;

        //seters y geters
        public string setGetNombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }
        public int Codigo{
            get { return CodArt; }
            set { CodArt = value;  }
        }
        public String SetGetDescripcion
        {
            get { return Descripcion; }
            set { Descripcion = value; }
        }
        public String SetGetMarca
        {
            get { return Marca; }
            set { Marca = value; }
        }
        public String SetGetCategoria
        {
            get { return Categoria; }
            set { Categoria = value; }
        }
        public String SetGetImagen
        {
            get { return ImagenLink; }
            set { ImagenLink = value; }
        }
        public float SetGetPrecio
        {
            get { return Precio; }
            set { Precio = value; }
        }

        //Constructor
        public Articulo()
        {
        }
    }
}
