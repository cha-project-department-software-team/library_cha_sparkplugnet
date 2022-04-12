namespace SparkplugNet.Custom;

#pragma warning disable CS8618, CS1591
public class SparkplugMetricsChangedEvent
{

    public string EonNodeId { get; set; }
    public string DeviceId { get; set; }
    public string TagName { get; set; }
    public object Value { get; set; }
}
#pragma warning restore CS8618, CS1591