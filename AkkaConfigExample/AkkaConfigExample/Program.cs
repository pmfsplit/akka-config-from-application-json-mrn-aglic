using System;
using Akka.Actor;

namespace AkkaConfigExample
{
    class Print {}

    class MyActor : ReceiveActor
    {
        public MyActor()
        {
            Receive<Print>(x => Console.WriteLine(Self.Path));
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            using (var system = ActorSystem.Create("config-example"))
            {
            }
        }
    }
}