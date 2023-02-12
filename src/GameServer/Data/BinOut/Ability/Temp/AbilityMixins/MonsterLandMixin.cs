using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class MonsterLandMixin : ConfigAbilityMixin
{
	public ConfigAbilityAction[] onMotionChange;
	public string dropToPos;
	public int dropSpeedBezierType;
	public bool hasDropPos;
	public float dropTime;
	public float dropSpeed;
}
