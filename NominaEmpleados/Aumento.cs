using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaEmpleados
{
    public class Aumento : Nomina
    {
        public double calcularSalarioFinal()
        {
            double salarioFinal = 0;
            double antiguedad = this.getAntiguedad();

            if (antiguedad == 5)
            {
                 salarioFinal = (getSalarioBase() * 0.3) + this.getSalarioBase();

            }
            else if (antiguedad == 7)
            {
                salarioFinal = (getSalarioBase() * 0.4) + this.getSalarioBase();
            }
            else if (antiguedad == 10)
            {
                salarioFinal = (getSalarioBase() * 0.45) + this.getSalarioBase();
            }
            else if (antiguedad > 10)
            {
                salarioFinal = (getSalarioBase() * 0.5) + this.getSalarioBase();
            }

            return salarioFinal;
        }
    }
}
