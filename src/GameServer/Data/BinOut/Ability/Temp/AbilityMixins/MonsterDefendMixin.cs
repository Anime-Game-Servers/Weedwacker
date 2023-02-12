using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class MonsterDefendMixin : ConfigAbilityMixin
{
	public AttackType attackType;
	public ConfigAbilityAction[] onDefendSucceded;
	public MonsterDefendAudio defendAudioConfig;
	public bool randomDirection;
	public bool doNotTurnDirection;

	public class MonsterDefendAudio
	{
		public ConfigWwiseString onDefendSucceded;
	}
}
