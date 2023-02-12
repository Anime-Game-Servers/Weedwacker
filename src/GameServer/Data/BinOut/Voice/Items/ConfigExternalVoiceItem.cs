
namespace Weedwacker.GameServer.Data;

public class ConfigExternalVoiceItem
{
	public string _guid;
	public float playRate;
	public float initialDelay;
	public int cooldown;
	public ConfigExternalVoiceInferiorItem[] interruptedGuids;
	public ConfigExternalVoiceInferiorItem[] excludedGuids;
	public int queueUpConfig;
	public string gameTrigger;
	public uint gameTriggerArgs;
	public int personalConfig;
	public int viewConfig;
	public bool clearAll;
	public bool isGlobalStop;
	public bool isPlayOnTeam;
	public int avoidRepeat;
	public string parentID;
	public ConfigExternalVoiceSound[] sourceNames;

	public class ConfigExternalVoiceSound
	{
		public string sourceFileName;
		public float rate;
		public string avatarName;
		public string emotion;
		public int gender;
	}
	public class ConfigExternalVoiceInferiorItem
	{
		public string guid;
		public bool include;
	}
}