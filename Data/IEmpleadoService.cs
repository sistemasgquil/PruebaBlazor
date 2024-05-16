using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PruebaNet8_BlazorServer_AndresCueva.Models;

namespace PruebaNet8_BlazorServer_AndresCueva.Data
{
    public interface IEmpleadoService
    {
        Task<IEnumerable<EmpleadosDTO>> GetAllEmpleados();
        //Task<IEnumerable> GetById(string ? nDimemp);//id
        Task<EmpleadosDTO ?> GetById(string nDimemp);//id
        Task<bool> InsertEmpleado(EmpleadosDTO empleados);
        Task<bool> UpdateEmpleado(EmpleadosDTO empleados);
        Task<bool> DeleteEmpleado(string nDimemp);
        Task<bool> SaveEmpleado(EmpleadosDTO empleados);
  
    }
}
