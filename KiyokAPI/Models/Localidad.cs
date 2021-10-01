using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KiyokAPI.Models
{
    public class Localidad
    {
        [Key]
        public int LocalidadId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Nombre { get; set; }

        public int ProvinciaId { get; set; }
        public virtual Provincia Provincia { get; set; }
    }
}
