using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class NewActivityEntryConfig
{
	public uint id;
	public NewActivityType activityType;
	public int sortPriority;
	public string tabIcon;
	public string bannerPath;
	public string bannerEffect;
	public uint tabNameTextMapHash;
	public uint duration;
}