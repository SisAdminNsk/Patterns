using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkersBirthdays
{
    public class HighQualityWorker : Worker
    {
        public HighQualityWorker(string name, DateOnly birthDayDate) : base(name, birthDayDate)
        {
        }
    }
}
