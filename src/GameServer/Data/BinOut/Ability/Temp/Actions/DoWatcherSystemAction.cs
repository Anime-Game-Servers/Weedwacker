using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class DoWatcherSystemAction : ConfigAbilityAction
{
	public uint watcherId;
	public bool authorityOnly;
	public bool inThreatListOnly;
}
