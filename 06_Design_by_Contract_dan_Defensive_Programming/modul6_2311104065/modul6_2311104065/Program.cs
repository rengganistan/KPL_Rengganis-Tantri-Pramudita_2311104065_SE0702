using System;

public class Program
{
    public static void Main()
    {
        SayaTubeUser user = new SayaTubeUser("Rengganis");

        string[] filmTitles = {
            "Review Film Beranak Dalam Kubur oleh Rengganis",
            "Review Film Inception oleh Rengganis",
            "Review Film The Dark Knight oleh Rengganis",
            "Review Film Parasite oleh Rengganis",
            "Review Film Joker oleh Rengganis",
            "Review Film Dune oleh Rengganis",
            "Review Film Tenet oleh Rengganis",
            "Review Film Whiplash oleh Rengganis",
            "Review Film La La Land oleh Rengganis",
            "Review Film The Shawn the Sheep oleh Rengganis"
        };

        foreach (var title in filmTitles)
        {
            SayaTubeVideo video = new SayaTubeVideo(title);
            video.IncreasePlayCount(100);
            user.AddVideo(video);
        }

        user.PrintAllVideoPlaycount();
        Console.WriteLine("Total Play Count Semua Video: " + user.GetTotalVideoPlayCount());
    }
}
