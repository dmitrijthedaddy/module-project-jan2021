using System;

namespace TrainStorage
{
    public class Train : IComparable
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

        int IComparable.CompareTo(object obj)
        {
            if (obj == null) return -1;

            Train train = obj as Train;
            if (Number == train.Number) return 0;

            return 1;
        }
    }
}
