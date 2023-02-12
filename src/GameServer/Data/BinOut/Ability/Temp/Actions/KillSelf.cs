using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class KillSelf : ConfigAbilityAction
{
	public float duration;
	public DieStateFlag dieStateFlage;
	public bool banDrop;
	public bool banExp;
	public bool banHPPercentageDrop;
	public KillSelfType killSelfType;
	public bool hideEntity;
}
