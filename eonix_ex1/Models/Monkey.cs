using System;
using System.Collections.Generic;
using System.Text;

namespace eonix_ex1.Models
{
    // public delegate EventArgs Execute(MonkeyExecute monkeyExecute);

    public enum MonkeyTrick
    {
        acrobatics,
        music
    }

    public class MonkeyEventArgs : EventArgs
    {
        private MonkeyTrick _monkeyTrick;
        public MonkeyTrick Trick { 
                                    get => _monkeyTrick; 
                                    set { _monkeyTrick = value; }
                                 }

        private string _name;
        public string Name { 
                             get => _name;
                             set { _name = value; }
                            }

    }

    public class Monkey
    {
        public event EventHandler<MonkeyEventArgs> ExecuteTrick;

        private MonkeyEventArgs _eventArgs;

        public string Name { get; set; }

        public Monkey()
        {
            this._eventArgs = new MonkeyEventArgs();
        }

        public void WalkOnHands()
        {
            // OnExecute?.Invoke(MonkeyExecute.acrobatics);
            this._eventArgs.Trick = MonkeyTrick.acrobatics;
            this._eventArgs.Name = "Walk on hands";
            OnExecuteTrick(this._eventArgs);
        }

        public void TheBareNecessities()
        {
            // OnExecute?.Invoke(MonkeyExecute.music);
            this._eventArgs.Trick = MonkeyTrick.music;
            this._eventArgs.Name = "The bare necessities";
            OnExecuteTrick(this._eventArgs);
        }

        protected void OnExecuteTrick(MonkeyEventArgs e)
        {
            EventHandler<MonkeyEventArgs> handler = ExecuteTrick;
            if (handler != null)
            {
                handler(this, e);
            }
        }
    }
}
