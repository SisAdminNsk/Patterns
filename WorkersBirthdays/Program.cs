using System;

namespace WorkersBirthdays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IObserver> workers = new List<IObserver>();

            workers.Add(new LowQualityWorker("John", new DateOnly(1999, 10, 12)));
            workers.Add(new LowQualityWorker("Michel", new DateOnly(1999, 10, 12)));
            workers.Add(new LowQualityWorker("Max", new DateOnly(1999, 10, 13)));

            workers.Add(new HighQualityWorker("Vladimir", new DateOnly(1999, 10, 16)));
            workers.Add(new HighQualityWorker("Roman", new DateOnly(1999, 10, 18)));

            foreach (var worker in workers)
            {
                if (worker is LowQualityWorker lqWorker)
                {
                    lqWorker.SetRewardSystem(new LowQualityWorkerRewardSystem(lqWorker));
                }

                if (worker is HighQualityWorker gqWorker)
                {
                    gqWorker.SetRewardSystem(new HighQualityWorkerRewardSystem(gqWorker));
                }
            }

            Calendar calendar = new Calendar(new DateOnly(2024, 10, 9), workers);

            List<DateOnly> dates = new List<DateOnly>();

            dates.Add(new DateOnly(2024, 10, 10));
            dates.Add(new DateOnly(2024, 10, 11));
            dates.Add(new DateOnly(2024, 10, 12));
            dates.Add(new DateOnly(2024, 10, 13));
            dates.Add(new DateOnly(2024, 10, 14));
            dates.Add(new DateOnly(2024, 10, 15));
            dates.Add(new DateOnly(2024, 10, 16));
            dates.Add(new DateOnly(2024, 10, 17));
            dates.Add(new DateOnly(2024, 10, 18));

            foreach (DateOnly date in dates)
            {
                Console.WriteLine("Today date: " + date);
                Thread.Sleep(1000);
                calendar.UpdateDate(date);
            }
        }
    }
}

