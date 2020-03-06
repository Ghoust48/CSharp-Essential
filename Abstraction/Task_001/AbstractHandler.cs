namespace Abstraction
{
    public abstract class AbstractHandler
    {
        protected string FileName;
        
        public abstract void Open();
        
        public abstract void Create();
        
        public abstract void Change();
        
        public abstract void Save();
    }
}