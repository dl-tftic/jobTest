using System;
using System.Collections.Generic;
using System.Text;

namespace eonix_ex1.Models
{
    public class Spectator
    {


        public void WatchMonkey(object sender, MonkeyEventArgs e)
        {
            string action;
            if (e.Trick == MonkeyTrick.acrobatics) { action = "applause"; }
            else action = "whistle";

            Console.WriteLine("{0} for {1} on {2}.", action, (sender as Monkey).Name, e.TrickName);
        }
    }
}
