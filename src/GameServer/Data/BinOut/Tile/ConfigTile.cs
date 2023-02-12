using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigTile
{
	public string tileName;
	public uint campID;
	public TileSpecialType specialType;
	public float fixedY;
	public int poolSize;
	public ConfigTileElement[] initialElements;
	public ConfigMassiveElementTriggerAction basicAction;
	public string fieldMapMaterial;
	public string effectMaterial;

	public class ConfigTileElement
	{
		public ElementType elementType;
		public float elementDurability;
		public bool isElementDurabilityMutable;
	}
}