using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace TextBasedTitanQuest.Music
{
    class Play
    {
        public static bool isOn = true;
        private static string filePath = Environment.CurrentDirectory + @"\Titan quest Game files\Music\";
        public static void Intro()
        {
            SoundPlayer player = new SoundPlayer(filePath + "Titan quest.wav");
            player.Play();
        }
        public static void Select()
        {
            var player =new WMPLib.WindowsMediaPlayer();
            player.URL = filePath + "Select.wav";
        }
        public static void StopMusic()
        {
            SoundPlayer player = new SoundPlayer();
            player.Stop();
        }
    }
}
