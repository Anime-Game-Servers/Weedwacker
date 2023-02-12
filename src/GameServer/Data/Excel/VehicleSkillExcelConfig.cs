using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class VehicleSkillExcelConfig
{
	public uint ID;
	public uint skillNameTextMapHash;
	public uint skillDescTextMapHash;
	public string abilityName;
	public string skillIcon;
	public float skillCD;
	public int maxChargeCount;
	public int triggerID;
	public string lockShape;
	public float[] lockWeightParams;
	public string globalValueKey;
	public int energyOnceCost;
	public int energyMaxCost;
}