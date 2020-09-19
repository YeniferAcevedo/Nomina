using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NominaEmpleados
{
    public class Nomina
    {
        private double salarioBase;
        private double antiguedad;

        public void setSalarioBase(double valor)
        {
            salarioBase = valor;
        }

        public void setAntiguedad(double valor)
        {
            antiguedad = valor;
        }

        public double getSalarioBase()
        {
            return this.salarioBase;
        }

        public  double getAntiguedad()
        {
            return this.antiguedad;
        }
    }
}
