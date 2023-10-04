namespace Front
{
    partial class aCtaBancaria
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
            Lnumcuenta = new Label();
            Ltitular = new Label();
            Ltipo = new Label();
            Lsaldo = new Label();
            txtnumcuenta = new TextBox();
            txttitular = new TextBox();
            txttipo = new TextBox();
            txtsaldo = new TextBox();
            butGuardar = new Button();
            SuspendLayout();
            // 
            // Lnumcuenta
            // 
            Lnumcuenta.AutoSize = true;
            Lnumcuenta.Location = new Point(66, 66);
            Lnumcuenta.Name = "Lnumcuenta";
            Lnumcuenta.Size = new Size(134, 20);
            Lnumcuenta.TabIndex = 0;
            Lnumcuenta.Text = "Numero de Cuenta";
            // 
            // Ltitular
            // 
            Ltitular.AutoSize = true;
            Ltitular.Location = new Point(66, 132);
            Ltitular.Name = "Ltitular";
            Ltitular.Size = new Size(51, 20);
            Ltitular.TabIndex = 1;
            Ltitular.Text = "Titular";
            // 
            // Ltipo
            // 
            Ltipo.AutoSize = true;
            Ltipo.Location = new Point(66, 212);
            Ltipo.Name = "Ltipo";
            Ltipo.Size = new Size(39, 20);
            Ltipo.TabIndex = 2;
            Ltipo.Text = "Tipo";
            // 
            // Lsaldo
            // 
            Lsaldo.AutoSize = true;
            Lsaldo.Location = new Point(70, 284);
            Lsaldo.Name = "Lsaldo";
            Lsaldo.Size = new Size(47, 20);
            Lsaldo.TabIndex = 3;
            Lsaldo.Text = "Saldo";
            // 
            // txtnumcuenta
            // 
            txtnumcuenta.Location = new Point(322, 66);
            txtnumcuenta.Name = "txtnumcuenta";
            txtnumcuenta.Size = new Size(125, 27);
            txtnumcuenta.TabIndex = 4;
            // 
            // txttitular
            // 
            txttitular.Location = new Point(322, 132);
            txttitular.Name = "txttitular";
            txttitular.Size = new Size(125, 27);
            txttitular.TabIndex = 5;
            // 
            // txttipo
            // 
            txttipo.Location = new Point(322, 212);
            txttipo.Name = "txttipo";
            txttipo.Size = new Size(125, 27);
            txttipo.TabIndex = 6;
            // 
            // txtsaldo
            // 
            txtsaldo.Location = new Point(322, 294);
            txtsaldo.Name = "txtsaldo";
            txtsaldo.Size = new Size(125, 27);
            txtsaldo.TabIndex = 7;
            // 
            // butGuardar
            // 
            butGuardar.Location = new Point(582, 154);
            butGuardar.Name = "butGuardar";
            butGuardar.Size = new Size(129, 78);
            butGuardar.TabIndex = 8;
            butGuardar.Text = "Guardar";
            butGuardar.UseVisualStyleBackColor = true;
            butGuardar.Click += butGuardar_Click;
            // 
            // aCtaBancaria
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butGuardar);
            Controls.Add(txtsaldo);
            Controls.Add(txttipo);
            Controls.Add(txttitular);
            Controls.Add(txtnumcuenta);
            Controls.Add(Lsaldo);
            Controls.Add(Ltipo);
            Controls.Add(Ltitular);
            Controls.Add(Lnumcuenta);
            Name = "aCtaBancaria";
            Text = "aCtaBancaria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lnumcuenta;
        private Label Ltitular;
        private Label Ltipo;
        private Label Lsaldo;
        private TextBox txtnumcuenta;
        private TextBox txttitular;
        private TextBox txttipo;
        private TextBox txtsaldo;
        private Button butGuardar;
    }
}