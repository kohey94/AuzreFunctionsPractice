using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;

namespace FunctionApp001
{
    public static class FunctionApp001
    {
        [FunctionName("FunctionApp001")]
        public static void Run([TimerTrigger("%TimerScheduler%")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
        }
    }
}
