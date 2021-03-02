using System;
using ex2_DAL.Repository;
using ex2_DAL.Models;
using System.Collections.Generic;

namespace ex2_TestRepo
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            p.FirstName = "David";
            p.LastName = "Lissens";

            PersonRepository pr = new PersonRepository();
            Console.WriteLine(pr.Add(p));

            IEnumerable<Person> people = pr.GetByFirstName("Dav");

            foreach (var item in people)
            {
                Console.WriteLine("Before : {0} {1} {2}", item.Id, item.FirstName, item.LastName);
                item.FirstName = "Leonard";
                Console.WriteLine(pr.Update(item));
                Console.WriteLine(pr.Delete(item)); 
                Console.WriteLine("After : {0} {1} {2}", item.Id, item.FirstName, item.LastName);
            }
        }
    }
}
