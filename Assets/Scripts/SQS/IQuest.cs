namespace SQS
{
    public interface IQuest
    {
        int CurrentProgress { get; }
        int MaxStepCount { get; }
        bool IsCompleted { get; }

        void Complete();
    }
}