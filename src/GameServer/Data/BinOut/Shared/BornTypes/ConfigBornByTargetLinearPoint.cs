using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes;

public class ConfigBornByTargetLinearPoint : ConfigBornType
{
	public object linearOffset;
	public bool baseOnTarget;
	public bool linearXZ;
	public object linearMin;
	public object linearMax;
}
