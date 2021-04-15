﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Dynamic;
using System.IO;
using System.Windows.Forms;
using YANMFA.Games.Alex.SpiderFighter.Models;
using YANMFA.Games.Alex.SpiderFighter.Models.Decorations;
using YANMFA.Games.Alex.SpiderFighter.Models.Mobs;

namespace YANMFA.Games.Alex.SpiderFighter
{
    public static class Round
    {
        public static Level CurrentLevel { get; set; }
        
        public static List<Level> Levels { get; set; }

        public static void Update()
        {
            foreach (var item in CurrentLevel.Items) {item.Update();}
            foreach (var mob in CurrentLevel.Mobs) {mob.Update();}
        }

        public static void Render(Graphics g)
        {
            foreach (var item in CurrentLevel.Items){item.Render(g);}
            foreach (var mobs in CurrentLevel.Mobs){mobs.Render(g);}
        }

        public static void MouseDown(MouseEventArgs e)
        {
            foreach (var item in CurrentLevel.Items){item.MouseDown(e);}
            foreach (var mobs in CurrentLevel.Mobs){mobs.MouseDown(e);}
        }

        public static void KeyDown(KeyEventArgs e)
        {
            foreach (var item in CurrentLevel.Items){item.KeyDown(e);}
            foreach (var mobs in CurrentLevel.Mobs){mobs.KeyDown(e);}
        }
           
        public static void Resize(int width, int height)
        {
            foreach (var item in CurrentLevel.Items){item.Resize(width,height);}
            foreach (var mobs in CurrentLevel.Mobs){mobs.Resize(width,height);}
            
        }

        //public static void LoadLevels()
        //{
        //    DirectoryInfo info = new DirectoryInfo(Environment.CurrentDirectory + "\\levels");
        //    foreach (FileInfo item in info.GetFiles())
        //    {
        //        string currentstring = "";
        //        List<string> lines = new List<string>();
        //        Level level = new Level();

        //        StreamReader stream = item.OpenText();
        //        string fullText = stream.ReadToEnd();

        //        for (int i = 0; i < fullText.Length; i++)
        //        {
        //            if (fullText[i] != '>')
        //            {
        //                currentstring = currentstring + fullText[i];
        //            }
        //            else
        //            {
        //                currentstring.Replace('>', '\0');
        //                currentstring = currentstring.Replace("\r\n", "");
        //                lines.Add(currentstring);
        //                currentstring = "";
        //            }
        //        }

        //        foreach (string line in lines)
        //        {
        //            string currentdata = "";

        //            List<string> data = new List<string>();
        //            for (int i = 0; i < line.Length; i++)
        //            {
        //                if (line[i] != ';')
        //                {
        //                    currentdata = currentdata + line[i];
        //                }
        //                else
        //                {
        //                    currentdata.Replace(';', '\0');
        //                    data.Add(currentdata);
        //                    currentdata = "";
        //                }
        //            }

        //            switch (data[0])
        //            {
        //                case "Block":
        //                    if (data[6] == "True")
        //                    {
        //                        var barrier = new BarrierBlock(new RectangleF((float)Convert.ToDouble(data[1]), (float)Convert.ToDouble(data[2]), (float)Convert.ToDouble(data[3]), (float)Convert.ToDouble(data[4])), Item.TextureConverter((Item.ItemTextures)(Enum.Parse(typeof(Item.ItemTextures), data[5]))));
        //                        level.Items.Add(barrier);
        //                    }
        //                    else if (data[6] == "False")
        //                    {
        //                        var decoblock = new BarrierBlock(new RectangleF((float)Convert.ToDouble(data[1]), (float)Convert.ToDouble(data[2]), (float)Convert.ToDouble(data[3]), (float)Convert.ToDouble(data[4])), Item.TextureConverter((Item.ItemTextures)(Enum.Parse(typeof(Item.ItemTextures), data[5]))));
        //                        level.Items.Add(decoblock);
        //                    }
        //                    break;
        //                case "Door":
        //                    var door = new Door(
        //                        new RectangleF((float)Convert.ToDouble(data[1]), (float)Convert.ToDouble(data[2]),
        //                            (float)Convert.ToDouble(data[3]), (float)Convert.ToDouble(data[4])),
        //                        Textures.IrondoorClose);
        //                    level.Doors.Add(door);
        //                    break;

        //                default:
        //                    break;
        //            }
        //        }
        //        Levels.Add(level);
        //    }
        //}
    }
}