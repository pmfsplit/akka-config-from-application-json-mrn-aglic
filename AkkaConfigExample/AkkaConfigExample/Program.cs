using System;
using Akka.Actor;
using Akka.Routing;

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
                var props = Props.Create(() => new MyActor())
                    .WithRouter(FromConfig.Instance);
                var router = system.ActorOf(props, "my-router");
                
                router.Tell(new Print());
                router.Tell(new Print());
                router.Tell(new Print());
                router.Tell(new Print());
                router.Tell(new Print());
            }
        }
    }
}