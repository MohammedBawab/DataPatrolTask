using System;

namespace RandomNumberApp.Helpers
{
    public class Listener
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int TargetNumber { get; private set; }
        public int Counter { get; private set; }

        public Listener(int listenerId)
        {
            Id = listenerId;
            Name = "Listener " + Id.ToString();
            var random = new Random();
            TargetNumber = random.Next(1, 11);
            Counter = 0;
        }

        public void Count(int number)
        {
            if (number == TargetNumber)
            {
                Counter++;
            }
        }
    }
}