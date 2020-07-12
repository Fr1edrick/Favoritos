using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("Users")]
  public class User
  {
    [Column("UserId")]
    [Key]
    public int UserId { get; set; }

    [Column("UserName")]
    [Required(ErrorMessage = "Nombre requerido")]
    [StringLength(50, ErrorMessage = "Longitud del campo no mayor a 50 caracteres")]
    public string Nombre { get; set; }

    public ICollection<Favoritos> Favoritos { get; set; }
  }
}
