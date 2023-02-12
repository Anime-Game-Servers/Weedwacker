
namespace Weedwacker.GameServer.Data.Enums;

public enum ModifierStacking : int
{
	Refresh = 0,
	Unique = 1,
	Prolong = 2,
	RefreshAndAddDurability = 3,
	Multiple = 4,
	MultipleRefresh = 5,
	MultipleRefreshNoRemove = 6,
	MultipleAllRefresh = 7,
	GlobalUnique = 8,
	Overlap = 9,
	RefreshUniqueDurability = 10,
	OverlapRefreshDuration,
}