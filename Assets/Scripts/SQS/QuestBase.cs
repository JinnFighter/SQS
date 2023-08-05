namespace SQS
{
    public abstract class QuestBase : IQuest
    {
        public int CurrentProgress { get; set; }
        public int MaxStepCount { get; }
        public bool IsCompleted { get; private set; }

        protected QuestBase(int currentProgress, int maxStepCount)
        {
            CurrentProgress = currentProgress;
            MaxStepCount = maxStepCount;
        }
    
        public void Complete()
        {
            IsCompleted = true;
        }
    }
}
