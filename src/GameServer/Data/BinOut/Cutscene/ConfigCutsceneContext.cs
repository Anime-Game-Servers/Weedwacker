using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCutsceneContext
{
	public CutsceneIndexType type;
	public bool enableForceStreaming;
	public ConfigTimeline cutsceneConfig;
	public ConfigVideo videoConfig;

	public class ConfigVideo
	{
		public bool heroDiff;
		public string videoName;
		public string videoNameOther;
		public uint subtitleId;
		public uint subtitleIdOther;
		public bool canSkip;
		public ColorVector bgColor;
		public float fadeInDuration;
		public float fadeOutDuration;
		public uint videoScreenAdaptation;
	}
}