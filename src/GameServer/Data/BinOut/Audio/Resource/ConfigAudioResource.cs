using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioResource
{
	public string soundBankPackageName;
	public string externalSourcePackageName;
	public string streamedMusicPackageName;
	public string streamedFilePackageName;
	public byte nSoundBankSplitBits;
	public byte nExternalSourceSplitBits;
	public byte nStreamedMusicSplitBits;
	public byte nStreamedFileSplitBits;
	public string packageFileExtension;
	public Dictionary<string, ConfigAudioIncrementalResources> incrementals;

	public class ConfigAudioIncrementalResources
	{
		public string[] sfxFiles;
		public string[] musicFiles;
		public string[] voFiles;
	}
}