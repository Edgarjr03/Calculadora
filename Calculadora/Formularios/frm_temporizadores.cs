using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using CSCore.SoundOut;
using System.Media;

namespace Calculadora
{
    public partial class frm_temporizadores : Form
    {
        string alarma1 = "";
        DateTime horaAlarma;
        public frm_temporizadores()
        {
            InitializeComponent();
        }

        private void alarma1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string input = Interaction.InputBox("Ingrese la hora (HH:mm:ss): ", "Sistema", DateTime.Now.ToLongTimeString()); // Intentamos convertir el texto a DateTime
            
            if (DateTime.TryParse(input, out horaAlarma)) 
            { 
                alarma1 = input;
                MessageBox.Show("Alarma configurada a las " + horaAlarma.ToLongTimeString()); 
            } 
            else 
            { 
                MessageBox.Show("Formato inválido. Use HH:mm:ss"); 
            } 
        }


        private void tmr_Hora_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString(); // Comparamos solo la hora, minutos y segundos

            if (DateTime.Now.Hour == horaAlarma.Hour &&
                DateTime.Now.Minute == horaAlarma.Minute &&
                DateTime.Now.Second == horaAlarma.Second)
            {
                SoundPlayer player = new SoundPlayer(@"C:\Users\eddyd\source\repos\Calculadora\Calculadora\Sonidos\levantense-_saturado_-made-with-Voicemod.wav");
                player.Play();
            }
        }

        private void lbl_hora_Click(object sender, EventArgs e)
        {

        }


    } 
}
