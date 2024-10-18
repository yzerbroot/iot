### Testing events from devices

Create a device
```bash
az iot hub device-identity create --device-id MySimulatedDevice --hub-name ioth-mijn-batterij
```

Send message from device
```bash
az iot device send-d2c-message --device-id MySimulatedDevice --hub-name ioth-mijn-batterij --data "Hello, IoT Hub!"
```