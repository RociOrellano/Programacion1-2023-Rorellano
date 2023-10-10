namespace Front
{
    partial class PagoTarjeta
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
            label1 = new Label();
            button1 = new Button();
            txtMontoPago = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 94);
            label1.Name = "label1";
            label1.Size = new Size(236, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto que desee pagar";
            // 
            // button1
            // 
            button1.Location = new Point(322, 235);
            button1.Name = "button1";
            button1.Size = new Size(112, 48);
            button1.TabIndex = 1;
            button1.Text = "Pagar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtMontoPago
            // 
            txtMontoPago.Location = new Point(263, 155);
            txtMontoPago.Name = "txtMontoPago";
            txtMontoPago.Size = new Size(219, 27);
            txtMontoPago.TabIndex = 2;
            // 
            // PagoTarjeta
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtMontoPago);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "PagoTarjeta";
            Text = "PagoTarjeta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
        private TextBox txtMontoPago;
    }
}