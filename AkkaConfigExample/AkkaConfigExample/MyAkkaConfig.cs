using Newtonsoft.Json;

namespace AkkaConfigExample
{
    public class MyAkkaConfig
    {
        [JsonProperty(PropertyName = "actor")]
        public ActorConfig Actor { get; set; }
        public class ActorConfig
        {
            [JsonProperty(PropertyName = "deployment")]
            public DeploymentConfig Deployment { get; set; }
            public class DeploymentConfig
            {
                [JsonProperty(PropertyName = "/my-router")]
                public RouterConfig MyRouter { get; set; }
                public class RouterConfig
                {
                    [JsonProperty(PropertyName = "router")]
                    public string Router { get; set; }
                    [JsonProperty(PropertyName = "nr-of-instances")]
                    public int NrOfInstances { get; set; }
                }
            }
        }
    }
}