using System;

namespace P01.Stream_Progress
{
    public class Program
    {
        static void Main()
        {
            File music = new Music("Pesho", "Pesho's songs", 10, 10);

            File file = new File("File", 20, 30);

            StreamProgressInfo streamProgressInfo1 = new StreamProgressInfo(music);
            StreamProgressInfo streamProgressInfo2 = new StreamProgressInfo(file);

            streamProgressInfo1.CalculateCurrentPercent();
            streamProgressInfo2.CalculateCurrentPercent();
        }
    }
}