

namespace UML_diagram.Models
{
    public class CarBuilder : IBuilder
    {
        private Car car;
        public CarBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.car = new Car();
        }
        public void SetSeats(int number)
        {
            this.car.Seats = number;
        }
        public void SetEngine(string engine)
        {
            this.car.Engine = engine;
        }
        public void SetTripComputer(string computer)
        {
            this.car.TripComputer = computer;
        }
        public void SetGPS(string gps)
        {
            this.car.GPS = gps;

        }
        public Car GetResult()
        {
            return this.car;
        }
    }
}
