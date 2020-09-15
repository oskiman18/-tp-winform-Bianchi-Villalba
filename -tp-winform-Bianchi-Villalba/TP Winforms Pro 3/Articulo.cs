using System;
namespace TP_Winforms_Pro_3
{
    class Articulo
    {
        private int codArt;
        private string nombre;
        private string descripcion;
        private string marca;
        private string categoria;
        private string imagenLink;
        private float precio;

        //seters y geters
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public int Codigo
        {
            get { return codArt; }
            set { codArt = value; }
        }
        public String Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public String Marca
        {
            get { return marca; }
            set { marca = value; }
        }
        public String Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }
        public String Imagen
        {
            get { return imagenLink; }
            set { imagenLink = value; }
        }
        public float Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        //Constructor
        public Articulo()
        {

        }

        public void CargarArticulo(int codArt, string nombre, string descripcion, string marca,
                                   string categoria, string imagenLink, float precio)
        {
            this.codArt = codArt;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.marca = marca;
            this.categoria = categoria;
            this.imagenLink = imagenLink;
            this.precio = precio;
        }
    }
}

  

