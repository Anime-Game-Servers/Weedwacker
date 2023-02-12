using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigBaseWidget
{
	public uint materialId;
	public bool isConsumeMaterial;
	public bool isEquipable;
	public uint coolDown;
	public uint coolDownOnFail;
	public uint coolDownGroup;
	public bool isCdUnderTimeScale;
	public bool isAllowedInDungeon;
	public bool isAllowedInRoom;
	public OrnamentsType ornamentsType;
}