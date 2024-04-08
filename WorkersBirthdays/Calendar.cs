
namespace WorkersBirthdays
{
    public class Calendar : Observable
    {
        public DateOnly TodayDate {  get; set; }

        public Calendar(DateOnly initDate,List<IObserver> observers) : base(observers)
        {
            TodayDate = initDate;
        }

        public void UpdateDate(DateOnly newDate)
        {
            this.TodayDate = newDate;
            base.Notify(newDate);
        }
    }
}
