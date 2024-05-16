using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using PruebaNet8_BlazorServer_AndresCueva.Models;
using System.Collections;
using System.Linq;

namespace PruebaNet8_BlazorServer_AndresCueva.Data
{
   

    public class EmpleadoService : IEmpleadoService
    {

         #region Variables
         
        private List<EmpleadosDTO> TblAEmpleado = new List<EmpleadosDTO>();
        private List<DepartamentosDTO> TblBDepa = new List<DepartamentosDTO>();

        #endregion

        #region"Injecto lo creado en DbContext"
        private readonly EmpleadoContext _context;
        public EmpleadoService(EmpleadoContext context)
        {
            _context = context;
        }


        #endregion


        public async Task<IEnumerable<EmpleadosDTO>?> GetAllEmpleados()
        {
            // aplico un inner join para coger LA data de ambas tablas y valido la data null
            var relacion = from a in TblAEmpleado
                           join b in TblBDepa on a.codDepto equals b.codDepto
                           select new EmpleadosDTO
                           {
                               
                               codDepto = a.codDepto
                          
                           };
            if (relacion == null) { return null; }
             return await _context.Empleados.ToListAsync();
            // return await relacion.ToListAsync();
        }

        public async Task<bool> DeleteEmpleado(string nDimemp)
        {
            if (nDimemp == string.Empty) { return false; }
            var idEmple  = await _context.Empleados.FindAsync(nDimemp);
            if (idEmple == null) {  return false; }
            _context.Empleados.Remove(idEmple);
            return await _context.SaveChangesAsync()>0; //true;
        }

      

        async Task<EmpleadosDTO?> IEmpleadoService.GetById(string nDimemp)
        {
            if (nDimemp == null) { return null; }
            return await _context.Empleados.FindAsync(nDimemp);
        }

        public async Task<bool> InsertEmpleado(EmpleadosDTO empleados)
        {
           _context.Empleados.Add(empleados);
            return await _context.SaveChangesAsync() > 0;

        }

        public async Task<bool> UpdateEmpleado(EmpleadosDTO empleados)
        {
            _context.Entry(empleados).State=EntityState.Modified;
            return await _context.SaveChangesAsync() > 0;

        }

        //Task<IEnumerable> IEmpleadoService.GetById(string? nDimemp)
        //{
        //    return await _context.Empleados.ToListAsync(nDimemp);
        //    // throw new NotImplementedException();
        //}
         //[Obsolete]
        public async Task<bool> SaveEmpleado(EmpleadosDTO empleados)
        {
            // lo uso para saber cuando llamo a insert o update, segun el caso. by Acueva 2024-05-15

            if(empleados == null) {  throw new NotImplementedException(); }
            if(empleados.NDimemp == null)
            {
                return await UpdateEmpleado(empleados);
            }
            else
            {
                return await InsertEmpleado(empleados);
            }
        }

       
    }
}
