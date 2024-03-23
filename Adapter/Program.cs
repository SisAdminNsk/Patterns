namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Traveler traveler = new Traveler(new Car());
            traveler.Travel();

            Camel camel = new Camel();
            traveler.SetTransport(new CamelToTransportAdapter(camel));
            traveler.Travel();
        }
    }
}
