using System.ComponentModel.DataAnnotations.Schema;

namespace Rio.Tenis.Backend.Models
{
    [Table("Zapatos")]
    public class Zapato
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Genero { get; set; }
        public string Referencia { get; set; }
        public float Talla { get; set; }

    }
}
