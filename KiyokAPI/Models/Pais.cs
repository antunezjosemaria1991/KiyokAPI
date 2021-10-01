using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiyokAPI.Models
{
    public class Pais
    {
        [Key]
        public int PaisId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }        
    }
}
