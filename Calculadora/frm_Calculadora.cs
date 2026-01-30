using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frm_Calculadora : Form
    {
        public frm_Calculadora()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try {
                Double a = 0, b = 0, resultado = 0;
                a = Convert.ToDouble(TxtVariableA.Text);
                b = double.Parse(TxtVariableB.Text);

                resultado = a + b;
                MessageBox.Show("El resultado es: " + resultado.ToString(),"sistema",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch(Exception){
                MessageBox.Show("Error en la conversion de datos","sistema",MessageBoxButtons.OK,MessageBoxIcon.Error);

            }
           

            


        }
    }
}
