using System;
using Azure.Messaging.EventHubs;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace MijnThuisbatterij.InfluxDataFunction
{
    public class HandleDeviceEventFunction
    {
        private readonly ILogger<HandleDeviceEventFunction> _logger;

        public HandleDeviceEventFunction(ILogger<HandleDeviceEventFunction> logger)
        {
            _logger = logger;
        }

        [Function(nameof(HandleDeviceEventFunction))]
        public void Run([EventHubTrigger("ioth-mijn-batterij", Connection = "IotHubConnection")] EventData[] events)
        {
            foreach (EventData @event in events)
            {
                _logger.LogInformation("Event Body: {body}", @event.Body);
                _logger.LogInformation("Event Content-Type: {contentType}", @event.ContentType);
            }
        }
    }
}
