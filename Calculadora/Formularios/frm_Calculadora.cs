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
            try
            {
                Double a = 0, b = 0, resultado = 0;
                a = Convert.ToDouble(TxtVariableA.Text);
                b = double.Parse(TxtVariableB.Text);

                if (rdb_suma.Checked)
                    resultado = a + b;
                if (rdb_resta.Checked)
                    resultado = a - b;
                if (rdb_multiplicacion.Checked)
                    resultado = a * b;
                if (rdb_division.Checked)
                    resultado = a / b;

                
                MessageBox.Show("El resultado es: " + resultado.ToString(), "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
               // Reset();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la conversion de datos", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }





        }

       // private void bteReset_Click(object sender, EventArgs e)
       // {
       //     TxtVariableA.Text = "";
       //   TxtVariableB.Clear();
       // }

        //se puede de las 2 formas 

        private void bteReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            TxtVariableA.Text = "";
            TxtVariableB.Clear();
            TxtVariableA.Focus();
        }
    }
}
