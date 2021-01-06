using System;
using System.Collections.Generic;

namespace TrainStorage
{
    class TrainList
    {
        protected List<Train> trains = new List<Train>();

        public TrainList()
        {
            trains.Add(new Train("Владивосток", 100, new DateTime(2021, 1, 20, 10, 00, 00)));
            trains.Add(new Train("Верхний Уфалей", 3661, new DateTime(2021, 1, 6, 14, 39, 00)));
            trains.Add(new Train("Нижний Тагил", 4276, new DateTime(2021, 1, 10, 17, 25, 00)));
            trains.Add(new Train("Сысерть", 1161, new DateTime(2021, 1, 11, 12, 11, 00)));
            trains.Add(new Train("Сысерть", 1161, new DateTime(2021, 1, 16, 9, 52, 00)));
        }

        public string[] GetStringifiedList()
        {
            string[] trainStrings = new string[trains.Count];

            for (int i = 0; i < trains.Count; i++)
            {
                var train = trains[i];
                trainStrings[i] = $"{train.Destination}, #{train.Number} " +
                                  $"[{train.Departure.Day}.{train.Departure.Month}.{train.Departure.Year} " +
                                  $"{train.Departure.Hour}:{train.Departure.Minute}]";
            }

            return trainStrings;
        }
    }

    class TrainStorage : TrainList
    {
        public void AddTrain(string destination, int number, DateTime departure)
        {
            trains.Add(new Train(destination, number, departure));
        }

        public void RemoveAllTrains()
        {
            trains.Clear();
        }

        public void RemoveTrainByIndex(int index)
        {
            trains.RemoveAt(index);
        }
    }
}
