using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Baza_wojskowa.Models
{
    public class Film
    {
        [Key]
        public int ID { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Tytul { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string Opis { get; set; }
        [Column(TypeName = "int")]
        public int Ocena { get; set; }
    }
}
