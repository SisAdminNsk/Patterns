using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public class HighQualityWorkerRewardSystem : BaseRewardSystem, IRewardSystem
    {
        public HighQualityWorkerRewardSystem(Worker awardedWorker) : base(awardedWorker)
        {
        }

        public void Reward()
        {
            Console.WriteLine(awardedWorker.Name + "Happy birthday! " +
                "\nyou are very valuable to our company");
        }
    }
}
