using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudLogin.Data.Entities
{
    [Table("usuarios")]

    public class Usuarios
    {
        [Key]
        public int Id { get; set; }
        public string? Username { get; set; }
        public string? Password_hash { get; set; } 
        public string? Email { get; set; }
        
    }
}
