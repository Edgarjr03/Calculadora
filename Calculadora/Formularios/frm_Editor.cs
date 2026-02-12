using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Calculadora
{
    public partial class frm_Editor : Form
    {
        bool save = false;
        string path = "";
        int Contador_palabras = 0;
        string texto = "";
        public frm_Editor()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            texto = rtx_Editor.Text;
            string[] palabras = texto.Split(new char[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            tss_Status.Text = palabras.Length.ToString() + " palabras";

        }

        private void abrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofd_editor.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(ofd_editor.FileName))
                {
                    rtx_Editor.Text = File.ReadAllText(ofd_editor.FileName);
                }
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (save == false)
            {
                Guardar();
                save = true;
            }
            else
            {
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtx_Editor.Text);
                }
            }
        }


        private void nuevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtx_Editor.Clear();
            path = "";
            save = false;
        }

        private void Guardar()
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                path = saveFileDialog1.FileName;
                using (StreamWriter archivo = new StreamWriter(path))
                {
                    archivo.Write(rtx_Editor.Text);
                }

            }
        }

        private void guardarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tss_Status_Click(object sender, EventArgs e)
        {
            string[] parrafos = texto.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
            MessageBox.Show("Estadisticas: \n\nPalabras: " + tss_Status.Text + "\nLetras: " + texto.Length.ToString() +
                "\nParrafos: "
                + parrafos.Length.ToString(), "Contador de palabras");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
