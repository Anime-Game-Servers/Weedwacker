using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity
{
	public class ConfigCombatProperty
	{
		public EndureType endureType;
		public bool useCreatorProperty;
		public /*CombatPropertyIndex[]*/ bool useCreatorPropertyPartly; //idfk anymore
		public bool useCreatorBuffedProperty;
		public bool useAbilityProperty;
		public float HP;
		public float attack;
		public float defense;
		public int level;
		public LevelOption levelOption;
		public float weight;
		public float endureShake;
		public bool isInvincible;
		public bool isLockHP;
		public bool isLockHPNoHeal;
		public bool isNoHeal;
		public bool isGhostToAllied;
		public bool isGhostToEnemy;
		public bool canTriggerBullet;
		public bool denyElementStick;
		public bool ignorePurgeRate;
		public bool ignoreDamageToSelf;
	}
}
