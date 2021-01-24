using System;
using System.Collections.Generic;

namespace TrainStorage
{
    public class TrainDestinationComparer : IComparer<Train>
    {
        public int Compare(Train x, Train y)
        {
            return String.Compare(x.Destination, y.Destination);
        }
    }

    public class TrainNumberComparer : IComparer<Train>
    {
        public int Compare(Train x, Train y)
        {
            if (x.Number > y.Number) return 1;
            if (x.Number < y.Number) return -1;
            return 0;
        }
    }

    public class TrainDepartureComparer : IComparer<Train>
    {
        public int Compare(Train x, Train y)
        {
            return DateTime.Compare(x.Departure, y.Departure);
        }
    }
}
