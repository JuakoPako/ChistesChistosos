using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChistesChistosos
{
    public partial class Form2 : Form
    {
        public bool modoNoche;
        public string tipoChiste;
        List<string> usados = new List<string>();
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

            Random rnd = new Random();
            List<string> lista;

            if (tipoChiste == "bueno")
            {
                lista = Chistes.buenos; 

            }
            else if (tipoChiste == "malo")
            {
                lista = Chistes.malos; 
                

            }
            else
            {
                lista = Chistes.mischistes;
            }


            if (lista.Count == 0)
            {
                lblChiste.Text = "No hay chistes aun";
                return;
            }

            if (usados.Count == lista.Count)
            {
                usados.Clear();
            }

            string chiste;

            do
            {
                int pos = rnd.Next(lista.Count);
                chiste = lista[pos];

            } while (usados.Contains(chiste));

            usados.Add(chiste);

            lblChiste.Text = chiste;


        }
    }
}
