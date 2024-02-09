using TasksApp.Model;

namespace TasksApp
{
    internal class Program
    {
        static void Main(string[] args)
        {


            GpsLocalizator localizator = new GpsLocalizator();
            TorpedoService torpedoService = new TorpedoService();

            Console.WriteLine("Przygotowania zadania");
            // Task<GpsLocation> task = new Task<GpsLocation>(() => localizator.GetCurrentLocation());

            Console.WriteLine("Hello, World!");

            Console.WriteLine("Uruchomienie zadania");

            // Task<GpsLocation> task = new Task<GpsLocation>(() => localizator.GetCurrentLocation());
            // task.Start();

            Task<GpsLocation> task = Task.Run(() => localizator.GetCurrentLocation());

            Console.WriteLine("...");

            // GpsLocation location1 = localizator.GetCurrentLocation();
            // Console.WriteLine(task.Result);

            task    
                .ContinueWith(t =>
                    Task.Run(() => torpedoService.Fire(t.Result)));

            //GpsLocation location2 = localizator.GetCurrentLocation();
            //Console.WriteLine(location2);

            //GpsLocation location3 = localizator.GetCurrentLocation();
            //Console.WriteLine(location3);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();


        }
    }
}
