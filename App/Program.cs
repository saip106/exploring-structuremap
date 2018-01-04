using System;
using PresentationLayer;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            var peopleViewModel = new PeopleViewModel();
            var people = peopleViewModel.GetAll();

            Console.WriteLine("Some famous tennis players");
            Console.WriteLine("----------------------");

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine("----------------------");
        }
    }
}
