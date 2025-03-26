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
            this.username = username;
            this.id = rand.Next(10000, 99999);
            this.uploadedvideos = new List<SayaTubeVideo>();
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
            this.uploadedvideos.Add(stv);
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
