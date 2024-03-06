using System;

namespace _3
{
    class StatusManager
    {
        public event EventHandler<StatusEventArgs> StatusUpdated;

        public void UpdateStatus(string lastAction)
        {
            StatusEventArgs args = new StatusEventArgs(lastAction);
            OnStatusUpdated(args);
        }

        protected virtual void OnStatusUpdated(StatusEventArgs e)
        {
            Console.WriteLine("OnStatusUpdated");
            StatusUpdated?.Invoke(this, e);
        }
    }

    class StatusEventArgs : EventArgs
    {
        public string LastAction { get; }
        public string AdditionalText { get; }

        public StatusEventArgs(string lastAction)
        {
            LastAction = lastAction;
        }
    }
}
