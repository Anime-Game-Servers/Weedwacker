
using System.Text.Json.Serialization;

namespace Weedwacker.GameServer.Data.Enums;

public enum ElementType : int
{
	None = 0,
	Fire = 1,
	Water = 2,
	Grass = 3,
	Electric = 4,
	Ice = 5,
	Frozen = 6,
	Wind = 7,
	Rock = 8,
	AntiFire = 9,
	VehicleMuteIce = 10,
	Mushroom = 11,
	Overdose = 12,
	Wood = 13,
	COUNT,
}