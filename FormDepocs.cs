using Lab3;
using NLog;
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
    public partial class FormDepocs : Form
    {
        Depo depo;

        FormSelectLoco form;

        private Logger log;
        public Logger errors;

        public FormDepocs()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
            errors = LogManager.GetCurrentClassLogger();
            depo = new Depo(5);
            for (int i = 1; i < 6; i++)
            {
                listBoxLevels.Items.Add("Уровень " + i);
            }
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
   
            Draw();
        }

        private void Draw()
        {
            if (listBoxLevels.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                depo.Draw(gr, pictureBoxParking.Width, pictureBoxParking.Height);
                pictureBoxParking.Image = bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorDialog dialog = new ColorDialog();
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var locomotive = new Locomotive(100, 4, 1000, dialog.Color);
                int place = depo.PutLocoInDepo(locomotive);
                Draw();
                MessageBox.Show("Ваше место: " + place);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            {
                ColorDialog dialog = new ColorDialog();
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    ColorDialog dialogDop = new ColorDialog();
                    if (dialogDop.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        var locomotive = new CartLocomotive(100, 4, 1000, dialog.Color, true, true, dialogDop.Color);
                        int place = depo.PutLocoInDepo(locomotive);
                        Draw();
                        MessageBox.Show("Ваше место: " + place);
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                if (listBoxLevels.SelectedIndex > -1)
                {//Прежде чем забрать машину, надо выбрать с какого уровня будем забирать
                    string level = listBoxLevels.Items[listBoxLevels.SelectedIndex].ToString();
                    if (maskedTextBox1.Text != "")
                    {
                        try
                        {
                            var locomotive = depo.GetLocoInDepo(Convert.ToInt32(maskedTextBox1.Text));

                            Bitmap bmp = new Bitmap(pictureBoxTakeCar.Width, pictureBoxTakeCar.Height);
                            Graphics gr = Graphics.FromImage(bmp);
                            locomotive.setPosition(20, 50);
                            locomotive.drawLocomotive(gr);
                            pictureBoxTakeCar.Image = bmp;
                            Draw();
                        }catch(DepoIndexOutOfRangeException ex)
                        {
                            MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK);
                            errors.Error("Нет такого номера!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK);
                            errors.Error("Общая ошибка!");
                        }
                    }
                    else
                    {//иначесообщаемобэтом
                        MessageBox.Show("Извинте, на этом месте нет машины");
                    }

                }
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            depo.LevelDown();
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
            log.Info("Переход на уровень ниже. Текущий уровень: " + depo.getCurrentLevel);
            Draw();

        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            depo.LevelUp();
            listBoxLevels.SelectedIndex = depo.getCurrentLevel;
            log.Info("Переход на уровень выше. Текущий уровень: " + depo.getCurrentLevel);
            Draw();

        }

        private void buttonSetLoco_Click(object sender, EventArgs e)
        {
            form = new FormSelectLoco();
            form.AddLoco(AddLoco);
            log.Info("Выбран локомотив");
            form.Show();

            
        }

        private void AddLoco(ITransport loco)
        {
            if (loco != null)
            {
                try
                {
                    int place = depo.PutLocoInDepo(loco);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                    log.Info("Добавлен локомотив с местом " + depo.getCurrentLevel);
                }
                catch(DepoOverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK);
                    errors.Error("Ошибка переполнения!");
                }
                catch(Exception e)
                {
                    errors.Error("Общая ошибка");
                    MessageBox.Show(e.Message, "Общая ошибка", MessageBoxButtons.OK);
                }               
             
            }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depo.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Успешное сохранение!");
                }
                else
                {
                    MessageBox.Show("Несохранилось", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Ошибка в сохранении");
                }
            }

        }

        private void звгрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (depo.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    log.Info("Успешная загрузка!");
                }
                else
                {
                    MessageBox.Show("Незагрузили", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    log.Info("Ошибка в загрузке!");
                }
                Draw();
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

