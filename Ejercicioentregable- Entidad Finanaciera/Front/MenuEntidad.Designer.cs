namespace Front
{
    partial class MenuEntidad
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
            clientesToolStripMenuItem = new ToolStripMenuItem();
            agregarToolStripMenuItem = new ToolStripMenuItem();
            cuentasBancariasToolStripMenuItem = new ToolStripMenuItem();
            nuevaCuentaToolStripMenuItem = new ToolStripMenuItem();
            tarjetasDeCreditoToolStripMenuItem = new ToolStripMenuItem();
            emitirNuevaTarjetaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { clientesToolStripMenuItem, cuentasBancariasToolStripMenuItem, tarjetasDeCreditoToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // clientesToolStripMenuItem
            // 
            clientesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { agregarToolStripMenuItem });
            clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            clientesToolStripMenuItem.Size = new Size(75, 24);
            clientesToolStripMenuItem.Text = "Clientes";
            clientesToolStripMenuItem.Click += clientesToolStripMenuItem_Click;
            // 
            // agregarToolStripMenuItem
            // 
            agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            agregarToolStripMenuItem.Size = new Size(146, 26);
            agregarToolStripMenuItem.Text = "Agregar";
            agregarToolStripMenuItem.Click += agregarToolStripMenuItem_Click;
            // 
            // cuentasBancariasToolStripMenuItem
            // 
            cuentasBancariasToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { nuevaCuentaToolStripMenuItem });
            cuentasBancariasToolStripMenuItem.Name = "cuentasBancariasToolStripMenuItem";
            cuentasBancariasToolStripMenuItem.Size = new Size(142, 24);
            cuentasBancariasToolStripMenuItem.Text = "Cuentas Bancarias";
            cuentasBancariasToolStripMenuItem.Click += cuentasBancariasToolStripMenuItem_Click;
            // 
            // nuevaCuentaToolStripMenuItem
            // 
            nuevaCuentaToolStripMenuItem.Name = "nuevaCuentaToolStripMenuItem";
            nuevaCuentaToolStripMenuItem.Size = new Size(224, 26);
            nuevaCuentaToolStripMenuItem.Text = "Nueva cuenta";
            nuevaCuentaToolStripMenuItem.Click += nuevaCuentaToolStripMenuItem_Click;
            // 
            // tarjetasDeCreditoToolStripMenuItem
            // 
            tarjetasDeCreditoToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { emitirNuevaTarjetaToolStripMenuItem });
            tarjetasDeCreditoToolStripMenuItem.Name = "tarjetasDeCreditoToolStripMenuItem";
            tarjetasDeCreditoToolStripMenuItem.Size = new Size(147, 24);
            tarjetasDeCreditoToolStripMenuItem.Text = "Tarjetas de Credito";
            // 
            // emitirNuevaTarjetaToolStripMenuItem
            // 
            emitirNuevaTarjetaToolStripMenuItem.Name = "emitirNuevaTarjetaToolStripMenuItem";
            emitirNuevaTarjetaToolStripMenuItem.Size = new Size(224, 26);
            emitirNuevaTarjetaToolStripMenuItem.Text = "Emitir nueva tarjeta";
            emitirNuevaTarjetaToolStripMenuItem.Click += emitirNuevaTarjetaToolStripMenuItem_Click;
            // 
            // MenuEntidad
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MenuEntidad";
            Text = "MenuEntidad";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem clientesToolStripMenuItem;
        private ToolStripMenuItem agregarToolStripMenuItem;
        private ToolStripMenuItem cuentasBancariasToolStripMenuItem;
        private ToolStripMenuItem nuevaCuentaToolStripMenuItem;
        private ToolStripMenuItem tarjetasDeCreditoToolStripMenuItem;
        private ToolStripMenuItem emitirNuevaTarjetaToolStripMenuItem;
    }
}