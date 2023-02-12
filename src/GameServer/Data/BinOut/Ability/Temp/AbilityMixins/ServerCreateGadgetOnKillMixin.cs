using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class ServerCreateGadgetOnKillMixin : ConfigAbilityMixin
{
	public uint[] gadgetIDList;
	public uint campID;
	public TargetType campTargetType;
	public bool randomCreate;
	public bool useOriginOwnerAsGadgetOwner;
	public bool lifeByOwnerIsAlive;
}
