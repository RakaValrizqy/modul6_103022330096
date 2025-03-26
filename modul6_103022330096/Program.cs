// See https://aka.ms/new-console-template for more information
using modul6_103022330096;

class Program
{
    public static void Main(string[] args)
    {
        //membuat user
        SayaTubeUser userRaka = new SayaTubeUser("Raka");

        //add film 1
        SayaTubeVideo film1 = new SayaTubeVideo("Review Film Arcane oleh Raka");
        film1.IncreasePlayCount(100000);
        userRaka.AddVideo(film1);

        //add film 2
        SayaTubeVideo film2 = new SayaTubeVideo("Review Film Invincible oleh Raka");
        film2.IncreasePlayCount(100000);
        userRaka.AddVideo(film2);

        //add film 3
        SayaTubeVideo film3 = new SayaTubeVideo("Review Film Fight Club oleh Raka");
        film3.IncreasePlayCount(100000);
        userRaka.AddVideo(film3);

        //add film 4
        SayaTubeVideo film4 = new SayaTubeVideo("Review Film Spirited Away oleh Raka");
        film4.IncreasePlayCount(100000);
        userRaka.AddVideo(film4);

        //add film 5
        SayaTubeVideo film5 = new SayaTubeVideo("Review Film Lion King oleh Raka");
        film5.IncreasePlayCount(100000);
        userRaka.AddVideo(film5);

        //add film 6
        SayaTubeVideo film6 = new SayaTubeVideo("Review Film Agak Laen oleh Raka");
        film6.IncreasePlayCount(100000);
        userRaka.AddVideo(film6);

        //add film 7
        SayaTubeVideo film7 = new SayaTubeVideo("Review Film Interstellar oleh Raka");
        film7.IncreasePlayCount(100000);
        userRaka.AddVideo(film7);

        //add film 8
        SayaTubeVideo film8 = new SayaTubeVideo("Review Film The Dark Knight oleh Raka");
        film8.IncreasePlayCount(100000);
        userRaka.AddVideo(film8);

        //add film 9
        SayaTubeVideo film9 = new SayaTubeVideo("Review Film The Dark Knight Rises oleh Raka");
        film9.IncreasePlayCount(100000);
        userRaka.AddVideo(film9);

        //add film 10
        SayaTubeVideo film10 = new SayaTubeVideo("Review Film The Batman oleh Raka");
        film10.IncreasePlayCount(100000);
        userRaka.AddVideo(film10);

        //video detail film 8
        film8.PrintVideoDetails();

        //get total video play count
        Console.WriteLine($"Total Play count: {userRaka.GetTotalVideoPlayCount()}");

        //print all video
        userRaka.PrintAllVideoPlaycount();
    }
}