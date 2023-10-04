namespace Front
{
    partial class aCliente
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
            Lnombre = new Label();
            txtnombre = new TextBox();
            Lapell = new Label();
            Ldni = new Label();
            txtapell = new TextBox();
            txtdni = new TextBox();
            butgregar = new Button();
            SuspendLayout();
            // 
            // Lnombre
            // 
            Lnombre.AutoSize = true;
            Lnombre.Location = new Point(241, 70);
            Lnombre.Name = "Lnombre";
            Lnombre.Size = new Size(64, 20);
            Lnombre.TabIndex = 0;
            Lnombre.Text = "Nombre";
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(358, 70);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 1;
            // 
            // Lapell
            // 
            Lapell.AutoSize = true;
            Lapell.Location = new Point(241, 143);
            Lapell.Name = "Lapell";
            Lapell.Size = new Size(66, 20);
            Lapell.TabIndex = 2;
            Lapell.Text = "Apellido";
            // 
            // Ldni
            // 
            Ldni.AutoSize = true;
            Ldni.Location = new Point(241, 226);
            Ldni.Name = "Ldni";
            Ldni.Size = new Size(35, 20);
            Ldni.TabIndex = 3;
            Ldni.Text = "DNI";
            // 
            // txtapell
            // 
            txtapell.Location = new Point(358, 143);
            txtapell.Name = "txtapell";
            txtapell.Size = new Size(125, 27);
            txtapell.TabIndex = 4;
            // 
            // txtdni
            // 
            txtdni.Location = new Point(358, 219);
            txtdni.Name = "txtdni";
            txtdni.Size = new Size(125, 27);
            txtdni.TabIndex = 5;
            // 
            // butgregar
            // 
            butgregar.Location = new Point(358, 315);
            butgregar.Name = "butgregar";
            butgregar.Size = new Size(129, 72);
            butgregar.TabIndex = 6;
            butgregar.Text = "Agregar";
            butgregar.UseVisualStyleBackColor = true;
            butgregar.Click += butgregar_Click;
            // 
            // aCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(butgregar);
            Controls.Add(txtdni);
            Controls.Add(txtapell);
            Controls.Add(Ldni);
            Controls.Add(Lapell);
            Controls.Add(txtnombre);
            Controls.Add(Lnombre);
            Name = "aCliente";
            Text = "aCliente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lnombre;
        private TextBox txtnombre;
        private Label Lapell;
        private Label Ldni;
        private TextBox txtapell;
        private TextBox txtdni;
        private Button butgregar;
    }
}