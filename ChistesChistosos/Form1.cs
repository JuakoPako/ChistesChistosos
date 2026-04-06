namespace ChistesChistosos
{
    public partial class Form1 : Form
    {
        bool modoNoche = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnSwitch.BackColor = Color.LightGray;
            btnSwitch.ForeColor = Color.Black;
            BtnBueno.Visible = true;
            BtnMalo.Visible = false;
        }

        private void btnBueno_Click(object sender, EventArgs e)
        {
            Form2 oForm2 = new Form2();
            oForm2.tipoChiste = "bueno";
            oForm2.modoNoche = modoNoche;
            oForm2.Show();
        }

        private void btnMalo_Click(object sender, EventArgs e)
        {
            Form2 oForm2 = new Form2();
            oForm2.tipoChiste = "malo";
            oForm2.modoNoche = modoNoche;
            oForm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            modoNoche = !modoNoche;

            if (modoNoche)
            {
                btnSwitch.BackColor = Color.FromArgb(0, 120, 215); // azul
                btnSwitch.ForeColor = Color.White;
                btnSwitch.Text = "ON";

                this.BackColor = Color.FromArgb(40, 40, 40); // fondo oscuro

                BtnBueno.Visible = false;
                BtnMalo.Visible = true;
            }
            else
            {
                btnSwitch.BackColor = Color.LightGray; // gris claro
                btnSwitch.ForeColor = Color.Black;
                btnSwitch.Text = "OFF";

                this.BackColor = Color.White;

                BtnBueno.Visible = true;
                BtnMalo.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 oForm2 = new Form2();
            oForm2.tipoChiste = "mischistes";
            oForm2.modoNoche = modoNoche;
            oForm2.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nuevoChiste = txtAgregar.Text;
            Chistes.mischistes.Add(nuevoChiste);
            MessageBox.Show("Chiste Agregado!");

        }
    }
}
