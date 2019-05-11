namespace ConsoleApp4
{
    public class Singleton
    {
        public string Value { get; set; }

        private Singleton() { }

        private static Singleton _instance;

        private static readonly object _lock = new object();

        internal static Singleton GetIntance(string value)
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                        _instance.Value = value;
                    }
                }
            }
            return _instance;
        }
    }
}