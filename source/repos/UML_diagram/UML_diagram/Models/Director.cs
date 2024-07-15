using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UML_diagram.Models
{
    public class Director
    {
        public void MakeSUV(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(6);
            builder.SetEngine("SUV engine");
            builder.SetTripComputer("SUV trip computer");
            builder.SetGPS("SUV GPS");
        }
        public void MakeSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(4);
            builder.SetEngine("Sportcar engine");
            builder.SetTripComputer("Sportcar trip computer");
            builder.SetGPS("Sportcar GPS");
        }
    }
}
