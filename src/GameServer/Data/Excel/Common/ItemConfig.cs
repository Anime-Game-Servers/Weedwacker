using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.Excel;


public abstract class ItemConfig
{
	public uint id;
	public uint nameTextMapHash;
	public uint descTextMapHash;
	public string icon;
	public ItemType itemType;
	public uint weight;
	public uint rank;
	public uint gadgetId;
	public bool dropable;
	public uint useLevel;
	public uint globalItemLimit;
}
