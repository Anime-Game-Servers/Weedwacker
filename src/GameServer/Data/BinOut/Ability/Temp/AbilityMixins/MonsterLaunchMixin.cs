using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class MonsterLaunchMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onMotionChange;
	public string runUpToPos;
	public string launchToPos;
	public int launchSpeedBezierType;
	public bool hasLaunchPos;
	public float launchTime;
	public float launchSpeed;
}