using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigQTEStepCutsceneFailedBlackScreenAction : ConfigQTEStepBaseAction
{
	public int restartSavePointId;
	public uint failedSubQuestId;
	public string textmapId;
	public bool showImmediately;
}