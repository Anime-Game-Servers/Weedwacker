using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class SECTR_StreamLayer
{
	public uint sectorNameHash;
	public uint layerNameHash;
	public SECTR_LayerType type;
	public uint layerFullNameHash;
	public Vector position;
	public Vector sectorSize;
	public SECTR_CombineStreamPathInfo layerPathInfo;
	public SECTR_AttachStreamLayer[] attachLayers;
}