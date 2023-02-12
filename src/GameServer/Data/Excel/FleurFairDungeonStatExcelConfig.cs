using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class FleurFairDungeonStatExcelConfig
{
	public uint id;
	public uint galleryId;
	public FleurFairDungeonStatType statType;
	public string[] statParamList;
	public OrderingType orderingType;
	public FleurFairDungeonStatMethod statMethod;
	public uint priority;
	public uint titleTextMapHash;
	public uint descTextMapHash;
}