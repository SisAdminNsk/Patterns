using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public class LowQualityWorkerRewardSystem : BaseRewardSystem, IRewardSystem
    {
        public LowQualityWorkerRewardSystem(Worker awardedWorker) : base(awardedWorker)
        {
        }

        public void Reward()
        {
            Console.WriteLine(awardedWorker.Name + "Happy birthday! ");
        }
    }
}
