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
            string[] chistesBuenos = {
                "¿Por qué los pájaros no usan Facebook? Porque ya tienen Twitter.",
                "¿Qué le dijo un pez a otro? ¡Nada!",
                "¿Cuál es el colmo de un jardinero? Que siempre lo dejen plantado.",
                "¿Por qué los esqueletos no pelean entre ellos? Porque no tienen el valor.",
                "¿Qué le dijo una pared a la otra? Nos vemos en la esquina."
            };

            string[] chistesMalos = {
                "¿Por qué el libro de matemáticas se deprimió? Porque tenía demasiados problemas.",
                "¿Qué le dijo un semáforo a otro? No me mires, me estoy cambiando.",
                "¿Cuál es el colmo de un electricista? Que siempre lo dejen sin corriente.",
                "¿Por qué los fantasmas no pueden mentir? Porque se les ve a través.",
            };

            Random rnd = new Random();

            if (tipoChiste == "bueno")
            {
                string chiste;

                do
                {
                    int pos = rnd.Next(chistesBuenos.Length);
                    chiste = chistesBuenos[pos];
                } while (usados.Contains(chiste));

                usados.Add(chiste);
                lblChiste.Text = chiste;
            }
            else
            {
                string chiste;
                
                do
                {
                    int pos = rnd.Next(chistesMalos.Length);
                    chiste = chistesMalos[pos];
                } while (usados.Contains(chiste));

                usados.Add(chiste);
                lblChiste.Text = chiste;
            }
        }
    }
}
