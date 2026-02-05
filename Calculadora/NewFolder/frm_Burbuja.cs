using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class frm_Burbuja : Form
    {
        public frm_Burbuja()
        {
            InitializeComponent();
        }


        private void btn_ordenar_Click(object sender, EventArgs e)
        {
            int[] ordenado = new int[dgv_desordenado.RowCount-1];
            //cargar el array con los datos de datagridview

            for(int i=0; i < dgv_desordenado.RowCount; i++)
            {
                ordenado[i] = Convert.ToInt32(dgv_desordenado.Rows[i].Cells[0].Value);
            }
        }
    }
}
