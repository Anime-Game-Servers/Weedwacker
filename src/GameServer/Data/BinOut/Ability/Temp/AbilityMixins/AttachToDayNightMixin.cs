using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AttachToDayNightMixin : ConfigAbilityMixin
{
	public LevelDayTimeType time;
	public string modifierName;
}