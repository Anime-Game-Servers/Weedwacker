
namespace Weedwacker.GameServer.Data.Enums;

public enum FishingEvent : int
{
	None = 0,
	QteStart = 1,
	QteTrigger = 2,
	RequestQuit = 3,
	CastAnchorPoint = 4,
	SelectBait = 5,
	Pull = 6,
	NotifyBait = 7,
}