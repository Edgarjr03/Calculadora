namespace Calculadora
{
    partial class frm_Registro
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
            menuStrip1 = new MenuStrip();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            Btn_registrar = new Button();
            Fecha = new DateTimePicker();
            label3 = new Label();
            Txb_Apellido = new TextBox();
            label2 = new Label();
            Txb_Nombre = new TextBox();
            tbc_mostrar = new TabPage();
            splitContainer1 = new SplitContainer();
            dgvPersonas = new DataGridView();
            btn_eliminar = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tbc_mostrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(983, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tbc_mostrar);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(983, 407);
            tabControl1.TabIndex = 1;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged_1;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(Btn_registrar);
            tabPage1.Controls.Add(Fecha);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(Txb_Apellido);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(Txb_Nombre);
            tabPage1.Location = new Point(4, 34);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(975, 369);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Registro";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // Btn_registrar
            // 
            Btn_registrar.Location = new Point(483, 310);
            Btn_registrar.Name = "Btn_registrar";
            Btn_registrar.Size = new Size(112, 34);
            Btn_registrar.TabIndex = 13;
            Btn_registrar.Text = "Registrar";
            Btn_registrar.UseVisualStyleBackColor = true;
            Btn_registrar.Click += Btn_registrar_Click;
            // 
            // Fecha
            // 
            Fecha.Location = new Point(67, 248);
            Fecha.Name = "Fecha";
            Fecha.Size = new Size(338, 31);
            Fecha.TabIndex = 12;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 143);
            label3.Name = "label3";
            label3.Size = new Size(78, 25);
            label3.TabIndex = 11;
            label3.Text = "Apellido";
            // 
            // Txb_Apellido
            // 
            Txb_Apellido.Location = new Point(67, 171);
            Txb_Apellido.Name = "Txb_Apellido";
            Txb_Apellido.Size = new Size(338, 31);
            Txb_Apellido.TabIndex = 10;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 60);
            label2.Name = "label2";
            label2.Size = new Size(78, 25);
            label2.TabIndex = 9;
            label2.Text = "Nombre";
            // 
            // Txb_Nombre
            // 
            Txb_Nombre.Location = new Point(67, 88);
            Txb_Nombre.Name = "Txb_Nombre";
            Txb_Nombre.Size = new Size(338, 31);
            Txb_Nombre.TabIndex = 7;
            // 
            // tbc_mostrar
            // 
            tbc_mostrar.BackColor = Color.Transparent;
            tbc_mostrar.Controls.Add(splitContainer1);
            tbc_mostrar.ForeColor = SystemColors.AppWorkspace;
            tbc_mostrar.Location = new Point(4, 34);
            tbc_mostrar.Name = "tbc_mostrar";
            tbc_mostrar.Padding = new Padding(3);
            tbc_mostrar.Size = new Size(975, 369);
            tbc_mostrar.TabIndex = 1;
            tbc_mostrar.Text = "Mostrar";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dgvPersonas);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_eliminar);
            splitContainer1.Size = new Size(969, 363);
            splitContainer1.SplitterDistance = 181;
            splitContainer1.TabIndex = 1;
            // 
            // dgvPersonas
            // 
            dgvPersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPersonas.Dock = DockStyle.Fill;
            dgvPersonas.Location = new Point(0, 0);
            dgvPersonas.Name = "dgvPersonas";
            dgvPersonas.RowHeadersWidth = 62;
            dgvPersonas.Size = new Size(969, 181);
            dgvPersonas.TabIndex = 1;
            // 
            // btn_eliminar
            // 
            btn_eliminar.Enabled = false;
            btn_eliminar.Location = new Point(840, 17);
            btn_eliminar.Name = "btn_eliminar";
            btn_eliminar.Size = new Size(112, 34);
            btn_eliminar.TabIndex = 0;
            btn_eliminar.Text = "Eliminar";
            btn_eliminar.UseVisualStyleBackColor = true;
            btn_eliminar.Click += btn_eliminar_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // frm_Registro
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(983, 408);
            Controls.Add(tabControl1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "frm_Registro";
            Text = "frm_Registro";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tbc_mostrar.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private TabControl tabControl1;
        private TabPage tbc_mostrar;
        private TabPage tabPage1;
        private ContextMenuStrip contextMenuStrip1;
        private Button Btn_registrar;
        private DateTimePicker Fecha;
        private Label label3;
        private TextBox Txb_Apellido;
        private Label label2;
        private TextBox Txb_Nombre;
        private SplitContainer splitContainer1;
        private DataGridView dgvPersonas;
        private Button btn_eliminar;
    }
}