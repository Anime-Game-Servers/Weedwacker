using Weedwacker.GameServer.Data.BinOut.Shared;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TryFindMotionChangePosByBorn : ConfigAbilityAction
{
	public ConfigBornType born;
	public string key;
	public bool setTarget;
	public bool hitSceneTest;
	public object limitY;
	public bool ignoreWater;
}