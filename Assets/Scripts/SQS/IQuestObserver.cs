namespace SQS
{
    public interface IQuestObserver
    {
        void UpdateProgress();
        void Update();
    }
}