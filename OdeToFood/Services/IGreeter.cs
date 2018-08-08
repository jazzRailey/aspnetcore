namespace OdeToFood
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }
    public class Greeter : IGreeter
    {
        public string GetMessageOfTheDay()
        {
            return "Greetings from the Greeter Class that implements IGreeter";
        }
    }
}