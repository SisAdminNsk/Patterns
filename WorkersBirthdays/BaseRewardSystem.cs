using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public abstract class BaseRewardSystem
    {
        protected Worker awardedWorker;

        public BaseRewardSystem(Worker awardedWorker)
        {
            this.awardedWorker = awardedWorker;
        }
    }
}
