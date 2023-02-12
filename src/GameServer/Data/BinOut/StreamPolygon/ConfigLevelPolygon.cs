using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigLevelPolygon
{
	public uint localPolygonId;
	public float yMax;
	public float yMin;
	public Vector[] vertices;
	public ConfigLevelPolygonTag[] tags;
}