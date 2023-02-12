
namespace Weedwacker.GameServer.Data.Enums;

public enum MusicStimulus : ulong
{
	None = 0,
	StageStart = 1,
	StageReady = 2,
	StageFinish = 4,
	QuestBegin = 8,
	QuestEnd = 16,
	CutsceneBegin = 32,
	CutsceneEnd = 64,
	CutsceneCustom = 128,
	DialogBegin = 256,
	DialogEnd = 512,
	CombatBegin = 1024,
	CombatEnd = 2048,
	TeleportBegin = 4096,
	TeleportEnd = 8192,
	AreaChange = 16384,
	Death = 32768,
	WeatherChange = 65536,
	MenuOpen = 131072,
	MenuClose = 262144,
}