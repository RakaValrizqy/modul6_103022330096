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
            try
            {
                if (judul == null)
                {
                    throw new ArgumentException("Judul tidak boleh kosong.");
                }
                if (judul.Length > 200)
                {
                    throw new ArgumentException("Judul tidak boleh lebih dari 200 karakter.");
                }
                
                this.title = judul;
                this.id = rand.Next(10000, 99999);
                this.playCount = 0;
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }

        public void IncreasePlayCount(int angka)
        {
            try
            {
                if (angka > 25000000)
                {
                    throw new ArgumentException("Penambahan play count tidak boleh lebih dari 25000000 dalam sekali penambahan.");
                }
                if (angka < 0)
                {
                    throw new ArgumentException("Penambahan play count tidak boleh negatif.");
                }

                checked
                {
                    this.playCount += angka;
                }
                
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            } catch (OverflowException)
            {
                Console.WriteLine("Error: Terjadi Overflow saat menambah play count.");
            }
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
