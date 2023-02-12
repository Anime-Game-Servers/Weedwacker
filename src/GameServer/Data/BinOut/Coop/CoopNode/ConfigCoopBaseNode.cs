using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigCoopBaseNode
{
	public uint coopNodeId;
	public CoopNodeType coopNodeType;
	public uint[] nextNodeArray;
}