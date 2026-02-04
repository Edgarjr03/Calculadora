namespace Calculadora
{
    partial class frm_Calculadora
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
            TxtVariableB = new TextBox();
            TxtVariableA = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnCalcular = new Button();
            bteReset = new Button();
            groupBox1 = new GroupBox();
            rdb_suma = new RadioButton();
            rdb_resta = new RadioButton();
            rdb_multiplicacion = new RadioButton();
            rdb_division = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // TxtVariableB
            // 
            TxtVariableB.Location = new Point(31, 174);
            TxtVariableB.Name = "TxtVariableB";
            TxtVariableB.Size = new Size(229, 31);
            TxtVariableB.TabIndex = 7;
            // 
            // TxtVariableA
            // 
            TxtVariableA.Location = new Point(30, 73);
            TxtVariableA.Name = "TxtVariableA";
            TxtVariableA.Size = new Size(230, 31);
            TxtVariableA.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 136);
            label2.Name = "label2";
            label2.Size = new Size(89, 25);
            label2.TabIndex = 5;
            label2.Text = "Variable B";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 25);
            label1.TabIndex = 4;
            label1.Text = "variable A";
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(656, 89);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // bteReset
            // 
            bteReset.Location = new Point(656, 136);
            bteReset.Name = "bteReset";
            bteReset.Size = new Size(112, 34);
            bteReset.TabIndex = 9;
            bteReset.Text = "reset";
            bteReset.UseVisualStyleBackColor = true;
            bteReset.Click += bteReset_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdb_division);
            groupBox1.Controls.Add(rdb_multiplicacion);
            groupBox1.Controls.Add(rdb_resta);
            groupBox1.Controls.Add(rdb_suma);
            groupBox1.Location = new Point(312, 53);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(304, 185);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Operaciones";
            // 
            // rdb_suma
            // 
            rdb_suma.AutoSize = true;
            rdb_suma.Location = new Point(6, 34);
            rdb_suma.Name = "rdb_suma";
            rdb_suma.Size = new Size(80, 29);
            rdb_suma.TabIndex = 0;
            rdb_suma.TabStop = true;
            rdb_suma.Text = "suma";
            rdb_suma.UseVisualStyleBackColor = true;
            // 
            // rdb_resta
            // 
            rdb_resta.AutoSize = true;
            rdb_resta.Location = new Point(6, 69);
            rdb_resta.Name = "rdb_resta";
            rdb_resta.Size = new Size(75, 29);
            rdb_resta.TabIndex = 1;
            rdb_resta.TabStop = true;
            rdb_resta.Text = "resta";
            rdb_resta.UseVisualStyleBackColor = true;
            // 
            // rdb_multiplicacion
            // 
            rdb_multiplicacion.AutoSize = true;
            rdb_multiplicacion.Location = new Point(6, 104);
            rdb_multiplicacion.Name = "rdb_multiplicacion";
            rdb_multiplicacion.Size = new Size(146, 29);
            rdb_multiplicacion.TabIndex = 2;
            rdb_multiplicacion.TabStop = true;
            rdb_multiplicacion.Text = "multiplicacion";
            rdb_multiplicacion.UseVisualStyleBackColor = true;
            // 
            // rdb_division
            // 
            rdb_division.AutoSize = true;
            rdb_division.Location = new Point(6, 139);
            rdb_division.Name = "rdb_division";
            rdb_division.Size = new Size(98, 29);
            rdb_division.TabIndex = 3;
            rdb_division.TabStop = true;
            rdb_division.Text = "division";
            rdb_division.UseVisualStyleBackColor = true;
            // 
            // frm_Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(953, 294);
            Controls.Add(groupBox1);
            Controls.Add(bteReset);
            Controls.Add(btnCalcular);
            Controls.Add(TxtVariableB);
            Controls.Add(TxtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Calculadora";
            Text = "rfn_formulario";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtVariableB;
        private TextBox TxtVariableA;
        private Label label2;
        private Label label1;
        private Button btnCalcular;
        private Button bteReset;
        private GroupBox groupBox1;
        private RadioButton rdb_division;
        private RadioButton rdb_multiplicacion;
        private RadioButton rdb_resta;
        private RadioButton rdb_suma;
    }
}