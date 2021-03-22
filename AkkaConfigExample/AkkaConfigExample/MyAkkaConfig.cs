namespace AkkaConfigExample
{
    public class MyAkkaConfig
    {
        public ActorConfig Actor { get; set; }
        public class ActorConfig
        {
            public DeploymentConfig Deployment { get; set; }
            public class DeploymentConfig
            {
                public RouterConfig MyRouter { get; set; }
                public class RouterConfig
                {
                    public string Router { get; set; }
                    public int NrOfInstances { get; set; }
                }
            }
        }
    }
}