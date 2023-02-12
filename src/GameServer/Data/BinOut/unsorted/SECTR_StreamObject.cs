using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class SECTR_StreamObject
{
	public SECTR_StreamObjectType type;
	public ulong gameObjectPathHash;
	public uint objPatternNameHash;
	public float magitude;
	public Vector position;
	public Vector rotation;
	public Vector scale;
}