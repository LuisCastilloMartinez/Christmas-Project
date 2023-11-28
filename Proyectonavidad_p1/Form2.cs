using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Media;
using ComponentFactory.Krypton.Toolkit;
using static Proyectonavidad_p1.Form1;

namespace Proyectonavidad_p1
{
    public partial class Form2 : KryptonForm
    {
        SoundPlayer playerr = new SoundPlayer(Properties.Resources.videoplayback);

        private List<string> palabras = new List<string> { "pino", "regalos", "renos", "nieve", "nochebuena", "luces", "trineo", "santaclaus" };
        private string palabraSecreta;
        private string palabraAdivinada;
        private int intentos;
        private List<char> letrasAdivinadas;

        public Form2()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }
        private CoposDeNieve coposDeNieve = new CoposDeNieve();

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            coposDeNieve.UpdateAndDraw(e.Graphics, this.Width);
        }

        private void coposnie_Tick(object sender, EventArgs e)
        {
            coposDeNieve.AddSnowflake(this.Width);
            coposnie.Interval = 50;
            this.Invalidate();
        }

        private void btnregresoform_Click_1(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            this.Hide();
            form1.Show();
        }

        private void btnreiniciar_Click_1(object sender, EventArgs e)
        {
            ReiniciarJuego();
            lbadivinanza.Text = "";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            ReiniciarJuego();
            coposnie.Start();
        }

        private void ReiniciarJuego()
        {
            Random random = new Random();
            palabraSecreta = palabras[random.Next(palabras.Count)];
            palabraAdivinada = new string('_', palabraSecreta.Length);
            intentos = 6;
            letrasAdivinadas = new List<char>();

            lblMensaje.Text = "¿Iniciamos?";
            lblMensaje.ForeColor = System.Drawing.Color.Gold;
            lblPalabra.Text = palabraAdivinada;
        }
        private void btnAdivinanza_Click(object sender, EventArgs e)
        {
            lblMensaje.Location = new System.Drawing.Point(10, 206);
            lblMensaje.Text = "";
            if (palabraSecreta == "pino")
            {
                lbadivinanza.Text = "En diciembre, brillante y verde me verás,\r\ndecorado con luces, un bosque de paz.\r\nBajo mis ramas, regalos y risas van,\r\nsoy testigo de la magia que trae el hogar.\r\n\r\n¿Qué soy?";
            }
            else if (palabraSecreta == "regalos")
            {
                lbadivinanza.Text = "Envuelto con cariño, en papel de color,\r\nesconde sorpresas, alegría y ardor.\r\nSe da con amor, se recibe con emoción,\r\n¿Adivina ahora, qué es esta tradición?\r\n\r\n¿Qué soy?";
            }
            else if (palabraSecreta == "renos")
            {
                lbadivinanza.Text = "En el Polo Norte, corren con destreza,\r\ntiran del trineo con pura nobleza.\r\nCon cuernos majestuosos y paso veloz,\r\n¿Quiénes son ellos?\r\n\r\n¿Qué son?";
            }
            else if (palabraSecreta == "nieve")
            {
                lbadivinanza.Text = "Blanca y suave cae del cielo en invierno,\r\ncubre el paisaje con un manto ligero.\r\nNi fría ni dura, al sol se deshace,\r\nun juego para algunos, ¡una maravilla que en el invierno nace!\r\n\r\n¿Qué es?";
            }
            else if (palabraSecreta == "nochebuena")
            {
                lbadivinanza.Text = "En diciembre florezco con esplendor,\r\nmis pétalos rojos hablan de amor.\r\nEn la mesa, me encuentras con fragancia plena,\r\nen la época festiva \r\n\r\n¿Qué soy?";
            }
            else if (palabraSecreta == "luces")
            {
                lbadivinanza.Text = "Parpadean en la oscuridad,\r\ndecoran la ciudad con su claridad.\r\nEn árboles, casas, calles brillan con fervor,\r\n¿Qué pequeñas estrellas adornan el alrededor?\r\n\r\n¿Qué son?";
            }
            else if (palabraSecreta == "trineo")
            {
                lbadivinanza.Text = "En la nieve deslizo con gran destreza,\r\ntirado por renos, veloz es mi carrera.\r\nSanta me guía, repartiendo alegría,\r\nsobre las colinas, ¡una mágica travesía!\r\n\r\n¿Qué soy?";
            }
            else if (palabraSecreta == "santaclaus")
            {
                lbadivinanza.Text = "De barba blanca y traje rojo es su atuendo,\r\nvuela por el cielo, siempre en movimiento.\r\nCon regalos en su saco, reparte ilusión,\r\nen la noche mágica, es la figura de la tradición.\r\n\r\n¿Quién es?";
            }
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            playerr.Load();
            playerr.Play();
            char letra = txtLetra.Text.ToLower()[0];


            if (letrasAdivinadas.Contains(letra))
            {
                lblMensaje.Text = "Ya has ingresado esa letra. Intenta con otra.";
                lblMensaje.ForeColor = System.Drawing.Color.Red;
                return;
            }

            letrasAdivinadas.Add(letra);

            if (palabraSecreta.Contains(letra))
            {
                for (int i = 0; i < palabraSecreta.Length; i++)
                {
                    if (palabraSecreta[i] == letra)
                    {
                        palabraAdivinada = palabraAdivinada.Substring(0, i) + letra + palabraAdivinada.Substring(i + 1);
                    }
                }

                lblMensaje.Text = "¡Adivinaste una letra!";
                lblMensaje.ForeColor = System.Drawing.Color.Gold;
                lblPalabra.Text = palabraAdivinada;
            }
            else
            {
                intentos--;
                lblMensaje.Text = "Letra incorrecta. Te quedan " + intentos + " intentos.";

                if (intentos == 0)
                {
                    lblMensaje.Text = "Lo siento, has perdido. La palabra era: " + palabraSecreta;
                    lblMensaje.ForeColor = System.Drawing.Color.Red;
                    kryptonButton1.Enabled = false;
                }
            }

            txtLetra.Text = "";
            txtLetra.Focus();

            if (!palabraAdivinada.Contains('_'))
            {
                lblMensaje.Text = "¡Felicidades! Adivinaste la palabra correctamente.";
                lblMensaje.ForeColor = System.Drawing.Color.Yellow;
                kryptonButton1.Enabled = false;
            }
        }
    }
}