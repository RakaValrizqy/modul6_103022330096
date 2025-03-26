using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330096
{
    class SayaTubeVideo
    {
        private int id;
        private String title;
        private int playCount;

        Random rand = new Random();

        public SayaTubeVideo(String judul) 
        {
            this.title = judul;
            this.id = rand.Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int angka)
        {
            this.playCount += angka;
        }

        public void PrintVideoDetails() 
        {
            Console.WriteLine($"ID: {id}, Title: {title}, Play Count: {playCount}");
        }

        public int GetPlayCount() 
        {
            return playCount;
        }

        public String GetTitle() 
        {
            return title;
        }
    }
}
