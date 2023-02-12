using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TryFindBlinkPointByBorn : ConfigAbilityAction
{
	public ConfigBornType born;
	public bool hitSceneTest;
	public BlinkHitSceneTestType hitSceneType;
	public object limitY;
	public bool ignoreWater;
}
