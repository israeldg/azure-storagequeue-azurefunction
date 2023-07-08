using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace functionProcessBlobFiles
{
    public class QueueProcessFiles
    {
        private readonly ILogger _logger;

        public QueueProcessFiles(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<QueueProcessFiles>();
        }

        [Function("QueueProcessFiles")]
        public void Run(
          [QueueTrigger("wgapistoragequeue", Connection = "MyStorageConnection")] string myQueueItem,
          ILogger log)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
            // Use a string array to return more than one message.
            string[] messages = { myQueueItem };


            // Queue Output messages
            // return messages;
        }
    }
}
