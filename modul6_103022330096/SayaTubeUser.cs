using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022330096
{
    class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadedvideos;
        public String username;

        Random rand = new Random();

        public SayaTubeUser(string username) 
        {
            try
            {
                if (username == null)
                {
                    throw new ArgumentException("Username tidak boleh kosong.");
                }
                if (username.Length > 100)
                {
                    throw new ArgumentException("Username tidak boleh lebih dari 100 karakter.");
                }
                
                this.username = username;
                this.id = rand.Next(10000, 99999);
                this.uploadedvideos = new List<SayaTubeVideo>();
            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }

        public int GetTotalVideoPlayCount()
        {
            int jumlah = 0;
            for (int i=0; i<uploadedvideos.Count; i++) 
            {
                jumlah += uploadedvideos[i].GetPlayCount();
            }
            return jumlah;
        }

        public void AddVideo(SayaTubeVideo stv) 
        {
            try
            {
                if (stv == null)
                {
                    throw new ArgumentException("Video kosong.");
                }
                this.uploadedvideos.Add(stv);

            } catch (ArgumentException ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            
        }

        public void PrintAllVideoPlaycount() 
        {
            Console.WriteLine($"User: {username}");
            for (int i = 0; i < uploadedvideos.Count; i++) 
            {
                Console.WriteLine($"Video {i + 1} judul: {uploadedvideos[i].GetTitle()}");
            }
        }

    }
}
