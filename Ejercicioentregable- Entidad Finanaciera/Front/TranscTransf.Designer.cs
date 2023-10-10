namespace Front
{
    partial class TranscTransf
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
            label2 = new Label();
            txtCuentadestino = new TextBox();
            txtMontoTrf = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(289, 86);
            label1.Name = "label1";
            label1.Size = new Size(195, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese la cuenta de destino";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(288, 197);
            label2.Name = "label2";
            label2.Size = new Size(196, 20);
            label2.TabIndex = 1;
            label2.Text = "ingrese el monto a transferir";
            // 
            // txtCuentadestino
            // 
            txtCuentadestino.Location = new Point(291, 133);
            txtCuentadestino.Name = "txtCuentadestino";
            txtCuentadestino.Size = new Size(193, 27);
            txtCuentadestino.TabIndex = 2;
            // 
            // txtMontoTrf
            // 
            txtMontoTrf.Location = new Point(307, 242);
            txtMontoTrf.Name = "txtMontoTrf";
            txtMontoTrf.Size = new Size(157, 27);
            txtMontoTrf.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(325, 316);
            button1.Name = "button1";
            button1.Size = new Size(127, 47);
            button1.TabIndex = 4;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TranscTransf
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtMontoTrf);
            Controls.Add(txtCuentadestino);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "TranscTransf";
            Text = "TranscTransf";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtCuentadestino;
        private TextBox txtMontoTrf;
        private Button button1;
    }
}