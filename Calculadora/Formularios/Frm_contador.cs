using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora.Formularios
{
    public partial class Frm_contador : Form
    {
        int contador = 0;
        public Frm_contador()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tkr_velocidad.Enabled = true;
            tmr_contador.Interval = tkr_velocidad.Value * 200;
            tmr_contador.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmr_contador.Enabled = false;
            tkr_velocidad.Enabled = false;
        }

        private void tkr_velocidad_Scroll(object sender, EventArgs e)
        {
            tmr_contador.Interval = tkr_velocidad.Value * 200;
        }

        private void tmr_contador_Tick(object sender, EventArgs e)
        {
            contador++;
            lbl_cuenta.Text = contador.ToString();
        }
    }
}
