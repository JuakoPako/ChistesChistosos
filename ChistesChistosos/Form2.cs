using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ChistesChistosos
{
    public partial class Form2 : Form
    {
        public bool modoNoche;
        public string tipoChiste;

        List<string> disponibles;
        List<string> usados = new List<string>();
        Random rnd = new Random();

        public Form2()
        {
            InitializeComponent();
            this.Load += Form2_Load;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
            if (modoNoche)
            {
                this.BackColor = Color.Black;
                lblChiste.ForeColor = Color.White;
            }
            else
            {
                this.BackColor = Color.White;
                lblChiste.ForeColor = Color.Black;
            }

            
            if (tipoChiste == "bueno")
                disponibles = new List<string>(Chistes.buenos);
            else if (tipoChiste == "malo")
                disponibles = new List<string>(Chistes.malos);
            else
                disponibles = new List<string>(Chistes.mischistes);

            MostrarChiste();
        }

        private void MostrarChiste()
        {
            if (disponibles.Count == 0)
            {
                
                disponibles = new List<string>(usados);
                usados.Clear();
            }

            if (disponibles.Count == 0)
            {
                lblChiste.Text = "No hay chistes aun";
                return;
            }

            int pos = rnd.Next(disponibles.Count);
            string chiste = disponibles[pos];

            
            disponibles.RemoveAt(pos);
            usados.Add(chiste);

            lblChiste.Text = chiste;
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            MostrarChiste();
        }

        private void btnSalir1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}