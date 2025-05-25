using System;

public class SayaTubeVideo
{
    private int id;
    private string title;
    private int playCount;

    public SayaTubeVideo(string title)
    {
        if (string.IsNullOrEmpty(title) || title.Length > 100)
            throw new ArgumentException("Judul video tidak boleh kosong dan maksimal 100 karakter.");

        Random rnd = new Random();
        this.id = rnd.Next(10000, 99999);
        this.title = title;
        this.playCount = 0;
    }

    public void IncreasePlayCount(int count)
    {
        if (count < 0 || count > 10000000)
            throw new ArgumentException("Jumlah penambahan play count tidak valid (maks 10.000.000).");

        playCount += count;
    }

    public void PrintVideoDetails()
    {
        Console.WriteLine("ID Video     : " + id);
        Console.WriteLine("Judul Video  : " + title);
        Console.WriteLine("Play Count   : " + playCount);
        Console.WriteLine();
    }

    public int GetPlayCount()
    {
        return playCount;
    }

    public string GetTitle()
    {
        return title;
    }
}
