using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public abstract class Worker : IObserver
    {
        private IRewardSystem rewardSystem;
        public string Name {  get; set; }
        public DateOnly BirthDayDate { get; set; }

        public Worker(string name,DateOnly birthDayDate)
        {
            this.Name = name;
            this.BirthDayDate = birthDayDate;
        }

        public void SetRewardSystem(IRewardSystem rewardSystem)
        {
            this.rewardSystem = rewardSystem;
        }

        public void Update(object? parameter)
        {
            if (parameter is DateOnly date)
            {
                if (date.Month == BirthDayDate.Month &&
                date.Day == BirthDayDate.Day)
                {
                    rewardSystem.Reward();
                }
            }
        }
    }
}
