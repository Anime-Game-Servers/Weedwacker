using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class RejectAttackMixinV2 : ConfigAbilityMixin
{
	public string[] attackTags;
	public float limitTime;
	public RejectEventType type;
	public bool isWhiteList;
}
