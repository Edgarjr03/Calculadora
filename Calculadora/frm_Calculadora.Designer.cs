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
            SuspendLayout();
            // 
            // TxtVariableB
            // 
            TxtVariableB.Location = new Point(31, 174);
            TxtVariableB.Name = "TxtVariableB";
            TxtVariableB.Size = new Size(150, 31);
            TxtVariableB.TabIndex = 7;
            // 
            // TxtVariableA
            // 
            TxtVariableA.Location = new Point(30, 73);
            TxtVariableA.Name = "TxtVariableA";
            TxtVariableA.Size = new Size(150, 31);
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
            btnCalcular.Location = new Point(205, 127);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(112, 34);
            btnCalcular.TabIndex = 8;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // frm_Calculadora
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 294);
            Controls.Add(btnCalcular);
            Controls.Add(TxtVariableB);
            Controls.Add(TxtVariableA);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frm_Calculadora";
            Text = "rfn_formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtVariableB;
        private TextBox TxtVariableA;
        private Label label2;
        private Label label1;
        private Button btnCalcular;
    }
}