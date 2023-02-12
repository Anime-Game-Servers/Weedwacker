using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigWidgetLightStone : ConfigBaseWidgetToy
{
	public uint[] levelEnergyLimitArray;
	public uint[] levelCdGroupIdArray;
	public uint quickUseOpenLevel;
	public uint skyCrystalDetectorOpenLevel;
	public RegionalPlayVarType energyType;
	public uint gadgetChainId;
	public uint quickUseCostEnergy;
	public string abilityGroupName;
	public string triggerAbilityName;
	public bool isTeam;
	public uint hintRadius;
	public uint nearbyRadius;
	public uint gridSearchRange;
	public uint successGadgetId;
	public uint failedGadgetId;
	public uint gatherPointType;
	public uint hintGroup;
	public uint effectLastTime;
	public float distanceToAvatar;
	public float height;
}