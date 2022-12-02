using SistemaWebEmpleado.validations;

namespace SistemaWebEmpleado.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }    
        public string Apellido { get; set; }
        public string Dni { get; set; }
        [CheckLegajo]
        public string Legajo { get; set; }
        public string Titulo { get; set; }
        
    }
}
