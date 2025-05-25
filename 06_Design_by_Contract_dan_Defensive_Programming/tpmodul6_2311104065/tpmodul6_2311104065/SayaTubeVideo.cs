using System;
namespace tpmodul6_2311104065
{
    class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            Random random = new Random();
            this.id = random.Next(10000, 99999); // generate random 5 digit number
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0)
            {
                Console.WriteLine("Play count yang ditambahkan tidak boleh negatif.");
                return;
            }

            try
            {
                checked
                {
                    playCount += count;
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Jumlah play count melebihi batas maksimal.");
                playCount = int.MaxValue;
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("Video ID: " + id);
            Console.WriteLine("Judul Video: " + title);
            Console.WriteLine("Jumlah Play: " + playCount);
            Console.WriteLine();
        }
    }
}



