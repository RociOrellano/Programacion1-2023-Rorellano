namespace Front
{
    partial class TranscDeposito
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
            txtDeposito = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 111);
            label1.Name = "label1";
            label1.Size = new Size(200, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto a depositar";
            // 
            // txtDeposito
            // 
            txtDeposito.Location = new Point(306, 158);
            txtDeposito.Name = "txtDeposito";
            txtDeposito.Size = new Size(172, 27);
            txtDeposito.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(339, 245);
            button1.Name = "button1";
            button1.Size = new Size(106, 40);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtDeposito);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtDeposito;
        private Button button1;
    }
}