using System.ComponentModel.DataAnnotations;

namespace TechStore.Models
{
    public class Producto
    {
        [Display(Name = "Nombre del Producto")]
        [Required(ErrorMessage = "El campo del nombre producto es obligatorio.")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion del Producto")]
        [Required(ErrorMessage = "El campo de la descripcion es obligatorio.")]
        public string Descripcion { get; set; }

        [Display(Name = "Precio del producto")]
        [Required(ErrorMessage = "El campo del precio es obligatorio.")]
        public double Precio { get; set; }

        public double IGV()
        {
            return Precio * 0.18;
        }
    }
}
