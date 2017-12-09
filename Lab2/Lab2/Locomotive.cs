using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class Locomotive : Vehicle
    {

        public override int MaxSpeed
        {
            get
            {
                return base.MaxSpeed;
            }

            protected set
            {
                if (value > 0 && value < 100)
                {
                    base.MaxSpeed = value;
                }
                else
                {
                    base.MaxSpeed = 50;
                }
            }
        }

        public override int MaxCountPassengers
        {
            get
            {
                return base.MaxCountPassengers;
            }

            protected set
            {
                if (value > 1 && value < 100)
                {
                    base.MaxCountPassengers = value;
                }
                else
                {
                    base.MaxCountPassengers = 50;
                }
            }
        }

        public override double Weight
        {
            get
            {
                return base.Weight;
            }

            protected set
            {

                if (value > 5000 && value < 10000)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 7500;
                }
            }
        }

        public Locomotive(int maxSpeed, int maxCountPassengers, double weight, Color color)
        {
            this.MaxSpeed = maxSpeed;
            this.MaxCountPassengers = maxCountPassengers;
            this.ColorBody = color;
            this.Weight = weight;
            this.countPassengers = 0;
            Random rand = new Random();
            startPosX = rand.Next(10, 200);
            startPosY = rand.Next(10, 200);
        }


        public override void drawLocomotive(Graphics g)
        {
            drawBaseLocomotive(g);
        }

        public override void moveLocomotive(Graphics g)
        {
            startPosX += MaxSpeed / 10;   //ПОТОМ ИСПРАВИТЬ НА ФОРМУЛУ
        }

        protected virtual void drawBaseLocomotive(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            g.DrawRectangle(pen, startPosX + 80, startPosX + 10, 10, 30);
        }

    }
}
