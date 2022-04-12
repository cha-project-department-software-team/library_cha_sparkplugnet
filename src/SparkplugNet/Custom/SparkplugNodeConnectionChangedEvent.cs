namespace SparkplugNet.Custom;

#pragma warning disable CS8618, CS1591
public class SparkplugNodeConnectionChangedEvent
{
    public string EonNodeId { get; set; }
    public bool Connected { get; set; }
}
#pragma warning restore CS8618, CS1591