namespace TasksApp.Model
{
    internal class TorpedoService
    {
        public void Fire(GpsLocation location)
        {
            Console.WriteLine("Fired!");

            Thread.Sleep(5000);

            Console.WriteLine( $"Hit {location}");
        }
    }
}
