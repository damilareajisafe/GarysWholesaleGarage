//using Garage;

namespace Garage
{
    class Program
    {
        static void Main(string[] args)
        {
            Zero fxs = new Zero();
            Tesla modelS = new Tesla();
            Cessna mx410 = new Cessna();
            Ram F5 = new Ram();

            fxs.MainColor = "Red";
            fxs.Drive();
            fxs.Turn("right");
            fxs.Stop();

            Console.WriteLine("");

            modelS.MainColor = "Blue";
            modelS.Drive();
            modelS.Turn("left");
            modelS.Stop();

            Console.WriteLine("");


            mx410.MainColor = "White";
            mx410.Drive();
            mx410.Turn("right");
            mx410.Stop();

            Console.WriteLine("");

            F5.MainColor = "Pink";
            F5.Drive();
            F5.Turn("left");
            F5.Stop();
        }
    }
}