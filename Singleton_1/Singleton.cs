namespace Singleton.Structural
{
    public sealed class Singleton
    {
        public static readonly Singleton instance = new Singleton();
        // Constructor is 'protected'
        private Singleton()
        {
        }
        
    }
}