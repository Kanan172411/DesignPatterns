namespace Singleton
{
    public class Logger
    {
        private static readonly Lazy<Logger> _instanceLazy = new Lazy<Logger>(() => new Logger());

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

        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}");
        }
    }
}
