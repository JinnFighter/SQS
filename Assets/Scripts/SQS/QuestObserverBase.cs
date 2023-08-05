namespace SQS
{
    public abstract class QuestObserverBase : IQuestObserver
    {
        protected readonly QuestBase Quest;

        protected QuestObserverBase(QuestBase quest)
        {
            Quest = quest;
        }

        protected abstract void UpdateProgress();

        public void Update()
        {
            if(Quest.IsCompleted)
                return;
            
            UpdateProgress();
            if (Quest.CurrentProgress >= Quest.MaxStepCount) Quest.Complete();
        }
    }
}