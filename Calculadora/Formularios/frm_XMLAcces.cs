using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Calculadora.Formularios
{
    public partial class frm_XMLAcces : Form
    {

        public frm_XMLAcces()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            XElement xml = new XElement("Personas");


            for (int i = 0; i < dtg_personas.Rows.Count; i++)
            {
                xml.Add(
                    new XElement("persona",
                        new XElement("id", dtg_personas.Rows[i].Cells[0].Value),
                            new XElement("Nombre", dtg_personas.Rows[i].Cells[1].Value),
                            new XElement("Telefono", dtg_personas.Rows[i].Cells[2].Value)));

            }
            try
            {
                xml.Save("Archivo.xml");
                MessageBox.Show("Archivo XML guardado exitosamente.", "sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }
        }
            
        

        private void dtg_personas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
