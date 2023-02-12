using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigSceneHomeInfo
{
	public uint sceneId;
	public ConfigHomeBlock[] blockArrangementInfoList;
	public bool isSetBornPos;
	public Vector bornPos;
	public Vector bornRot;
	public ConfigHomeFurniture[] doorList;
	public ConfigHomeFurniture[] stairList;
	public ConfigHomeFurniture mainHouse;
	public Vector djinnPos;
	public uint tmpVersion;
}