using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class RejectAttackMixin : ConfigAbilityMixin
{
	public string attackTag;
	public float limitTime;
	public RejectEventType type;
}
