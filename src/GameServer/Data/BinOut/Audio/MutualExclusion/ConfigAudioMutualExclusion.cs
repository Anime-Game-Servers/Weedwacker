using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigAudioMutualExclusion
{
	public AudioMutualExclusion[] exclusionPairs;

	public class AudioMutualExclusion
	{
		public string eventNameA;
		public string eventNameB;
		public AudioScope scope;
	}
}