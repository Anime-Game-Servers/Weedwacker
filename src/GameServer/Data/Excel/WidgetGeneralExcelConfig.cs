using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class WidgetGeneralExcelConfig
{
	public uint materialID;
	public bool canUseInOtherWorld;
	public bool canUseInRoom;
	public uint[] forbiddenSceneIdList;
	public bool canUseWhenCurrentAvatarDead;
	public bool canUseInLimitRegion;
	public bool canUseWhenFight;
	public bool canUseInUnNormalMoveState;
	public bool canUseInAvatarFocus;
	public bool canUseInDungeon;
	public bool canUseInTower;
	public bool canUseInHomeworld;
	public VEHICLE_LIMIT_TYPE vehicleLimit;
	public uint[] forbiddenDungeonTypeList;
	public uint[] forbiddenDungeonPlayTypeList;
}