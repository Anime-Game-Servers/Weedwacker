using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;

public class ConfigCombat
{
	public ConfigCombatProperty property;
	public ConfigCombatBeHit beHit;
	public ConfigCombatLock combatLock;
	public ConfigDie die;
	public Dictionary<string, ConfigAttackEvent> animEvents;
	public ConfigSummon summon;
	public ConfigSimulatePhysics simulatePhysics;

	public class ConfigCombatBeHit
	{
		public string hitBloodEffect;
		public bool hitAutoRedirect;
		public bool muteAllHit;
		public bool muteAllHitEffect;
		public bool muteAllHitText;
		public bool ignoreMinHitVY;
		public ConfigBeHitBlendShake blendShake;
	}

	public abstract class ConfigBeHitBlendShake
	{

	}

	public class ConfigBeHitBlendShakeByAinmator: ConfigBeHitBlendShake
	{
		public ShakeByAinmator[] shakeFlagMap;

		public class ShakeByAinmator
		{
			public float shakeFlag;
			public string[] hitBoxNames;
		}
	}
	public class ConfigSimulatePhysics
	{
		public bool enable;
	}
}
