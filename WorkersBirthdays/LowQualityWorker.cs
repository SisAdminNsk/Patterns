using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public class LowQualityWorker : Worker
    {
        public LowQualityWorker(string name, DateOnly birthDayDate) : base(name, birthDayDate)
        {
        }
    }
}
