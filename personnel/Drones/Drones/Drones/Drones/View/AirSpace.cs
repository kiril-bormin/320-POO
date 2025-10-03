using Drones;
using Drones.Model;
using System.Diagnostics;
using System.Timers;

namespace Drones
{
    // La classe AirSpace représente le territoire au dessus duquel les drones peuvent voler
    // Il s'agit d'un formulaire (une fenêtre) qui montre une vue 2D depuis en dessus
    // Il n'y a donc pas de notion d'altitude qui intervient

    public partial class AirSpace : Form
    {
        public static readonly int WIDTH = 1200;        // Dimensions of the airspace
        public static readonly int HEIGHT = 600;
        public Stopwatch stopWatch = new Stopwatch();
        int counter;



        // La flotte est l'ensemble des drones qui évoluent dans notre espace aérien
        private List<Drone> fleet;

        private List<Building> city;

        BufferedGraphicsContext currentContext;
        BufferedGraphics airspace;


        // Initialisation de l'espace aérien avec un certain nombre de drones
        public AirSpace(List<Drone> fleet, List<Building> city)
        {
            InitializeComponent();
            // Gets a reference to the current BufferedGraphicsContext
            currentContext = BufferedGraphicsManager.Current;
            // Creates a BufferedGraphics instance associated with this form, and with
            // dimensions the same size as the drawing surface of the form.
            airspace = currentContext.Allocate(this.CreateGraphics(), this.DisplayRectangle);
            this.fleet = fleet;
            this.city = city;
            stopWatch.Start();

            if (fleet.Count >= 10)
            {
                throw new Exception("Message");
            }
            Rectangle r2 = new Rectangle(30, 100, 150, 100);
        }


        // Affichage de la situation actuelle
        private void Render()
        {
            airspace.Graphics.Clear(Color.AliceBlue);

            // draw drones
            foreach (Drone drone in fleet)
            {
                drone.Render(airspace);

            }
            foreach (Building building in city)
            {
                building.Render(airspace);
            }

            airspace.Render();
        }

        // Calcul du nouvel état après que 'interval' millisecondes se sont écoulées
        private void Update(int interval)
        {
            foreach (Drone drone in fleet)
            {
                drone.Update(interval);
            }
            foreach(Building building in city)
            {
                if (counter % 50 == 0)
                {
                    building.Update();
                }
            }
        }
        // Méthode appelée à chaque frame
        private void NewFrame(object sender, EventArgs e)
        {
            // frames = 10/s
            // frames = 540/m
            counter++;

            this.Update(ticker.Interval);
            this.Render();
            
        }
    }
}