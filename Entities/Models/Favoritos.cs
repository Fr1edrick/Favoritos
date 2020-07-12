using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models
{
  [Table("Favoritos")]
  public class Favoritos
  {
    [Column("ItemId")]
    [Key]
    public int Id { get; set; }

    [Column("AlbumId")]
    [Required(ErrorMessage = "Id del Album Requerido")]
    public int AlbumId { get; set; }

    [Column("GustoName")]
    public string GustoName { get; set; }

    [Column("UserId")]
    [ForeignKey(nameof(User))]
    public int UserId { get; set; }
    public User User { get; set; }

  }
}
