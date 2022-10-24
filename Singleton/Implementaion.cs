namespace Singleton
{
    public class Logger
    {
        // Lazy<T>
        private static readonly Lazy<Logger> _lazyLogger
            = new Lazy<Logger>(() => new Logger());

        public static Logger Instance
        {
            get
            {
                return _lazyLogger.Value;
            }
        }
        protected Logger()
        {

        }
        
        // Singleton Operation
        public void Log(string message)
        {
            Console.WriteLine($"Message to log: {message}!");
        }
    }
}
