using System;
using eonix_ex1.Models;

namespace eonix_ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Spectator Henry = new Spectator();

            Trainer Pascal = new Trainer("baloo");
            Trainer Roger = new Trainer("rantanplan");

            Pascal.MonkeyExecuteTrick += Henry.WatchMonkey;
            Roger.MonkeyExecuteTrick += Henry.WatchMonkey;

            Pascal.ExecuteTrick(1);
            Pascal.ExecuteTrick(2);

            Roger.ExecuteTrick(2);

        }
    }
}
