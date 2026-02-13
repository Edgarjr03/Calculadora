namespace Calculadora.Formularios
{
    partial class Frm_contador
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
            lbl_cuenta = new Label();
            btn_inicio = new Button();
            btn_detener = new Button();
            tkr_velocidad = new TrackBar();
            tmr_contador = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)tkr_velocidad).BeginInit();
            SuspendLayout();
            // 
            // lbl_cuenta
            // 
            lbl_cuenta.AutoSize = true;
            lbl_cuenta.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_cuenta.Location = new Point(177, 11);
            lbl_cuenta.Name = "lbl_cuenta";
            lbl_cuenta.Size = new Size(106, 128);
            lbl_cuenta.TabIndex = 0;
            lbl_cuenta.Text = "0";
            // 
            // btn_inicio
            // 
            btn_inicio.Location = new Point(92, 217);
            btn_inicio.Name = "btn_inicio";
            btn_inicio.Size = new Size(112, 34);
            btn_inicio.TabIndex = 1;
            btn_inicio.Text = "Inicio";
            btn_inicio.UseVisualStyleBackColor = true;
            btn_inicio.Click += button1_Click;
            // 
            // btn_detener
            // 
            btn_detener.Location = new Point(250, 217);
            btn_detener.Name = "btn_detener";
            btn_detener.Size = new Size(112, 34);
            btn_detener.TabIndex = 2;
            btn_detener.Text = "Detener";
            btn_detener.UseVisualStyleBackColor = true;
            btn_detener.Click += button2_Click;
            // 
            // tkr_velocidad
            // 
            tkr_velocidad.Enabled = false;
            tkr_velocidad.Location = new Point(12, 142);
            tkr_velocidad.Maximum = 5;
            tkr_velocidad.Minimum = 1;
            tkr_velocidad.Name = "tkr_velocidad";
            tkr_velocidad.Size = new Size(433, 69);
            tkr_velocidad.TabIndex = 3;
            tkr_velocidad.Value = 1;
            tkr_velocidad.Scroll += tkr_velocidad_Scroll;
            // 
            // tmr_contador
            // 
            tmr_contador.Interval = 1;
            tmr_contador.Tick += tmr_contador_Tick;
            // 
            // Frm_contador
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 292);
            Controls.Add(tkr_velocidad);
            Controls.Add(btn_detener);
            Controls.Add(btn_inicio);
            Controls.Add(lbl_cuenta);
            Name = "Frm_contador";
            Text = "Contador";
            ((System.ComponentModel.ISupportInitialize)tkr_velocidad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_cuenta;
        private Button btn_inicio;
        private Button btn_detener;
        private TrackBar tkr_velocidad;
        private System.Windows.Forms.Timer tmr_contador;
    }
}