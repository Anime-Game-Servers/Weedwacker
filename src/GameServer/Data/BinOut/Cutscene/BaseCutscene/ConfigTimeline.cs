using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigTimeline : ConfigBaseCutscene
{
	public bool syncLoad;
	public float fadeInDuration;
	public float fadeOutDuration;
	public bool forceGC;
}