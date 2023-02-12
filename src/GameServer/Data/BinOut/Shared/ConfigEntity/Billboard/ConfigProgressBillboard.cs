using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigProgressBillboard : ConfigBillboard
{
	public string[] customKeyList;
	public float maxValue;
	public string prefabPluginName;
	public ProgressBillboardType type;
	public bool needUpAnim;
}