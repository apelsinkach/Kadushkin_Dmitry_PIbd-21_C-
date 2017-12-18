﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Depo
    {
        List<ClassArray<ITransport>> parkingStages;

        int countPlaces = 5;

        int placeSizeWidth = 300;

        int placeSizeHeight = 100;

        int currentLevel;

        public int getCurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public Depo(int countStages)
        {
            parkingStages = new List<ClassArray<ITransport>>();
            
            for(int i = 0; i < countStages; i++)
            {
                ClassArray<ITransport> classarr = new ClassArray<ITransport>(5, null);
                parkingStages.Add(classarr);
            } 
            

        }

        public void LevelUp()
        {
            if (currentLevel + 1 < parkingStages.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }


        public int PutLocoInDepo(ITransport locomotive)
        {
            return parkingStages[currentLevel]+locomotive;
        }

        public ITransport GetLocoInDepo(int report)
        {
            return parkingStages[currentLevel]-report;
        }


        public void Draw(Graphics g, int width, int height)
        {
            DrawMarking(g);
            int i = 0;
            foreach(var locomotive in parkingStages[currentLevel])
            {
                locomotive.setPosition(5 + i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 45);
                locomotive.drawLocomotive(g);
                i++;
            }
        }

        public void Sort()
        {
            parkingStages.Sort();
        }

        public void DrawMarking(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 3);

            g.DrawString("L" + (currentLevel + 1), new Font("Arial", 30), new SolidBrush(Color.Blue),(countPlaces/3)*placeSizeWidth-70,420);
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

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename , FileMode.Create))
            {
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLeveles:" + parkingStages.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach(var level in parkingStages)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for (int i = 0; i < countPlaces; i++)
                        {
                            var loco = level[i];
                            if (loco != null)
                            {
                                if (loco.GetType().Name == "Locomotive")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Locomotive:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if(loco.GetType().Name == "CartLocomotive")
                                {
                                    info = new UTF8Encoding(true).GetBytes("CartLocomotive:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(loco.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                   
                }
            }
            return true;
        }

        public bool LoadData(string fileName)
        {
            if (!File.Exists(fileName))
            {
                return false;
            }
            using(FileStream fs = new FileStream(fileName, FileMode.Open))
            {
                string s = "";
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s=s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLeveles"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (parkingStages != null)
                    {
                        parkingStages.Clear();
                    }
                    parkingStages = new List<ClassArray<ITransport>>(count);
                }
                else
                {
                    return false;
                }
                int counter = -1;
                for(int i = 1; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        parkingStages.Add(new ClassArray<ITransport>(countPlaces, null));
                    }else if(strs[i].Split(':')[0]=="Locomotive"){
                        ITransport loco = new Locomotive(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + loco;
                        if(number == -1)
                        {
                            return false;
                        }
                    }else if (strs[i].Split(':')[0] == "CartLocomotive")
                    {
                        ITransport loco = new CartLocomotive(strs[i].Split(':')[1]);
                        int number = parkingStages[counter] + loco;
                        if (number == -1)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
