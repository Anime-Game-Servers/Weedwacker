using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigPerfItemOverrideInfoBase
{
	public ConfigGraphicsRequirement[] requirementArray;
	public PerfOptionOverrideRule deviceOverrideRule;
	public PerfOptionOverrideRule combineOverrideRule;
}