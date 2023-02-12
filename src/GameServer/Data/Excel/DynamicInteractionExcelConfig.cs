using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class DynamicInteractionExcelConfig
{
	public uint id;
	public uint selfContentTextMapHash;
	public uint selfContent1TextMapHash;
	public string selfInteeIconName;
	public uint otherContentTextMapHash;
	public string otherInteeIconName;
	public bool otherCanIntee;
}