using System;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class QueueProcessFilesM1
    {
        private readonly ILogger _logger;

        public QueueProcessFilesM1(ILoggerFactory loggerFactory)
        {
            _logger = loggerFactory.CreateLogger<QueueProcessFilesM1>();
        }

        [Function("QueueProcessFilesM1")]
        public void Run([QueueTrigger("wgapistoragequeue", Connection = "wgapistoragepoc")] string myQueueItem)
        {
            _logger.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
