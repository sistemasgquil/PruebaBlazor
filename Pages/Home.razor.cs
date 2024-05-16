using PruebaNet8_BlazorServer_AndresCueva.Data;  
using PruebaNet8_BlazorServer_AndresCueva.Models;

namespace PruebaNet8_BlazorServer_AndresCueva.Pages
{
    public partial class Home
    {
        public IEnumerable<EmpleadosDTO>? objemp { get; set; }
        public string? Message { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                Message = string.Empty;
                objemp = await empleadoservice.GetAllEmpleados();
                if(objemp== null) { Message = "Aun No hay registro en la base de datos"; return; }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error aplicativo: " + e.Message);
            }
        }
    }
}
