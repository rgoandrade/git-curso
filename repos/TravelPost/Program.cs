
using System;
using TravelPost.Entities;

namespace TravelPost
{
    class Program
    {
        static void Main(string[] args)
        {
            Comment c1 = new Comment("Have a nice trip !");
            Comment c2 = new Comment("Wow tha's awesomexxx !");
            Comment c5 = new Comment("Teste hoje !");
            Comment c7 = new Comment("xxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxxx");

            Post p1 = new Post(
                DateTime.Parse("21/06/2018 13:05:44"),
                "Traveling to New Zealand",
                "I'm going to visit his wondeful country !",
                12
                );

            p1.AddComment(c1);
            p1.AddComment(c2);
            p1.AddComment(c5);
            p1.AddComment(c7);
                        
            Comment c3 = new Comment("Good Night !");
            Comment c4 = new Comment("My the Force be with you !");
            Comment c6 = new Comment("teste de hoje");
            Comment c8 = new Comment("yyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyyy");

            Post p2 = new Post(
                DateTime.Parse("28/07/2018 23:14:19"),
                "Good night guys",
                "See you tomorrow !",
                5
                );

            p2.AddComment(c3);
            p2.AddComment(c4);
            p2.AddComment(c6);
            p2.AddComment(c8);


            Console.WriteLine(p1);
            Console.WriteLine(p2);            
        }
    }
}
