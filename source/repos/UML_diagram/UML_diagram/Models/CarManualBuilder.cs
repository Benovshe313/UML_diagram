

namespace UML_diagram.Models
{
    internal class CarManualBuilder :IBuilder
    {
        private Manual manual;
        public CarManualBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.manual = new Manual();
        }
        public void SetSeats(int number)
        {
            this.manual.Seats = number;
        }
        public void SetEngine(string engine)
        {
            this.manual.Engine = engine;
        }
        public void SetTripComputer(string computer)
        {
            this.manual.TripComputer = computer;
        }
        public void SetGPS(string gps)
        {
            this.manual.GPS = gps;

        }
        public Manual GetResult()
        {
            return this.manual;
        }
    }
}
