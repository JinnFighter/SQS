namespace SQS
{
    public class SQSystem
    {
        public bool IsInit { get; private set; }

        public void Init()
        {
            IsInit = true;
        }

        public void Destroy()
        {
            IsInit = false;
        }
    }
}