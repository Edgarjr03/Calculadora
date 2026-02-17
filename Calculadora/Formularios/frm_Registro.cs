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

    public partial class frm_Registro : Form
    {
        List<Personas> persona = new List<Personas>();
        public frm_Registro()
        {
            InitializeComponent();
        }



        private void RegistrarB_Click(object sender, EventArgs e)
        {
            persona.Add(new Personas()
            {
                Nombre = Txb_Nombre.Text,
                Apellido = Txb_Apellido.Text,
                Fecha = Fecha.Value
            });
            MessageBox.Show("Registro Exitoso");

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;

            }
        }

        private void Btn_registrar_Click(object sender, EventArgs e)
        {
            persona.Add(new Personas()
            {
                Nombre = Txb_Nombre.Text,
                Apellido = Txb_Apellido.Text,
                Fecha = Fecha.Value
            });
            MessageBox.Show("Registro Exitoso");
        }

        private void tabControl1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                dgvPersonas.DataSource = null;
                dgvPersonas.DataSource = persona;
                verificarRegistros();
            }
        }

        private void verificarRegistros()
        {
            if (persona.Count == 0)
            {
                btn_eliminar.Enabled = false;
            }else { 
                btn_eliminar.Enabled = true;

            }

        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            persona.RemoveAt(dgvPersonas.CurrentRow.Index);
            dgvPersonas.DataSource = null;
            dgvPersonas.DataSource = persona;
            verificarRegistros();
        }

        
    }
}
