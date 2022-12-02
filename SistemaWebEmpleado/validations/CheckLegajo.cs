using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace SistemaWebEmpleado.validations
{
    public class CheckLegajo : ValidationAttribute
    {

        public CheckLegajo()
        {
            ErrorMessage = "El legajo debe comenzar con dos letras “AA” y 5 números.";
        }

        public override bool IsValid(object value)
        {
            string legajo = (string)value;

            if (legajo.Substring(0, 2) == "AA" && legajo.Length == 7)
            {

                return true;
            }
            else
            {
                return false;
            }
            }
        }
    } 
