using QueuePublisher.Interfaces;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            IQueuePublisher client = new QueuePublisher.Implementation.QueuePublisher();

            string payload = @"{""enrollmentId"" : ""16ba9d6d-dffc-4971-81e4-5aac77861b73"", ""prescriptionId"": ""93934703-d1f1-4beb-be60-e23aa1533982""}";
            client.Broadcast("Queue.TestQueue", payload);
        }
    }
}
