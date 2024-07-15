

namespace UML_diagram.Models
{
    public class Car
    {
        public int Seats { get; set; }
        public string Engine { get; set; }
        public string TripComputer { get; set; }
        public string GPS { get; set; }

        public override string ToString()
        {
            return $"Car details: Seats: {Seats}, Engine: {Engine}, TripComputer: {TripComputer}, GPS: {GPS}";
        }
    }
}
