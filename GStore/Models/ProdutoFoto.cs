using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GStore.Models;

[Table("produto_foto")]
public class ProdutoFoto
{
    [Key]
    public int Id { get; set; }

    [Display(Name = "Produto")]
    [Required(ErrorMessage = "Por favorm informe o produto")]
    public int ProdutoId { get; set; }
    [ForeignKey("ProdutoId")]
    public Produto Produto { get; set; }
    
    [Display(Name = "Foto")]
    [StringLength(200)]
    [Required(ErrorMessage = "Fala ai o nome dessa porra")]
    public string ArquivoFoto { get; set; }

    [Display(Name = "Descrição")]
    [StringLength(100, ErrorMessage = "Puta descrição grande")]
    public string Descricao { get; set; }

}