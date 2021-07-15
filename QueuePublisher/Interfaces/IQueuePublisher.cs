namespace QueuePublisher.Interfaces
{
    public interface IQueuePublisher
    {
        public void Broadcast(string queueName, string payload);        
        public void Publish(string queueName, string payload);

        public void Broadcast(string queueName, string payload, string hostName, string password);
        public void Publish(string queueName, string payload, string hostName, string password);
    }
}
