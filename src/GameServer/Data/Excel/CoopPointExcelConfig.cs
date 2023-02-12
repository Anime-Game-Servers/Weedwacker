using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class CoopPointExcelConfig
{
	public uint id;
	public uint chapterId;
	public CoopPointType type;
	public uint acceptQuest;
	public uint[] postPointList;
	public uint pointNameTextMapHash;
	public uint pointDecTextMapHash;
	public uint pointPosId;
	public byte photoMaleHashPre;
	public uint photoMaleHashSuffix;
	public byte photoFemaleHashPre;
	public uint photoFemaleHashSuffix;
}