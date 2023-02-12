using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigElementUI
{
	public EntityType[] showIconEntityTypes;
	public EntityType[] showReactionEntityTypes;
	public float iconRecoverTime;
	public float iconDisappearTime;
	public uint iconDisappearRound;
	public float iconShowDistance;
	public Dictionary<string, string> overrideElemPath;
	public Dictionary<ElementReactionType, string> reactionElemPath;
}