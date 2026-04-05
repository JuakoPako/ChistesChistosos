namespace ChistesChistosos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnBueno = new Button();
            btnMalo = new Button();
            btnSwitch = new Button();
            SuspendLayout();
            // 
            // btnBueno
            // 
            btnBueno.Location = new Point(356, 143);
            btnBueno.Name = "btnBueno";
            btnBueno.Size = new Size(92, 23);
            btnBueno.TabIndex = 1;
            btnBueno.Text = "Chiste bueno";
            btnBueno.UseVisualStyleBackColor = true;
            btnBueno.Click += btnBueno_Click;
            // 
            // btnMalo
            // 
            btnMalo.Location = new Point(356, 205);
            btnMalo.Name = "btnMalo";
            btnMalo.Size = new Size(92, 23);
            btnMalo.TabIndex = 2;
            btnMalo.Text = "Chiste malo";
            btnMalo.UseVisualStyleBackColor = true;
            btnMalo.Click += btnMalo_Click;
            // 
            // btnSwitch
            // 
            btnSwitch.Location = new Point(685, 28);
            btnSwitch.Name = "btnSwitch";
            btnSwitch.Size = new Size(75, 23);
            btnSwitch.TabIndex = 3;
            btnSwitch.Text = "OFF";
            btnSwitch.UseVisualStyleBackColor = true;
            btnSwitch.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSwitch);
            Controls.Add(btnMalo);
            Controls.Add(btnBueno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion
        private Button btnBueno;
        private Button btnMalo;
        private Button btnSwitch;
    }
}
