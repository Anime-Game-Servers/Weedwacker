using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class MapTagDataConfig
{
	public uint id;
	public MapTagType type;
	public uint nameTextMapHash;
	public uint nameWithRubyTextTextMapHash;
	public uint sortID;
	public string icon;
	public bool unlockByDefault;
	public bool hideBeforeUnlock;
	public uint cityID;
	public uint transPointID;
	public uint[] sceneIdList;
	public float defaultLocateX;
	public float defaultLocateZ;
}