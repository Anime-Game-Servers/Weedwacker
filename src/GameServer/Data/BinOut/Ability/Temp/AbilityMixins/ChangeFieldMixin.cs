using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ChangeFieldMixin : ConfigAbilityMixin
{
	public ChangeFieldType type;
	public float targetRadius;
	public float time;
}
