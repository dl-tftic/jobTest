using System;
using System.Collections.Generic;
using System.Text;

namespace eonix_ex1.Models
{
    public class Trainer
    {
        public EventHandler<MonkeyEventArgs> MonkeyExecuteTrick;
        private Monkey _monkey;

        public Trainer(string monkeyName)
        {
            _monkey = new Monkey();
            _monkey.Name = monkeyName;
            _monkey.ExecuteTrick += OnMonkeyTrick;
        }

        protected void OnMonkeyTrick(object sender, MonkeyEventArgs e)
        {
            OnMonkeyExectureTrick(_monkey, e);
        }

        protected void OnMonkeyExectureTrick(object sender,MonkeyEventArgs e)
        {
            EventHandler<MonkeyEventArgs> handler = MonkeyExecuteTrick;
            if (handler != null)
            {
                handler(sender, e);
            }
        }

        public void ExecuteTrick(int play)
        {
            switch(play)
            {
                case 1: _monkey.TheBareNecessities(); 
                        break;
                case 2: _monkey.WalkOnHands();
                        break;
            }
        }
    }
}
