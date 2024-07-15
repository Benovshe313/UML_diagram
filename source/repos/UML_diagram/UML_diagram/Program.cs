using UML_diagram.Models;

namespace UML_diagram
{
    public class Client
    {
        static void Main(string[] args)
        {
            var director = new Models.Director();

            var carBuilder = new Models.CarBuilder();
            var manualBuilder = new Models.CarManualBuilder();

            director.MakeSportsCar(carBuilder);
            director.MakeSportsCar(manualBuilder);

            Car car = carBuilder.GetResult();
            Manual manual = manualBuilder.GetResult();

            Console.WriteLine(car);
            Console.WriteLine(manual);
        }
    }
}
