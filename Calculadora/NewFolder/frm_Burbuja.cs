using Calculadora.Clases;
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
            Ordenamientos ordenamiento = new Ordenamientos();
            int[] ordenado = new int[dgv_desordenado.RowCount - 1];
            for (int i = 0; i < dgv_desordenado.RowCount; i++)
                for (int j = 0; i < dgv_desordenado.RowCount - 1; i++)
                {
                    ordenado[i] = Convert.ToInt32(dgv_desordenado.Rows[i].Cells[0].Value);
                }
            ordenado = ordenamiento.Burbuja(ref ordenado);

            //Define el tamaño de las filas de el DataGridView
            dgv_desordenado.DataSource = ordenado;

            //aqui llena el DataGridView con los valores del arreglo ya ordenados
            for (int i = 0; i < ordenado.Length; i++)
            {
                dgv_ordenado.Rows.Add();
                dgv_ordenado.Rows[i].Cells[0].Value = ordenado[i];
            }
        }
    }
}
