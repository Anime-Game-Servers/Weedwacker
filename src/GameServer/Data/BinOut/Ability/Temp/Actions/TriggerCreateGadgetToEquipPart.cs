using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerCreateGadgetToEquipPart : ConfigAbilityAction
{
	public uint gadgetID;
	public string equipPart;
}
