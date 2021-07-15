using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace QueuePublisher.Models
{
    public class PublishSettings
    {
        public PublishType Type { get; set; }
        public object Payload { get; set; }
        public ConnectionFactory Factory { get; set; }
        public string HostName { get; set; }
        public string Password { get; set; }
    }
}
