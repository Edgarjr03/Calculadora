namespace Calculadora.Formularios
{
    partial class frm_XMLAcces
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
            splitContainer1 = new SplitContainer();
            btn_guardar = new Button();
            dtg_personas = new DataGridView();
            tableform = new DataGridViewTextBoxColumn();
            id = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtg_personas).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(dtg_personas);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btn_guardar);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(956, 489);
            splitContainer1.SplitterDistance = 376;
            splitContainer1.TabIndex = 1;
            // 
            // btn_guardar
            // 
            btn_guardar.Location = new Point(426, 32);
            btn_guardar.Name = "btn_guardar";
            btn_guardar.Size = new Size(112, 34);
            btn_guardar.TabIndex = 0;
            btn_guardar.Text = "Guardar";
            btn_guardar.UseVisualStyleBackColor = true;
            btn_guardar.Click += btn_guardar_Click;
            // 
            // dtg_personas
            // 
            dtg_personas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtg_personas.Columns.AddRange(new DataGridViewColumn[] { tableform, id, Column1 });
            dtg_personas.Dock = DockStyle.Fill;
            dtg_personas.Location = new Point(0, 0);
            dtg_personas.Name = "dtg_personas";
            dtg_personas.RowHeadersWidth = 62;
            dtg_personas.Size = new Size(956, 376);
            dtg_personas.TabIndex = 3;
            // 
            // tableform
            // 
            tableform.HeaderText = "id";
            tableform.MinimumWidth = 8;
            tableform.Name = "tableform";
            tableform.Width = 50;
            // 
            // id
            // 
            id.HeaderText = "Nombre";
            id.MinimumWidth = 8;
            id.Name = "id";
            id.Width = 550;
            // 
            // Column1
            // 
            Column1.HeaderText = "Telefono";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 250;
            // 
            // frm_XMLAcces
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(956, 489);
            Controls.Add(splitContainer1);
            Name = "frm_XMLAcces";
            Text = "frm_XMLAcces";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtg_personas).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private SplitContainer splitContainer1;
        private Button btn_guardar;
        private DataGridView dtg_personas;
        private DataGridViewTextBoxColumn tableform;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn Column1;
    }
}