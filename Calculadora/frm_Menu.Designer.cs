namespace Calculadora
{
    partial class frm_Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mns_Principal = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            salirToolStripMenuItem = new ToolStripMenuItem();
            aplicacionesToolStripMenuItem = new ToolStripMenuItem();
            calculadoraSimpleToolStripMenuItem = new ToolStripMenuItem();
            ordenaToolStripMenuItem = new ToolStripMenuItem();
            burbujaToolStripMenuItem = new ToolStripMenuItem();
            registroToolStripMenuItem = new ToolStripMenuItem();
            mns_Principal.SuspendLayout();
            SuspendLayout();
            // 
            // mns_Principal
            // 
            mns_Principal.ImageScalingSize = new Size(24, 24);
            mns_Principal.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem, aplicacionesToolStripMenuItem });
            mns_Principal.Location = new Point(0, 0);
            mns_Principal.Name = "mns_Principal";
            mns_Principal.Size = new Size(800, 33);
            mns_Principal.TabIndex = 0;
            mns_Principal.Text = "menuStrip1";
            mns_Principal.ItemClicked += menuStrip1_ItemClicked;
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            archivoToolStripMenuItem.Click += archivoToolStripMenuItem_Click;
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(147, 34);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // aplicacionesToolStripMenuItem
            // 
            aplicacionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { calculadoraSimpleToolStripMenuItem, ordenaToolStripMenuItem, registroToolStripMenuItem });
            aplicacionesToolStripMenuItem.Name = "aplicacionesToolStripMenuItem";
            aplicacionesToolStripMenuItem.Size = new Size(126, 29);
            aplicacionesToolStripMenuItem.Text = "Aplicaciones";
            // 
            // calculadoraSimpleToolStripMenuItem
            // 
            calculadoraSimpleToolStripMenuItem.Name = "calculadoraSimpleToolStripMenuItem";
            calculadoraSimpleToolStripMenuItem.Size = new Size(270, 34);
            calculadoraSimpleToolStripMenuItem.Text = "Calculadora simple";
            calculadoraSimpleToolStripMenuItem.Click += calculadoraSimpleToolStripMenuItem_Click;
            // 
            // ordenaToolStripMenuItem
            // 
            ordenaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { burbujaToolStripMenuItem });
            ordenaToolStripMenuItem.Name = "ordenaToolStripMenuItem";
            ordenaToolStripMenuItem.Size = new Size(270, 34);
            ordenaToolStripMenuItem.Text = "Ordenamientos";
            // 
            // burbujaToolStripMenuItem
            // 
            burbujaToolStripMenuItem.Name = "burbujaToolStripMenuItem";
            burbujaToolStripMenuItem.Size = new Size(174, 34);
            burbujaToolStripMenuItem.Text = "Burbuja";
            burbujaToolStripMenuItem.Click += burbujaToolStripMenuItem_Click;
            // 
            // registroToolStripMenuItem
            // 
            registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            registroToolStripMenuItem.Size = new Size(270, 34);
            registroToolStripMenuItem.Text = "Registro";
            registroToolStripMenuItem.Click += registroToolStripMenuItem_Click;
            // 
            // frm_Menu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mns_Principal);
            MainMenuStrip = mns_Principal;
            Name = "frm_Menu";
            Text = "Form1";
            Load += frm_Menu_Load;
            mns_Principal.ResumeLayout(false);
            mns_Principal.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mns_Principal;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem aplicacionesToolStripMenuItem;
        private ToolStripMenuItem salirToolStripMenuItem;
        private ToolStripMenuItem calculadoraSimpleToolStripMenuItem;
        private ToolStripMenuItem ordenaToolStripMenuItem;
        private ToolStripMenuItem burbujaToolStripMenuItem;
        private ToolStripMenuItem registroToolStripMenuItem;
    }
}
