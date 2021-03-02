using System;
using System.Collections.Generic;
using System.Text;

namespace eonix_ex1.Models
{

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

        private string _trickName;
        public string TrickName { 
                             get => _trickName;
                             set { _trickName = value; }
                            }

    }

    public class Monkey
    {
        public event EventHandler<MonkeyEventArgs> ExecuteTrick;

        public string Name { get; set; }

        public Monkey()
        {
            
        }

        public void WalkOnHands()
        {
            OnExecuteTrick(this.GetMonkeyEvent(MonkeyTrick.acrobatics, "Walk on hands"));
        }

        public void TheBareNecessities()
        {
            OnExecuteTrick(this.GetMonkeyEvent( MonkeyTrick.music, "The bare necessities"));
        }

        protected void OnExecuteTrick(MonkeyEventArgs e)
        {
            EventHandler<MonkeyEventArgs> handler = ExecuteTrick;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        private MonkeyEventArgs GetMonkeyEvent(MonkeyTrick trick, string trickName)
        {
            return new MonkeyEventArgs() { Trick = trick, TrickName = trickName };
        }
    }
}
