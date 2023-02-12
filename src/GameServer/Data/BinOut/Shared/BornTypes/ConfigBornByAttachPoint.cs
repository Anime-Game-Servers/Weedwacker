using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.BornTypes;

public class ConfigBornByAttachPoint : ConfigBornType
{
	public string attachPointName;
	public AttachPointTargetType attachPointTargetType;
}
