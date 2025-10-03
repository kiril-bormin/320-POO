using Drones.Helpers;

namespace Drones
{
    public static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            List<Drone> fleet = new List<Drone>();
            for (int i = 0; i < 9; i++)
            {
                Drone drone = new Drone(RandomHelpers.random.Next(1, 1000), RandomHelpers.random.Next(1, 1000));
                drone.Name = "Joe";
                fleet.Add(drone);
            }
            // Création de la flotte de drones
            int id = 0;
            List<Building> city = new List<Building>();
            Building factory1 = new Factory(500, 100, 5.95, id);
            id++;
            city.Add(factory1);
            Building factory2 = new Factory(200, 500, 5.95, id);
            id++;
            city.Add(factory2);

            Building store1 = new Store(100, 100, "Lundi: 8h-18h,\r\nMardi: 8h-18h,\r\nMercredi: 8h-18h,\r\nJeudi: 8h-18h,\r\nVendredi: 8h-18h,\r\nSamedi: 10h-16h,\r\nDimanche: Fermé");
            city.Add(store1);
            Building store2 = new Store(200, 200, "Lundi: 8h-18h,\r\nMardi: 8h-18h,\r\nMercredi: 8h-18h,\r\nJeudi: 8h-18h,\r\nVendredi: 8h-18h,\r\nSamedi: 10h-16h,\r\nDimanche: Fermé");
            city.Add(store2);

            // Démarrage
            
            try
            {
                Application.Run(new AirSpace(fleet, city));
            }
            catch (Exception e)
            {
                Console.Write(e.Message);
                
            }
        }
    }
}