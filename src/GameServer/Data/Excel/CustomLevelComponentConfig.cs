using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CustomLevelComponentConfig
{
	public uint componentID;
	public uint typeID;
	public uint componentNameTextMapHash;
	public uint tagDescTextMapHash;
	public byte componentIconHashPre;
	public uint componentIconHashSuffix;
	public string brickName;
	public uint deployGadgetID;
	public uint serverGadgetID;
	public uint configLevel;
	public BrickRotateType rotateType;
	public uint componentCost;
	public uint maxDeployCount;
	public uint handBookID;
	public bool isVisable;
	public BrickType brickType;
	public bool canCopy;
	public uint componentDescTextMapHash;
	public uint componentSizeTextMapHash;
	public uint componentDeployTextMapHash;
}