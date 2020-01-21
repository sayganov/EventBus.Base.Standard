namespace EventBus.Base.Standard.Options
{
    public class EventBusOptions
    {
        public string AutofacScopeName { get; set; }
        public string BrokerName { get; set; }
        public string Connection { get; set; }
        public string Password { get; set; }
        public string QueueName { get; set; }
        public string RetryCount { get; set; }
        public string Username { get; set; }
        public string VirtualHost { get; set; }

        public bool DispatchConsumersAsync { get; set; }
    }
}