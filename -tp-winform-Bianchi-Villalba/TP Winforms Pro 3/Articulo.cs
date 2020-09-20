namespace TP_Winforms_Pro_3
{
    public class Articulo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }
        public string Marca { get; set; }
        public string Categoria { get; set; }
        public string Imagen { get; set; }
        public System.Data.SqlTypes.SqlMoney Precio { get; set; }

        //Constructor
        public Articulo()
        {

        }
    }

}



