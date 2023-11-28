using System;
using System.Collections.Generic;
using System.Drawing;
using System.Media;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using ComponentFactory.Krypton.Toolkit;

namespace Proyectonavidad_p1
{
    public partial class Form1 : KryptonForm
    {
        SoundPlayer player = new SoundPlayer(Properties.Resources.y2mate_com___Navidad_Navidad);
        private CoposDeNieve coposDeNieve = new CoposDeNieve();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e); // Control para llamar la pintura del control
            coposDeNieve.UpdateAndDraw(e.Graphics, this.Width);
        }

        private void btn_Navidad_Click(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = 1000; // Intervalo de tiempo en milisegundos. 1000 ms = 1 segundo
            timer.Tick += new EventHandler(Contador_Navidad); // Evento que se inicia cada vez que el intervalo de tiempo pasa
            timer.Start(); // Iniciar el contador
            player.Load();
            player.Play();
        }
        private void Contador_Navidad(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Now;
            DateTime FechaNavidad = new DateTime(2023, 12, 25, 00, 00, 00);
            lb_fecha.Text = fecha.ToString();

            TimeSpan tspan = FechaNavidad - fecha;

            if (FechaNavidad.Date == fecha.Date)
            {
                lb_Dias.Text = "Feliz Navidad 2023";
            }
            else

            {
                lb_Dias.Text = tspan.Days.ToString();
                lb_horas.Text = tspan.Hours.ToString();
                lb_minutos.Text = tspan.Minutes.ToString();
                lb_segundos.Text = tspan.Seconds.ToString();

            }
        }

        private void btnnuevoform_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            this.Hide();
            form2.Show();
            player.Stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            coposnie.Start();
            // Para que el video este en pausa y no se reproduzca hasta presionar el btnvideo
            axWindowsMediaPlayer1.Ctlcontrols.stop();
        }

        private void coposnie_Tick(object sender, EventArgs e)
        {
            coposDeNieve.AddSnowflake(this.Width);
            this.Invalidate();
            coposnie.Interval = 50;
        }
        

        private void btnvideo_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.Location = new Point(5, 5);
            this.Size = new Size(770, 523);
            axWindowsMediaPlayer1.Ctlcontrols.play();
            btnvideo.Visible = false;
            player.Stop();
        }

        private void btnCerrarVideo_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            axWindowsMediaPlayer1.Ctlcontrols.stop();
            this.Size = new Size(770, 593);
            btnvideo.Visible = true;
            player.Play();
        }
    }
}
