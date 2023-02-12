using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class GenerateElemBall : ConfigAbilityAction
{
	public DropElemBallType dropType;
	public uint configID;
	public ConfigBornType born;
	public object ratio;
	public float baseEnergy;
}
