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

        public CartLocomotive(string info):base(info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 7)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                pipe = Convert.ToBoolean(strs[4]);
                coal = Convert.ToBoolean(strs[5]);
                dopColor = Color.FromName(strs[6]);
            }
        }

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
        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name + ";" + pipe + ";" + coal + ";" + dopColor.Name;
        }
    }
}
