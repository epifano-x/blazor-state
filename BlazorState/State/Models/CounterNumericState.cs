namespace BlazorState.State.Models
{
    public class CounterNumericState : BaseState
    {
        private int? counterNumeric = 0;
        
        public int? CounterNumeric
        {
            get => counterNumeric;
            set
            {
                counterNumeric = value;
                NotfyStateChanged();
            }
        }
    }
}
