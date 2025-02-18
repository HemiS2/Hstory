using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GStore.Models;

public class Usuario : IdentityUser
{
    [Required(ErrorMessage = "Qual a porra do teu nome?")]
    [StringLength(60, ErrorMessage = "Nome longo aqui não, no maximo 60 letras krlh, você não é a porra do alfabeto")]
    public string Nome { get; set; }
    
    [Display(Name = "Quando ti nasceu?")]
    [DataType(DataType.Date)]
    public DateTime DataNascimento { get; set; }

    [StringLength(200)]
    public string Foto { get; set;}
}