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

        public CartLocomotive(int maxSpeed, int maxCountPassengers, double weight, Color color, bool pipe, bool coal, Color dopcolor) : base(maxSpeed, maxCountPassengers, weight, color)
        {
            this.pipe = pipe;
            this.coal = coal;          
            this.dopColor = dopColor;
        }

        protected override void drawBaseLocomotive(Graphics g)
        {
            if (pipe)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, startPosX + 80, startPosY - 6, 20, 20);
            }

            if (coal)
            {
                Pen pen = new Pen(Color.Black);
                g.DrawEllipse(pen, startPosX + 80, startPosY - 6, 30, 30);
            }
            base.drawBaseLocomotive(g);       

        }


    }
}
