using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiyokAPI.Models
{
    public class Provincia
    {
        [Key]
        public int ProvinciaId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }
        public int PaisId { get; set; }
        public virtual Pais Pais { get; set; }        
    }
}
