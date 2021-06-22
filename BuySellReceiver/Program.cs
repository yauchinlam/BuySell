using Microsoft.Azure.ServiceBus;
using System;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace BuySellReceiver
{
    class Program
    {
        const string connectionString = "ConnectionStrings:AzureServiceBus";
        const string queueName = "ConnectionStrings:queue";
        static IQueueClient queueClient;
        static async Task Main(string[] args)
        {
            //find a way to put your secrets name here
            queueClient = new QueueClient(connectionString, queueName);
            MessageHandlerOptions messageHandlerOptions = new MessageHandlerOptions(ExceptionReceivedHandler)
            {
                MaxConcurrentCalls = 1,
                AutoComplete = false
            };

            queueClient.RegisterMessageHandler(ProcessMessagesAsync, messageHandlerOptions);
            await queueClient.CloseAsync();
        }

        private static async Task ProcessMessagesAsync(Message message, CancellationToken arg2)
        {
            string jsonString = Encoding.UTF8.GetString(message.Body);
            String result = JsonSerializer.Deserialize<String>(jsonString);
            Console.WriteLine($"Its time to:{result}");
            await queueClient.CompleteAsync(message.SystemProperties.LockToken);
        }

        private static Task ExceptionReceivedHandler(ExceptionReceivedEventArgs arg)
        {
            //you will do on frontend if needed
            //Console.WriteLine($"Message Handler Exception: {arg.Exception}");
            return Task.CompletedTask;
        }
    }

        
    
}
