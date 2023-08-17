namespace CalcularIC
{
    partial class Form1
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
            txtMontoInicial = new TextBox();
            txtPorcentaje = new TextBox();
            btnCalcular = new Button();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // txtMontoInicial
            // 
            txtMontoInicial.Location = new Point(148, 23);
            txtMontoInicial.Name = "txtMontoInicial";
            txtMontoInicial.Size = new Size(100, 23);
            txtMontoInicial.TabIndex = 0;
            // 
            // txtPorcentaje
            // 
            txtPorcentaje.Location = new Point(148, 62);
            txtPorcentaje.Name = "txtPorcentaje";
            txtPorcentaje.Size = new Size(100, 23);
            txtPorcentaje.TabIndex = 1;
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(160, 136);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(75, 23);
            btnCalcular.TabIndex = 2;
            btnCalcular.Text = "button1";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(179, 194);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(38, 15);
            lblResultado.TabIndex = 3;
            lblResultado.Text = "label1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(505, 450);
            Controls.Add(lblResultado);
            Controls.Add(btnCalcular);
            Controls.Add(txtPorcentaje);
            Controls.Add(txtMontoInicial);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtMontoInicial;
        private TextBox txtPorcentaje;
        private Button btnCalcular;
        private Label lblResultado;
    }
}