namespace Singleton
{
    //Singleton
    public class Logger
    {
        private static readonly Lazy<Logger> _instanceLazy = new Lazy<Logger>(() => new Logger());

        //Instance
        public static Logger Instance
        {
            get
            {
                return _instanceLazy.Value;
            }
        }

        protected Logger()
        {

        }

        //SingletonOperation
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
