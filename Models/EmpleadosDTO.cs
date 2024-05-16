
using System.ComponentModel.DataAnnotations;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Reflection;

namespace PruebaNet8_BlazorServer_AndresCueva.Models
{
    public class EmpleadosDTO
    {
       // public EmpleadosDTO() { }
        [Key]
        public string ? NDimemp { get; set; }  // varchar(12)
        [Required]
        [StringLength(maximumLength: 30)]
        public string? nomEmp { get; set; }  //30
        [Required]
        [StringLength(maximumLength: 1)]
        public string? sexEmp { get; set; }  // char 1
        [Required]
        public DateTime FecNac { get; set; }  //Date
        public float salEmp { get; set; }  //float
        public float comisionE { get; set; }  //float
        [Required]
        [StringLength(maximumLength: 15)]
        public string? cargoE { get; set; }  //varchar(15)
        [Required]
        [StringLength(maximumLength: 12)]
        public string? jefeID { get; set; }  //varchar(12)
        [Required]
        [StringLength(maximumLength: 14)]
        public string? codDepto { get; set; }  //varchar(14)

    }
    //Relacion logica para las tablas
 
}
