using System.ComponentModel.DataAnnotations;

namespace PruebaNet8_BlazorServer_AndresCueva.Models
{
    public class DepartamentosDTO
    {
        [Key]
        public required string codDepto { get; set; }  // varchar(4)
        [Required]
        [StringLength(maximumLength: 20)]
        public string? nombreDpto { get; set; }  //20
        [Required]
        [StringLength(maximumLength: 15)]
        public string? ciudad { get; set; }  // varchar 15
        [Required]
        public string? codDirector { get; set; }  // varchar(12)
                                                  //Relacion logica para las tablas
        public virtual ICollection<EmpleadosDTO>? EmpleadosRelacion { get; set; }
    }
}
