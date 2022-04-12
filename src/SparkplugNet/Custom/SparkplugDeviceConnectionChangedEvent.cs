namespace SparkplugNet.Custom;

#pragma warning disable CS8618, CS1591
public class SparkplugDeviceConnectionChangedEvent
{
    public string EonNodeId { get; set; }
    public string DeviceId { get; set; }
    public bool Connected { get; set; }
}
#pragma warning restore CS8618, CS1591