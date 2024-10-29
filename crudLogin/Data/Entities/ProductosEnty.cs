using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudLogin.Data.Entities
{ 

    [Table ("productos")]
    public class ProductosEnty
    {
        [Key]
        public int id { get; set; }
        public string? SKU { get; set; }
        public string? name { get; set; } 
        [Required]  public string? pictures {  get; set; }
         public string? price { get; set; }
        public string? currency { get; set; }
        public string? code { get; set; }
        public string? description { get; set; }

    }
}
