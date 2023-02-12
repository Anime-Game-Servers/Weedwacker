using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class Summon : ConfigAbilityAction
{
	public uint monsterID;
	public ConfigBornType born;
	public uint bornSlotIndex;
	public AbilityTargetting faceToTarget;
	public uint summonTag;
	public bool aliveByOwner;
	public bool isElite;
	public uint[] affixList;
	public object levelDelta;
	public bool hasDrop;
	public bool hasExp;
	public bool sightGroupWithOwner;
}
