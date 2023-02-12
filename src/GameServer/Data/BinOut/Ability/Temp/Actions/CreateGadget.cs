using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class CreateGadget : CreateEntity
{
	public uint gadgetID;
	public uint campID;
	public TargetType campTargetType;
	public bool byServer;
}