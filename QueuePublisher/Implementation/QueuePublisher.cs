using QueuePublisher.Interfaces;
using QueuePublisher.Models;
using RabbitMQ.Client;
using System;

namespace QueuePublisher.Implementation
{
    public class QueuePublisher : IQueuePublisher
    {
        public void Broadcast(string queueName, string payload)
        {
            var cf = GetConnectionFactory();

            PublishSettings settings = new PublishSettings() {
                Factory = cf,
                Payload = payload,
                Type = PublishType.exchange
            };
            Console.WriteLine(string.Format("Broadcasting to {0} with payload: {1}", queueName, payload));
            Broadcast(settings);            
        }

        public void Broadcast(string queueName, string payload, string hostName, string password)
        {
             var cf = GetConnectionFactory();

            PublishSettings settings = new PublishSettings()
            {
                Factory = cf,
                Payload = payload,
                Type = PublishType.exchange,
                HostName = hostName,
                Password = password
            };

            Console.WriteLine(string.Format("Broadcasting to {0} with payload: {1} using hostname {2}", queueName, payload, password));
            Broadcast(settings);
        }

        public void Broadcast(PublishSettings settings)
        {
            Console.WriteLine("Create Channel...");
            Console.WriteLine("Getting Broadcast...");
            Console.WriteLine("Sending Message...");
        }

        public void Publish(string queueName, string payload)
        {
            var cf = GetConnectionFactory();

            PublishSettings settings = new PublishSettings()
            {
                Factory = cf,
                Payload = payload,
                Type = PublishType.fanout
            };

            Console.WriteLine(string.Format("Publishing to {0} with payload: {1}", queueName, payload));
            Publish(settings);
        }

        public void Publish(string queueName, string payload, string hostName, string password)
        {
            var cf = GetConnectionFactory();

            PublishSettings settings = new PublishSettings()
            {
                Factory = cf,
                Payload = payload,
                Type = PublishType.fanout,
                HostName = hostName,
                Password = password
            };

            Console.WriteLine(string.Format("Broadcasting to {0} with payload: {1} using hostname {2}", queueName, payload, hostName));
            Publish(settings);
        }

        public void Publish(PublishSettings settings)
        {
            Console.WriteLine("Create Channel...");
            Console.WriteLine("Getting Publisher...");
            Console.WriteLine("Sending Message...");
        }

        #region Private Methods

        private ConnectionFactory GetConnectionFactory()
        {
            return new ConnectionFactory()
            {
                //UserName = _config["BusSettings:username"]
                //Password = _config["BusSettings:password"]
                //Vhost = _config["BusSettings:vhost"]
            };
        }

        #endregion
    }
}
