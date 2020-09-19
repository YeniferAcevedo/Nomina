using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NominaEmpleados
{
    public partial class Form1 : Form
    {
        Aumento aumento = new Aumento();
        public Form1()
        {
            InitializeComponent();
        }

        private void btbCalcularSalarioFinal_Click(object sender, EventArgs e)
        {
            aumento.setAntiguedad(double.Parse(txtAntiguedad.Text));
            aumento.setSalarioBase(double.Parse(txtSalarioBase.Text));
            lblSalarioFinal.Visible = true;
            lblSalarioFinal.Text = Convert.ToString("Salario Final: " + string.Format("{0:n0}", aumento.calcularSalarioFinal()));

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtSalarioBase.Text = string.Empty;
            txtAntiguedad.Text = string.Empty;
            lblSalarioFinal.Text = string.Empty;
            txtSalarioBase.Focus();
        }
    }
}
