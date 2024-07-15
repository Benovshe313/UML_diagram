

namespace UML_diagram.Models
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int number);
        void SetEngine(string engine);
        void SetTripComputer(string computer);
        void SetGPS(string gps);
    }
}
