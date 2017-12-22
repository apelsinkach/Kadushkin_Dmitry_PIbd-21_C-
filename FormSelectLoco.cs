using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class FormSelectLoco : Form
    {
        ITransport loco = null;

        
        public FormSelectLoco()
        {
            InitializeComponent();
            panel2.MouseDown += panelColor_MouseDown;
            panel3.MouseDown += panelColor_MouseDown;
            panel4.MouseDown += panelColor_MouseDown;
            panel5.MouseDown += panelColor_MouseDown;
            panel6.MouseDown += panelColor_MouseDown;
            panel7.MouseDown += panelColor_MouseDown;
            panel8.MouseDown += panelColor_MouseDown;
            panel9.MouseDown += panelColor_MouseDown;

            panel2.MouseDown += panelDopColor_MouseDown;
            panel3.MouseDown += panelDopColor_MouseDown;
            panel4.MouseDown += panelDopColor_MouseDown;
            panel5.MouseDown += panelDopColor_MouseDown;
            panel6.MouseDown += panelDopColor_MouseDown;
            panel7.MouseDown += panelDopColor_MouseDown;
            panel8.MouseDown += panelDopColor_MouseDown;
            panel9.MouseDown += panelDopColor_MouseDown;


            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
       

    }

        public ITransport getLoco { get { return loco; } }

        private void DrawLoco()
        {
            if(loco != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                loco.setPosition(5, 5);
                loco.drawLocomotive(gr);
                pictureBox1.Image = bmp;
            }
        }

        private event myDel eventAddLoco;

        public void AddLoco(myDel ev)
        {
            if(eventAddLoco == null)
            {
                eventAddLoco = new myDel(ev);
            }
            else
            {
                eventAddLoco += ev;
            }
        }

        private void FormSelectLoco_Load(object sender, EventArgs e)
        {

        }

        private void labelLoco_MouseDown(object sender, MouseEventArgs e)
        {
            labelLoco.DoDragDrop(labelLoco.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void q_Click(object sender, EventArgs e)
        {
        }

        private void panelLoco_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Локомотив":
                    loco = new Locomotive(100,4,100,Color.Black);
                    break;
                case "Тепловоз":
                    loco = new CartLocomotive(100, 4, 100, Color.Black, true, true, Color.Bisque);
                    break;
            }
            DrawLoco();

        }

        private void panelLoco_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (loco != null)
            {
                loco.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawLoco();
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
          
        }
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (loco != null)
            {
                if (loco is CartLocomotive)
                {
                    (loco as CartLocomotive).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawLoco();
                }
            }

        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelDopColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(eventAddLoco != null)
            {
                eventAddLoco(loco);
            }
            Close();
        }

        private void labelCartLoco_MouseDown(object sender, MouseEventArgs e)
        {
            labelCartLoco.DoDragDrop(labelCartLoco.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelDopColor_Click(object sender, EventArgs e)
        {

        }
    }
}
