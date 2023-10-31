using System.ComponentModel.DataAnnotations;

namespace Tarea6.Shared;

public class Cliente
{
    [Key]
    public int ClienteId { get; set; }

    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "El nombre solo debe contener letras y espacios.")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "La dirección es obligatoria.")]
    [MaxLength(100, ErrorMessage = "La dirección no puede tener más de 100 caracteres.")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "La ciudad es obligatoria.")]
    [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "La ciudad solo debe contener letras y espacios.")]
    public string? Ciudad { get; set; }

    [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
    [EmailAddress(ErrorMessage = "El correo electrónico no es válido.")]
    public string? Email { get; set; }

    [Required(ErrorMessage = "El número de tarjeta no es válido.")]
    [CreditCard(ErrorMessage = "El número de tarjeta no es válido.")]
    public string? NumeroTarjeta { get; set; }

}
