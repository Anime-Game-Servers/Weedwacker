using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSoundBankLookup
{
	public float defaultCooldown;
	public Dictionary<string, ConfigSoundBankUnloadPolicy> unloadPolicies;
	public uint[] plainEvents;
	public uint[] bankIds;
	public uint[] conditionals;
	public double bankReuseRate;
	public string[] switchGroupsAffectedByRtpcs;
	public string[] switchGroupsAffectedByEvents;
	public string[] stateGroupsAffectedByEvents;

	public class ConfigSoundBankUnloadPolicy
	{
		public SoundBankUnloadPolicy policy;
		public float parameter;
	}
}