using System.Timers;
using System.Windows.Input;
using Trying_Handy_Org_Custom_Controls.Command;

namespace Trying_Handy_Org_Custom_Controls.ViewModel
{
    public class StartLoadViewModel : ViewModelBase
    {
        private int _value;
        public int Value
        {
            get => _value;
            set
            {
                _value = value;
                OnPropertyChanged();
            }
        }

        public int MinValue { get; set; }

        public int MaxValue { get; set; } = 100;

        private bool _isRunning;
        public bool IsRunning
        {
            get => _isRunning;
            set
            {
                _isRunning = value;
                OnPropertyChanged();
            }
        }

        private ICommand _command;
        public ICommand Command
        {
            get
            {
                return _command ??= new Commander(() =>
                {
                    IsRunning = true;
                    var timer = new Timer(50);

                    timer.Elapsed += (s, e) =>
                    {
                        Value++;

                        if (Value >= MaxValue)
                        {
                            timer.Stop();
                            timer.Dispose();
                            IsRunning = false;
                            Value = MinValue;
                        }
                    };
                    timer.Start();
                });
            }
        }
    }
}