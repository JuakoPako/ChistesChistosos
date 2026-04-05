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
            btnSwitch = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            lblAgregar = new Label();
            txtAgregar = new TextBox();
            btnAgregar = new Button();
            SuspendLayout();
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
            // button3
            // 
            button3.Location = new Point(350, 51);
            button3.Name = "button3";
            button3.Size = new Size(92, 23);
            button3.TabIndex = 1;
            button3.Text = "Chiste bueno";
            button3.UseVisualStyleBackColor = true;
            button3.Click += btnBueno_Click;
            // 
            // button4
            // 
            button4.Location = new Point(350, 113);
            button4.Name = "button4";
            button4.Size = new Size(92, 23);
            button4.TabIndex = 2;
            button4.Text = "Chiste malo";
            button4.UseVisualStyleBackColor = true;
            button4.Click += btnMalo_Click;
            // 
            // button5
            // 
            button5.Location = new Point(350, 175);
            button5.Name = "button5";
            button5.Size = new Size(92, 23);
            button5.TabIndex = 4;
            button5.Text = "Mis Chistes";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button3_Click;
            // 
            // lblAgregar
            // 
            lblAgregar.AutoSize = true;
            lblAgregar.Location = new Point(350, 242);
            lblAgregar.Name = "lblAgregar";
            lblAgregar.Size = new Size(90, 15);
            lblAgregar.TabIndex = 5;
            lblAgregar.Text = "Agregar Chistes";
            lblAgregar.Click += label1_Click;
            // 
            // txtAgregar
            // 
            txtAgregar.Location = new Point(265, 282);
            txtAgregar.Multiline = true;
            txtAgregar.Name = "txtAgregar";
            txtAgregar.Size = new Size(264, 126);
            txtAgregar.TabIndex = 6;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(550, 340);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 7;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(lblAgregar);
            Controls.Add(btnSwitch);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSwitch;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label lblAgregar;
        private TextBox txtAgregar;
        private Button btnAgregar;
    }
}
