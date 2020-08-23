using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp003
{
    public static class FunctionApp003
    {
        [FunctionName("FunctionApp003")]
        public static void Run([QueueTrigger("demo-queue", Connection ="QueueSetting")]string myQueueItem, ILogger log)
        {
            log.LogInformation($"C# Queue trigger function processed: {myQueueItem}");
        }
    }
}
