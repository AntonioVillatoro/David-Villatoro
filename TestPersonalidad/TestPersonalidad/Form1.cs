using F2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestPersonalidad
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            int f;
            InitializeComponent();
        }

        private void Calcular_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calcular_Click_1(object sender, EventArgs e)
        {
           bool validado = validar();
            //Primera Seccion
            int introvertido = 0;
            int extrovertido = 0;
            if (s1rb1a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb8a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb15a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb22a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb29a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb36a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb43a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb50a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb57a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            if (s1rb64a.Checked)
            {
                extrovertido = extrovertido + 1;
            }
            else
            {
                introvertido = introvertido + 1;
            }
            //SegundaSeccion 
            int Intuitivo = 0;
            int Sensorial = 0;

            if (s2rb2a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb9a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb16a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb23a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb30a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb37a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb44a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb51a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb58a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb65a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            //SegundaSeccion 

            if (s2rb3a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb10a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb17a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb24a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb31a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb38a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb45a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb52a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb59a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            if (s2rb66a.Checked)
            {
                Sensorial = Sensorial + 1;
            }
            else
            {
                Intuitivo = Intuitivo + 1;
            }
            //TerceraSeccion 
            int Emocional = 0;
            int Racional = 0;
            if (s3rb4a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb11a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb18a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb25a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb32a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb39a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb46a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb53a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb60a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb67a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            //Mas
            if (s3rb5a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb12a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb19a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb26a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb33a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb40a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb47a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb54a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb61a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            if (s3rb68a.Checked)
            {
                Racional = Racional + 1;
            }
            else
            {
                Emocional = Emocional + 1;
            }
            //CuartaSeccion 
            int Perceptivo = 0;
            int Estructurado = 0;
            if (s4rb6a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb13a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb20a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb27a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb34a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb41a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb48a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb55a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb62a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb69a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            //Mas
            if (s4rb7a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb14a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb21a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb28a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb35a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb42a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb49a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb56a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb63a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            if (s4rb70a.Checked)
            {
                Estructurado = Estructurado + 1;
            }
            else
            {
                Perceptivo = Perceptivo + 1;
            }
            txtextrovertido.Text = extrovertido.ToString();
            txtintrovertido.Text = introvertido.ToString();
            //Seccion2
            txtsensorial.Text = Sensorial.ToString();
            txtintuitivo.Text = Intuitivo.ToString();
            //Seccion 3
            txtracional.Text = Racional.ToString();
            txtemocional.Text = Emocional.ToString();
            //Seccion 4
            txtestructurado.Text = Estructurado.ToString();
            txtperceptivo.Text = Perceptivo.ToString();
            //Para que los radiobutons no esten vacios 

            string r1, r2, r3, r4;
            r1 = "E";
            if (introvertido > extrovertido) { r1 = "I"; }

            r2 = "S";
            if (Intuitivo > Sensorial) { r2 = "I"; }

            r3 = "R";
            if (Emocional > Racional) { r3 = "E"; }

            r4 = "E";
            if (Perceptivo >= Estructurado) { r4 = "P"; }
            //Mensaje Final 
            Form2 f = new Form2( r1, r2, r3, r4);
            f.Show();

            if (extrovertido >= introvertido)
            {

                // }
                //  else
                // {
                //     MessageBox.Show("Usted tiene personalidad Introvertida");
                // if (extrovertido >= introvertido)
                // {
                //     txtre
                // }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private bool validar()
        {
        
            return true;
        }
    }
}
