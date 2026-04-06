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
            BtnBueno = new Button();
            BtnMalo = new Button();
            BtnMisChistes = new Button();
            lblAgregar = new Label();
            txtAgregar = new TextBox();
            btnAgregar = new Button();
            btnSalir1 = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // BtnBueno
            // 
            BtnBueno.Location = new Point(350, 51);
            BtnBueno.Name = "BtnBueno";
            BtnBueno.Size = new Size(92, 23);
            BtnBueno.TabIndex = 1;
            BtnBueno.Text = "Chiste bueno";
            BtnBueno.UseVisualStyleBackColor = true;
            BtnBueno.Click += btnBueno_Click;
            // 
            // BtnMalo
            // 
            BtnMalo.Location = new Point(350, 113);
            BtnMalo.Name = "BtnMalo";
            BtnMalo.Size = new Size(92, 23);
            BtnMalo.TabIndex = 2;
            BtnMalo.Text = "Chiste malo";
            BtnMalo.UseVisualStyleBackColor = true;
            BtnMalo.Click += btnMalo_Click;
            // 
            // BtnMisChistes
            // 
            BtnMisChistes.Location = new Point(350, 175);
            BtnMisChistes.Name = "BtnMisChistes";
            BtnMisChistes.Size = new Size(92, 23);
            BtnMisChistes.TabIndex = 4;
            BtnMisChistes.Text = "Mis Chistes";
            BtnMisChistes.UseVisualStyleBackColor = true;
            BtnMisChistes.Click += button3_Click;
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
            // btnSalir1
            // 
            btnSalir1.Location = new Point(713, 415);
            btnSalir1.Name = "btnSalir1";
            btnSalir1.Size = new Size(75, 23);
            btnSalir1.TabIndex = 8;
            btnSalir1.Text = "Salir";
            btnSalir1.UseVisualStyleBackColor = true;
            btnSalir1.Click += button1_Click_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.hankfeliz;
            pictureBox1.Location = new Point(53, 287);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(130, 121);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnSalir1);
            Controls.Add(btnAgregar);
            Controls.Add(txtAgregar);
            Controls.Add(lblAgregar);
            Controls.Add(btnSwitch);
            Controls.Add(BtnMisChistes);
            Controls.Add(BtnMalo);
            Controls.Add(BtnBueno);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnSwitch;
        private Button BtnBueno;
        private Button BtnMalo;
        private Button BtnMisChistes;
        private Label lblAgregar;
        private TextBox txtAgregar;
        private Button btnAgregar;
        private Button btnSalir1;
        private PictureBox pictureBox1;
    }
}
