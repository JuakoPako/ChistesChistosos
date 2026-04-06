namespace ChistesChistosos
{
    partial class Form2
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
            lblChiste = new Label();
            btnSalir2 = new Button();
            SuspendLayout();
            // 
            // lblChiste
            // 
            lblChiste.AutoSize = true;
            lblChiste.Location = new Point(355, 168);
            lblChiste.Name = "lblChiste";
            lblChiste.Size = new Size(38, 15);
            lblChiste.TabIndex = 1;
            lblChiste.Text = "label1";
            // 
            // btnSalir2
            // 
            btnSalir2.Location = new Point(713, 415);
            btnSalir2.Name = "btnSalir2";
            btnSalir2.Size = new Size(75, 23);
            btnSalir2.TabIndex = 9;
            btnSalir2.Text = "Salir";
            btnSalir2.UseVisualStyleBackColor = true;
            btnSalir2.Click += btnSalir1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir2);
            Controls.Add(lblChiste);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblChiste;
        private Button btnSalir2;
    }
}