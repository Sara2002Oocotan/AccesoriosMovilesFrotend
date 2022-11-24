using System.ComponentModel.DataAnnotations;

namespace AccesoriosMoviles.Frontend.Models
{
    public class Producto
    {

        public int Id { get; set; }
        public int IdCategoria { get; set; }
       
        public string Nombre { get; set; }
       
        public double Precio { get; set; }
        
        public string Imagen { get; set; }
        
        public string Descripcion { get; set; }
    }
}