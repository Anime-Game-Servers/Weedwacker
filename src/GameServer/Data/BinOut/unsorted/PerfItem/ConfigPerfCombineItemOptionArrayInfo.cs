using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfCombineItemOptionArrayInfo : ConfigPerfItemOptionArrayInfoBase
{
	public string[] includedOptions;
	public uint[][] itemOptionArray;
}