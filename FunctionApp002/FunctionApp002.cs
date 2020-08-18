using System;
using Azure.Identity;
using Azure.Security.KeyVault.Secrets;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;

namespace FunctionApp002
{
    public static class FunctionApp002
    {
        [FunctionName("FunctionApp002")]
        public static void Run([TimerTrigger("0 */1 * * * *")]TimerInfo myTimer, ILogger log)
        {
            log.LogInformation($"C# Timer trigger function executed at: {DateTime.Now}");
            var kvUri = Environment.GetEnvironmentVariable("VaultUri");
            var sc = new SecretClient(new Uri(kvUri), new DefaultAzureCredential());
            KeyVaultSecret secret = sc.GetSecret("TestKey");
            log.LogInformation($"Secret: {secret.Value}");
        }
    }
}
