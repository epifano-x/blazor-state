namespace BlazorState.State
{
    public class BaseState
    {
        public event Func<Task>? OnChange;
        
        private readonly SynchronizationContext syncContext = SynchronizationContext.Current ?? throw new InvalidOperationException("SyncronizationContext is no set");

        public virtual void NotfyStateChanged()
        {
            var onChage = OnChange;
            if(onChage != null)
            {
                syncContext.Post(async _ => await onChage.Invoke(), null);
            }
        }
    }
}
