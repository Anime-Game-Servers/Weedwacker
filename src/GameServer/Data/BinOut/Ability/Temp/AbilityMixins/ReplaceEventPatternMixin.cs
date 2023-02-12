using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ReplaceEventPatternMixin : ConfigAbilityMixin
{
	public string[] oldPatterns;
	public string[] newPatterns;
}
