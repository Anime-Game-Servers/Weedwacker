using Weedwacker.GameServer.Data.BinOut.Shared.ConfigEntity;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelEntity : ConfigEntity
{
	public DropElemControlType dropElemControlType;
	public ConfigEntityAbilityEntry[] abilities;
	public ConfigEntityAbilityEntry[] avatarAbilities;
	public ConfigEntityAbilityEntry[] teamAbilities;
	public ConfigEntityAbilityEntry[] monsterAbilities;
	public Dictionary<string, Dictionary<string, float>> elemAmplifyDamage;
	public uint[] preloadMonsterEntityIDs;
}