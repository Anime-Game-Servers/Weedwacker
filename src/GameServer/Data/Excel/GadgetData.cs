using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;

[Resource("GadgetExcelConfigData.json")]
public class GadgetData
{
	public EntityType type;
	public string jsonName;
	public bool hasMove;
	public bool hasAudio;
	public bool isEquip;
	public bool isInteractive;
	public VisionLevelType visionLevel;
	public string[] tags;
	public byte clientScriptHashPre;
	public uint clientScriptHashSuffix;
	public string itemJsonName;
	public byte itemPrefabPathHashPre;
	public uint itemPrefabPathHashSuffix;
	public uint radarHintID;
	public string inteeIconName;
	public uint landSoundID;
	public uint mpPropID;
	public uint interactNameTextMapHash;
	public uint chainId;
	public bool hasDynamicBarrier;
	public uint id;
	public uint nameTextMapHash;
	public byte prefabPathHashPre;
	public uint prefabPathHashSuffix;
	public byte prefabPathRemoteHashPre;
	public uint prefabPathRemoteHashSuffix;
	public byte controllerPathHashPre;
	public uint controllerPathHashSuffix;
	public byte controllerPathRemoteHashPre;
	public uint controllerPathRemoteHashSuffix;
	public uint campID;
	public string LODPatternName;
}
