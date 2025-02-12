namespace BlazorState.State.Models
{
    public class GenericState : BaseState
    {
        private int? genericId;

        public int? GenericId
        {
            get => genericId;
            set
            {
                genericId = value;
                NotfyStateChanged();
            }
        }
    }
}
