namespace Front
{
    partial class MenuCliente
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
            menuStrip1 = new MenuStrip();
            transaccionesToolStripMenuItem = new ToolStripMenuItem();
            depositoToolStripMenuItem = new ToolStripMenuItem();
            extraccionToolStripMenuItem = new ToolStripMenuItem();
            transferirToolStripMenuItem = new ToolStripMenuItem();
            pagarTarjetaCreditoToolStripMenuItem = new ToolStripMenuItem();
            resumenTarjetaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { transaccionesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // transaccionesToolStripMenuItem
            // 
            transaccionesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { depositoToolStripMenuItem, extraccionToolStripMenuItem, transferirToolStripMenuItem, pagarTarjetaCreditoToolStripMenuItem, resumenTarjetaToolStripMenuItem });
            transaccionesToolStripMenuItem.Name = "transaccionesToolStripMenuItem";
            transaccionesToolStripMenuItem.Size = new Size(114, 24);
            transaccionesToolStripMenuItem.Text = "Transacciones";
            // 
            // depositoToolStripMenuItem
            // 
            depositoToolStripMenuItem.Name = "depositoToolStripMenuItem";
            depositoToolStripMenuItem.Size = new Size(230, 26);
            depositoToolStripMenuItem.Text = "Deposito";
            depositoToolStripMenuItem.Click += depositoToolStripMenuItem_Click;
            // 
            // extraccionToolStripMenuItem
            // 
            extraccionToolStripMenuItem.Name = "extraccionToolStripMenuItem";
            extraccionToolStripMenuItem.Size = new Size(230, 26);
            extraccionToolStripMenuItem.Text = "Extraccion";
            extraccionToolStripMenuItem.Click += extraccionToolStripMenuItem_Click;
            // 
            // transferirToolStripMenuItem
            // 
            transferirToolStripMenuItem.Name = "transferirToolStripMenuItem";
            transferirToolStripMenuItem.Size = new Size(230, 26);
            transferirToolStripMenuItem.Text = "Transferir";
            transferirToolStripMenuItem.Click += transferirToolStripMenuItem_Click;
            // 
            // pagarTarjetaCreditoToolStripMenuItem
            // 
            pagarTarjetaCreditoToolStripMenuItem.Name = "pagarTarjetaCreditoToolStripMenuItem";
            pagarTarjetaCreditoToolStripMenuItem.Size = new Size(230, 26);
            pagarTarjetaCreditoToolStripMenuItem.Text = "Pagar Tarjeta Credito";
            pagarTarjetaCreditoToolStripMenuItem.Click += pagarTarjetaCreditoToolStripMenuItem_Click;
            // 
            // resumenTarjetaToolStripMenuItem
            // 
            resumenTarjetaToolStripMenuItem.Name = "resumenTarjetaToolStripMenuItem";
            resumenTarjetaToolStripMenuItem.Size = new Size(230, 26);
            resumenTarjetaToolStripMenuItem.Text = "Resumen Tarjeta";
            // 
            // MenuCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuCliente";
            Text = "MenuCliente";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem transaccionesToolStripMenuItem;
        private ToolStripMenuItem depositoToolStripMenuItem;
        private ToolStripMenuItem extraccionToolStripMenuItem;
        private ToolStripMenuItem transferirToolStripMenuItem;
        private ToolStripMenuItem pagarTarjetaCreditoToolStripMenuItem;
        private ToolStripMenuItem resumenTarjetaToolStripMenuItem;
    }
}