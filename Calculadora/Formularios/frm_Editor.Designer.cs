namespace Calculadora
{
    partial class frm_Editor
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
            mns_editor = new MenuStrip();
            archivoToolStripMenuItem = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            guardarToolStripMenuItem = new ToolStripMenuItem();
            guardarComoToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            salirToolStripMenuItem = new ToolStripMenuItem();
            sts_editor = new StatusStrip();
            tss_Status = new ToolStripStatusLabel();
            rtx_Editor = new RichTextBox();
            ofd_editor = new OpenFileDialog();
            saveFileDialog1 = new SaveFileDialog();
            mns_editor.SuspendLayout();
            sts_editor.SuspendLayout();
            SuspendLayout();
            // 
            // mns_editor
            // 
            mns_editor.ImageScalingSize = new Size(24, 24);
            mns_editor.Items.AddRange(new ToolStripItem[] { archivoToolStripMenuItem });
            mns_editor.Location = new Point(0, 0);
            mns_editor.Name = "mns_editor";
            mns_editor.Size = new Size(800, 33);
            mns_editor.TabIndex = 0;
            mns_editor.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            archivoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, guardarToolStripMenuItem, guardarComoToolStripMenuItem, toolStripSeparator1, salirToolStripMenuItem });
            archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            archivoToolStripMenuItem.Size = new Size(88, 29);
            archivoToolStripMenuItem.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(270, 34);
            nuevoToolStripMenuItem.Text = "Nuevo";
            nuevoToolStripMenuItem.Click += nuevoToolStripMenuItem_Click;
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(270, 34);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // guardarToolStripMenuItem
            // 
            guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            guardarToolStripMenuItem.Size = new Size(270, 34);
            guardarToolStripMenuItem.Text = "Guardar";
            guardarToolStripMenuItem.Click += guardarToolStripMenuItem_Click;
            // 
            // guardarComoToolStripMenuItem
            // 
            guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            guardarComoToolStripMenuItem.Size = new Size(270, 34);
            guardarComoToolStripMenuItem.Text = "Guardar Como";
            guardarComoToolStripMenuItem.Click += guardarComoToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(267, 6);
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new Size(270, 34);
            salirToolStripMenuItem.Text = "Salir";
            salirToolStripMenuItem.Click += salirToolStripMenuItem_Click;
            // 
            // sts_editor
            // 
            sts_editor.ImageScalingSize = new Size(24, 24);
            sts_editor.Items.AddRange(new ToolStripItem[] { tss_Status });
            sts_editor.Location = new Point(0, 402);
            sts_editor.Name = "sts_editor";
            sts_editor.Size = new Size(800, 32);
            sts_editor.TabIndex = 1;
            sts_editor.Text = "statusStrip1";
            // 
            // tss_Status
            // 
            tss_Status.Name = "tss_Status";
            tss_Status.Size = new Size(77, 25);
            tss_Status.Text = "Palabras";
            tss_Status.Click += tss_Status_Click;
            // 
            // rtx_Editor
            // 
            rtx_Editor.Location = new Point(0, 39);
            rtx_Editor.Name = "rtx_Editor";
            rtx_Editor.Size = new Size(800, 360);
            rtx_Editor.TabIndex = 2;
            rtx_Editor.Text = "";
            rtx_Editor.TextChanged += richTextBox1_TextChanged;
            // 
            // ofd_editor
            // 
            ofd_editor.FileName = "ofd_Editor";
            ofd_editor.Filter = "\"Archivos de texto\"|*.txt";
            // 
            // frm_Editor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 434);
            Controls.Add(rtx_Editor);
            Controls.Add(sts_editor);
            Controls.Add(mns_editor);
            MainMenuStrip = mns_editor;
            Name = "frm_Editor";
            Text = "Editor de texto";
            mns_editor.ResumeLayout(false);
            mns_editor.PerformLayout();
            sts_editor.ResumeLayout(false);
            sts_editor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mns_editor;
        private StatusStrip sts_editor;
        private RichTextBox rtx_Editor;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem guardarToolStripMenuItem;
        private ToolStripMenuItem guardarComoToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem salirToolStripMenuItem;
        private OpenFileDialog ofd_editor;
        private SaveFileDialog saveFileDialog1;
        private ToolStripStatusLabel tss_Status;
    }
}