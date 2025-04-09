using System.ComponentModel.DataAnnotations;

namespace Componentes.Components.Data
{
    public class Producto
    {
        [Required(ErrorMessage = "El número de inventario no puede ser 0")]
        [Range(1, int.MaxValue, ErrorMessage = "El número debe ser positivo.")]
        public int Inventario { get; set; }

        [Required(ErrorMessage = "El nombre del producto no puede ser vacio.")]
        [StringLength(200, ErrorMessage = "Máximo de 200 carácteres.")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Debe seleccionar un departamento.")]
        public string Departamento { get; set; } = string.Empty;
    }
}