using System;
using PostProgram.entities;

namespace PostProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip");
            Comment c2 = new Comment("Wow! Thats awesome!");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:55"),
                "Traveling to new zeland",
                "Beutiful Country",
                12);
            p1.AddComment(c1);
            p1.AddComment(c2);

            Console.WriteLine(p1);
        }
    }
}
