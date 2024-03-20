namespace Observer
{
    public class Program
    {
        public static void Main(string[] args)
        {
            NewsAgregator newsAgent = new NewsAgregator();

            Reader firstReader = new Reader("Artem");
            Reader secondReader = new Reader("Mark");

            IDisposable cancellationTokenOne = newsAgent.Subscribe(firstReader);
            IDisposable cancellationTokenTwo = newsAgent.Subscribe(secondReader);

            News firstNews = new News("title#", "desc#");
            News secondNews = new News("title2#", "desc2#");
            News thirdNews = new News("title3#", "desc3#");

            newsAgent.Notify(firstNews);
            newsAgent.Notify(secondNews);
            cancellationTokenTwo.Dispose(); // отписываем secondReader от получения новостей
            newsAgent.Notify(thirdNews);
        }
    }
}