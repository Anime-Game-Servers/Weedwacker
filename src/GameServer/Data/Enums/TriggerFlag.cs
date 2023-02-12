
namespace Weedwacker.GameServer.Data.Enums;

public enum TriggerFlag : int
{
	None = 0,
	NoReviveRegion = 1,
	DeadRegion = 2,
	ReturnRegion = 3,
	CameraSceneLook = 4,
	LevelAbility = 5,
	AudioEvent = 6,
	GlobalValue = 7,
	Teleport = 8,
	TeleportWithoutPaimonReminder = 9,
	TeleportV2 = 10,
}