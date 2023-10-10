namespace Front
{
    partial class TranscaExtraccion
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
            txtExtraccion = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(251, 111);
            label1.Name = "label1";
            label1.Size = new Size(248, 20);
            label1.TabIndex = 0;
            label1.Text = "Ingrese el monto que desea exttraer";
            // 
            // txtExtraccion
            // 
            txtExtraccion.Location = new Point(269, 163);
            txtExtraccion.Name = "txtExtraccion";
            txtExtraccion.Size = new Size(213, 27);
            txtExtraccion.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(319, 234);
            button1.Name = "button1";
            button1.Size = new Size(122, 47);
            button1.TabIndex = 2;
            button1.Text = "Aceptar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // TranscaExtraccion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(txtExtraccion);
            Controls.Add(label1);
            Name = "TranscaExtraccion";
            Text = "TranscExtraccion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtExtraccion;
        private Button button1;
    }
}