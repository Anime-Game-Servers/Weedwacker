using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data;

public class ConfigTriggerMassiveElementTask : ConfigAbilityTask
{
	public ConfigMassiveEntityElement[] entityElements;
	public ConfigMassiveElementTriggerAction[] elementTriggerActions;

	public class ConfigMassiveEntityElement
	{
		public EntityType entityType;
		public ElementType elementType;
		public float elementDurability;
		public bool isElementDurabilityMutable;
	}

}