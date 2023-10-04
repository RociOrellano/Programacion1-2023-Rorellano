namespace Front
{
    partial class aTarjetaCredito
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
            Lnumtarjeta = new Label();
            Ltitular = new Label();
            Llimitecred = new Label();
            txtnumtarj = new TextBox();
            txttitular = new TextBox();
            txtlimitecred = new TextBox();
            butagregar = new Button();
            SuspendLayout();
            // 
            // Lnumtarjeta
            // 
            Lnumtarjeta.AutoSize = true;
            Lnumtarjeta.Location = new Point(226, 95);
            Lnumtarjeta.Name = "Lnumtarjeta";
            Lnumtarjeta.Size = new Size(132, 20);
            Lnumtarjeta.TabIndex = 0;
            Lnumtarjeta.Text = "Numero de Tarjeta";
            // 
            // Ltitular
            // 
            Ltitular.AutoSize = true;
            Ltitular.Location = new Point(226, 163);
            Ltitular.Name = "Ltitular";
            Ltitular.Size = new Size(51, 20);
            Ltitular.TabIndex = 1;
            Ltitular.Text = "Titular";
            // 
            // Llimitecred
            // 
            Llimitecred.AutoSize = true;
            Llimitecred.Location = new Point(226, 225);
            Llimitecred.Name = "Llimitecred";
            Llimitecred.Size = new Size(122, 20);
            Llimitecred.TabIndex = 2;
            Llimitecred.Text = "Limite de credito";
            // 
            // txtnumtarj
            // 
            txtnumtarj.Location = new Point(400, 95);
            txtnumtarj.Name = "txtnumtarj";
            txtnumtarj.Size = new Size(125, 27);
            txtnumtarj.TabIndex = 3;
            // 
            // txttitular
            // 
            txttitular.Location = new Point(400, 160);
            txttitular.Name = "txttitular";
            txttitular.Size = new Size(125, 27);
            txttitular.TabIndex = 4;
            // 
            // txtlimitecred
            // 
            txtlimitecred.Location = new Point(400, 225);
            txtlimitecred.Name = "txtlimitecred";
            txtlimitecred.Size = new Size(125, 27);
            txtlimitecred.TabIndex = 5;
            // 
            // butagregar
            // 
            butagregar.Location = new Point(326, 318);
            butagregar.Name = "butagregar";
            butagregar.Size = new Size(130, 55);
            butagregar.TabIndex = 6;
            butagregar.Text = "Agregar";
            butagregar.UseVisualStyleBackColor = true;
            butagregar.Click += butagregar_Click;
            // 
            // aTarjetaCredito
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butagregar);
            Controls.Add(txtlimitecred);
            Controls.Add(txttitular);
            Controls.Add(txtnumtarj);
            Controls.Add(Llimitecred);
            Controls.Add(Ltitular);
            Controls.Add(Lnumtarjeta);
            Name = "aTarjetaCredito";
            Text = "aTarjetaCredito";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lnumtarjeta;
        private Label Ltitular;
        private Label Llimitecred;
        private TextBox txtnumtarj;
        private TextBox txttitular;
        private TextBox txtlimitecred;
        private Button butagregar;
    }
}