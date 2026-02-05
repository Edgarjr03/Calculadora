namespace Calculadora
{
    partial class frm_Burbuja
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
            dgv_desordenado = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            dgv_ordenado = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            btn_ordenar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgv_desordenado).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordenado).BeginInit();
            SuspendLayout();
            // 
            // dgv_desordenado
            // 
            dgv_desordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_desordenado.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dgv_desordenado.Location = new Point(24, 36);
            dgv_desordenado.Name = "dgv_desordenado";
            dgv_desordenado.RowHeadersWidth = 62;
            dgv_desordenado.Size = new Size(194, 364);
            dgv_desordenado.TabIndex = 0;

            // 
            // Column1
            // 
            Column1.HeaderText = "Desordenado";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 150;
            // 
            // dgv_ordenado
            // 
            dgv_ordenado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_ordenado.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1 });
            dgv_ordenado.Location = new Point(441, 36);
            dgv_ordenado.Name = "dgv_ordenado";
            dgv_ordenado.RowHeadersWidth = 62;
            dgv_ordenado.Size = new Size(194, 364);
            dgv_ordenado.TabIndex = 1;
    
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Ordenado";
            dataGridViewTextBoxColumn1.MinimumWidth = 8;
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 150;
            // 
            // btn_ordenar
            // 
            btn_ordenar.Location = new Point(270, 160);
            btn_ordenar.Name = "btn_ordenar";
            btn_ordenar.Size = new Size(112, 34);
            btn_ordenar.TabIndex = 2;
            btn_ordenar.Text = "Ordenar";
            btn_ordenar.UseVisualStyleBackColor = true;
            btn_ordenar.Click += btn_ordenar_Click;
            // 
            // frm_Burbuja
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_ordenar);
            Controls.Add(dgv_ordenado);
            Controls.Add(dgv_desordenado);
            Name = "frm_Burbuja";
            Text = "Ordenar Burbuja";
      
            ((System.ComponentModel.ISupportInitialize)dgv_desordenado).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_ordenado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgv_desordenado;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView dgv_ordenado;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private Button btn_ordenar;
    }
}