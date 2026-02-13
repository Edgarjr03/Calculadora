namespace Calculadora
{
    partial class frm_temporizadores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lbl_hora = new Label();
            tmr_Hora = new System.Windows.Forms.Timer(components);
            mns_Alarma = new MenuStrip();
            establecerToolStripMenuItem = new ToolStripMenuItem();
            alarma1ToolStripMenuItem = new ToolStripMenuItem();
            mns_Alarma.SuspendLayout();
            SuspendLayout();
            // 
            // lbl_hora
            // 
            lbl_hora.AutoSize = true;
            lbl_hora.Font = new Font("Arial", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_hora.Location = new Point(67, 37);
            lbl_hora.Name = "lbl_hora";
            lbl_hora.Size = new Size(425, 81);
            lbl_hora.TabIndex = 0;
            lbl_hora.Text = "00:00:00 x.x";
            lbl_hora.Click += lbl_hora_Click;
            // 
            // tmr_Hora
            // 
            tmr_Hora.Enabled = true;
            tmr_Hora.Interval = 1000;
            tmr_Hora.Tick += tmr_Hora_Tick;
            // 
            // mns_Alarma
            // 
            mns_Alarma.ImageScalingSize = new Size(24, 24);
            mns_Alarma.Items.AddRange(new ToolStripItem[] { establecerToolStripMenuItem });
            mns_Alarma.Location = new Point(0, 0);
            mns_Alarma.Name = "mns_Alarma";
            mns_Alarma.Size = new Size(630, 33);
            mns_Alarma.TabIndex = 1;
            mns_Alarma.Text = "menuStrip1";
            // 
            // establecerToolStripMenuItem
            // 
            establecerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { alarma1ToolStripMenuItem });
            establecerToolStripMenuItem.Name = "establecerToolStripMenuItem";
            establecerToolStripMenuItem.Size = new Size(107, 29);
            establecerToolStripMenuItem.Text = "Establecer";
            establecerToolStripMenuItem.Click += establecerToolStripMenuItem_Click;
            // 
            // alarma1ToolStripMenuItem
            // 
            alarma1ToolStripMenuItem.Name = "alarma1ToolStripMenuItem";
            alarma1ToolStripMenuItem.Size = new Size(270, 34);
            alarma1ToolStripMenuItem.Text = "Alarma 1";
            alarma1ToolStripMenuItem.Click += alarma1ToolStripMenuItem_Click;
            // 
            // frm_temporizadores
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 164);
            Controls.Add(lbl_hora);
            Controls.Add(mns_Alarma);
            MainMenuStrip = mns_Alarma;
            Name = "frm_temporizadores";
            Text = "Relog";
            mns_Alarma.ResumeLayout(false);
            mns_Alarma.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_hora;
        private System.Windows.Forms.Timer tmr_Hora;
        private MenuStrip mns_Alarma;
        private ToolStripMenuItem establecerToolStripMenuItem;
        private ToolStripMenuItem alarma1ToolStripMenuItem;
    }
}