using System.ComponentModel.DataAnnotations;

namespace Fina.Core.Requests.Categories;

public class CreateCategoryRequest : Request
{
    [Required(ErrorMessage = "Título Inválido")]
    [MaxLength(80, ErrorMessage = "O Título deve conter até 80 caracteres.")]
    [MinLength(5, ErrorMessage = "O título de ve conter o mínimo de 5 caracteres.")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Descrição inválida.")]
    public string Description { get; set; } = string.Empty;

}