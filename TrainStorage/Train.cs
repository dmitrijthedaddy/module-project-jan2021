using System;
using System.Collections.Generic;

namespace TrainStorage
{
    class Train
    {
        public string Destination { get; set; }
        public int Number { get; set; }
        public DateTime Departure { get; set; }

        public Train(string destination, int number, DateTime departure)
        {
            Destination = destination;
            Number = number;
            Departure = departure;
        }
    }
}
