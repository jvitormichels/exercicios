using System;
using aLotOfText.Entities;

namespace aLotOfText
{
    class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Travelling to New Zealand",
                "I'm going to visit this wonderful country!",
                12);
            Comment c1 = new Comment("Have a nice trip!");
            Comment c2 = new Comment("Wow that's awesome!");
            p1.AddComment(c1);
            p1.AddComment(c2);

            Post p2 = new Post(
                DateTime.Parse("26/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow",
                5);
            c1 = new Comment("Good night");
            c2 = new Comment("May the force be with you!");
            p2.AddComment(c1);
            p2.AddComment(c2);

            Console.WriteLine(p1);
            Console.WriteLine("\n");
            Console.WriteLine(p2);
        }
    }
}
