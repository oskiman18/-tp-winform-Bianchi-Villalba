using System;
namespace TP_Winforms_Pro_3
{
    class Articulo
    {
        private int codArt;
        private string nombre;
        private string descripcion;
        private string IDMarca;
        private string IDCategoria;
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
            get { return IDMarca; }
            set { IDMarca = value; }
        }
        public String Categoria
        {
            get { return IDCategoria; }
            set { IDCategoria = value; }
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
            this.IDMarca = marca;
            this.IDCategoria = categoria;
            this.imagenLink = imagenLink;
            this.precio = precio;
        }
    }
}

  

