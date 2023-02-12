using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class CreateMovingPlatform : CreateGadget
{
	public uint routeID;
	public float detectHeight;
	public float detectWidth;
	public bool enableRotationOffset;
	public ConfigAbilityAction[] failActions;
}
