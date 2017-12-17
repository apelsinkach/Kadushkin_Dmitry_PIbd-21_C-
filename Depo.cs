using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Depo
    {
        ClassArray<ITransport> depo;

        int countPlaces = 5;

        int placeSizeWidth = 300;

        int placeSizeHeight = 100;

        public Depo()
        {
            depo = new ClassArray<ITransport>(countPlaces, null);
        }


        public int PutLocoInDepo(ITransport locomotive)
        {
            return depo + locomotive;
        }

        public ITransport GetLocoInDepo(int report)
        {
            return depo - report;
        }


        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            for (int i = 0; i < countPlaces; i++)
            {
                var locomotive = depo.getObject(i);
                if (locomotive != null)
                {
                    locomotive.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 45);
                    locomotive.drawLocomotive(g);
                }

            }
        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);
            g.DrawRectangle(pen, 0, 0, countPlaces / 5 * placeSizeWidth, 500);
            for(int i = 0; i < countPlaces / 5; i++)
            {
                for(int j = 0; j < 6; ++j)
                {
                    g.DrawLine(pen,i*placeSizeWidth,j*placeSizeHeight,i*placeSizeWidth+110,j*placeSizeHeight);

                }
                g.DrawLine(pen, i * placeSizeWidth, 0, i * placeSizeWidth, 400);
            }


        }
    }
}
