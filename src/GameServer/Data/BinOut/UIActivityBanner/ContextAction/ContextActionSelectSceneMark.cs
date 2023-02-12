using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextActionSelectSceneMark : ContextAction
{
	public MarkIconType iconType;
	public uint cityId;
	public uint[] sceneIds;
}