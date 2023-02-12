using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins;

public class AIPerceptionMixin : ConfigAbilityMixin
{
	public uint[] featureTagIDs;
	public uint perceptionTemplateID;
}
