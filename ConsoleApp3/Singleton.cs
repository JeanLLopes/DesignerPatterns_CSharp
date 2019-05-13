namespace ConsoleApp3
{
    public class Singleton
    {
        private Singleton() { }
        private static Singleton _intance;

        public static Singleton GetInstance()
        {
            if (_intance == null)
            {
                _intance = new Singleton();
            }
            return _intance;
        }
    }
}
