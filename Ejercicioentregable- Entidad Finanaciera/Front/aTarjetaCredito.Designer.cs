﻿namespace Front
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
            butagregar = new Button();
            SuspendLayout();
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
            Name = "aTarjetaCredito";
            Text = "aTarjetaCredito";
            ResumeLayout(false);
        }

        #endregion
        private Button butagregar;
    }
}