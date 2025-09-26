using Drones;


namespace DroneTests
{
    [TestClass]
    public class DroneTests
    {
        [TestMethod]
        public void If_X_Of_Drone_Is_100()
        {
            Drone drone = new Drone();
            int expectedX = 100;

            drone.X = expectedX;

            Assert.AreEqual(expectedX, drone.X, "La coordonnée X du drone n'est pas correcte.");

        }
        
    }
}
