using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ContextActionSelectMonsterMark : ContextAction
{
	public uint monsterId;
	public bool needTrack;
}