using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public class CartLocomotive : Locomotive
    {
        private bool pipe;
        private bool coal;
        private Color dopColor;

        public CartLocomotive(int maxSpeed, int maxCountPassengers, double weight, Color color, bool pipe, bool coal, Color dopColor) : base(maxSpeed, maxCountPassengers, weight, color)
        {
            this.pipe = pipe;
            this.coal = coal;
            this.dopColor = dopColor;
        }

        protected override void drawBaseLocomotive(Graphics g)
        {
            if (pipe)
            {
                Pen penB = new Pen(Color.Black);
                Brush brushB = new SolidBrush(dopColor);
                g.DrawRectangle(penB, startPosX + 80, startPosY - 30, 10, 30);  //Труба
                g.FillRectangle(brushB, startPosX + 80, startPosY - 30, 10, 30);
            }

            if (coal)
            {
                Pen penB = new Pen(Color.Black);
                Brush Coal = new SolidBrush(dopColor);
                g.DrawRectangle(penB, startPosX + 10, startPosY-5, 50, 10);  //Уголь
                g.FillRectangle(Coal, startPosX + 10, startPosY - 5, 50, 10);//Уголь

            }
            base.drawBaseLocomotive(g);          

        }


    }
}
