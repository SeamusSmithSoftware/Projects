using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;
using System.Diagnostics;

namespace Samuel_L_Jackson_quote_generator
{
    class Program
    {
        static void Main(string[] args)
        {

            int value = 0;
            string path2 = Directory.GetCurrentDirectory();
            string filepath = "";
            filepath = Path.GetDirectoryName(path2);
            filepath = Path.GetDirectoryName(filepath);
            filepath = Path.GetDirectoryName(filepath);
            while (true)
            {
                int value2 = 0;
                value2 = value;
                Random random = new Random();
                while (value == value2)
                {
                    value = random.Next(1, 5);
                }
                Console.WriteLine(path2);
                Console.ReadLine();
                if (value == 1)
                {
                    SoundPlayer player = new SoundPlayer(path2 + @"\It's_a_stupid_ass_decision (1).wav");
                    player.Play();
                }
                else if (value == 2)
                {
                    SoundPlayer player = new SoundPlayer(path2 + @"\It's_a_stupid_ass_decision (2).wav");
                    player.Play();
                }
                else if (value == 3)
                {
                    SoundPlayer player = new SoundPlayer(path2 + @"\It's_a_stupid_ass_decision (3).wav");
                    player.Play();
                }
                else if (value == 4)
                {
                    SoundPlayer player = new SoundPlayer(path2 + @"\It's_a_stupid_ass_decision (4).wav");
                    player.Play();

                }
            }
        }
    }
}
