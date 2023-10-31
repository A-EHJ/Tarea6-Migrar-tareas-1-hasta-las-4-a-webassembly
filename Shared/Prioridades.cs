using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea6.Shared
{
    public class Prioridades
    {
        [Key]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "La descripción es requerida")]
        public string? Descripcion { get; set; }
        [Range(1, int.MaxValue, ErrorMessage = "Los días de compromiso deben ser mayores que 1")]
        public int DiasCompromiso { get; set; }
    }
}
