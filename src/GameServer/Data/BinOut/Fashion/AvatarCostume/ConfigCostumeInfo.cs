
namespace Weedwacker.GameServer.Data;

public class ConfigCostumeInfo
{
	public Dictionary<string, string> effects;
	public Dictionary<string, string> gadgets;
	public ConfigCostumeAudio audio;
	public Dictionary<string, string> weatherPatterns;
	public Dictionary<string, string> eventPatterns;

	public class ConfigCostumeAudio
	{
		public VoiceTriggerIdentity wearVoice;
	}
}