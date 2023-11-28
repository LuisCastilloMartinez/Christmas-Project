using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Proyectonavidad_p1.Form1;

namespace Proyectonavidad_p1
{
    internal class CoposDeNieve
    {
        public List<Snowflake> snowflakes = new List<Snowflake>();
        private Random rand = new Random();

        public class Snowflake
        {
            // Representa un copo de nieve en un sistema de partículas

            // Propiedades:
            public float X { get; private set; }
            public float Y { get; private set; }
            public bool IsAlive { get; private set; }
            private float fallSpeed;
            private float size;
            private static Random rand = new Random();

            // Constructor
            public Snowflake(float x, float y)
            {
                X = x;
                Y = y;
                IsAlive = true;
                fallSpeed = 3.0f + 0.5f; // Ajusta la velocidad de caída según tus preferencias
                size = (float)(rand.NextDouble() * 10.0 + 5.0);
            }

            // Actualiza la posición del copo de nieve
            public void Update()
            {
                Y += fallSpeed;

                if (Y > 600)
                {
                    IsAlive = false;
                }
            }

            // Método para dibujar el copo de nieve
            public void Draw(Graphics g)
            {
                Brush brush = new SolidBrush(Color.FromArgb(128, Color.White));
                g.FillEllipse(brush, X - size / 2, Y - size / 2, size, size);
            }
        }

        public void AddSnowflake(int width)
        {
            snowflakes.Add(new Snowflake(rand.Next(0, width), 0));
            snowflakes.RemoveAll(s => !s.IsAlive);
        }

        public void UpdateAndDraw(Graphics g, int width)
        {
            foreach (var snowflake in snowflakes)
            {
                snowflake.Update();
                snowflake.Draw(g);
            }
        }
    }
}
