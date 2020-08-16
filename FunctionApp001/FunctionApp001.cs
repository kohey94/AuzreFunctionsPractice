using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
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
            log.LogInformation($"バッチ開始");

            var kvUri = Environment.GetEnvironmentVariable("VaultUri");
            var sc = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            KeyVaultSecret secret = sc.GetSecret("Id23");
            log.LogInformation($"Secret: {secret.Value}");

            log.LogInformation($"バッチ終了");
        }
    }
}
