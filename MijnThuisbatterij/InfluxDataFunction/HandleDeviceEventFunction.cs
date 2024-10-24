using System.Text;

using Google.Protobuf.WellKnownTypes;

using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

using Newtonsoft.Json;

using EventData = Azure.Messaging.EventHubs.EventData;


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
                var val = Encoding.UTF8.GetString(@event.Body.ToArray()) ?? "";
                dynamic body = JsonConvert.DeserializeObject<dynamic>(val) ?? throw new ArgumentNullException(nameof(val));
                if (body.data != null)
                {
                    dynamic data = body.data;
                    foreach (dynamic value in data)
                    {
                        _logger.LogInformation($"Data Message, Device id: {@event.SystemProperties["iothub-connection-device-id"]} Environment: {@event.Properties["env"]} EnqueuedTime: {@event.EnqueuedTime} TimeStamp: {DateTimeOffset.FromUnixTimeSeconds((long)value["ts-e"])} Value: {value.ToString()}");
                    }
                }
                else if (body.vitals != null)
                {
                    dynamic vitals = body.vitals;
                    _logger.LogInformation($"Vitals Message, Device id: {@event.SystemProperties["iothub-connection-device-id"]} Environment: {@event.Properties["env"]} EnqueuedTime: {@event.EnqueuedTime} Value: {vitals.ToString()}");
                }
                else
                {
                    _logger.LogError("Unknown message type in {0}", @event.ToString());
                    throw new InvalidOperationException($"Unknown message type.");
                }
            }
        }
    }
}
