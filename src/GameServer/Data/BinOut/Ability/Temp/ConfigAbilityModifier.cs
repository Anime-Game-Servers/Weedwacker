using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class ConfigAbilityModifier
{
	public ModifierTimeScale timeScale;
	public ModifierStacking stacking;
	public ConfigModifierStackingOption stackingOption;
	public bool isBuff;
	public bool isDebuff;
	public string modifierName;
	public bool isUnique;
	public object duration;
	public ElementType elementType;
	public object elementDurability;
	public float maxElementDurability;
	public float purgeIncrement;
	public bool isElementDurabilityMutable;
	public bool forceTriggerBurning;
	public bool overrideWeaponElement;
	public object thinkInterval;
	public ConfigAbilityMixin[] modifierMixins;
	public bool trimThinkInterval;
	public Dictionary<string, object> properties;
	public AbilityState state;
	public ConfigAbilityStateOption stateOption;
	public bool muteStateDisplayEffect;
	public bool applyAttackerWitchTimeRatio;
	public ConfigAbilityAction[] onAdded;
	public ConfigAbilityAction[] onRemoved;
	public ConfigAbilityAction[] onBeingHit;
	public ConfigAbilityAction[] onAttackLanded;
	public ConfigAbilityAction[] onHittingOther;
	public ConfigAbilityAction[] onHeal;
	public ConfigAbilityAction[] onBeingHealed;
	public ConfigAbilityAction[] onThinkInterval;
	public bool onThinkIntervalIsFixedUpdate;
	public ConfigAbilityAction[] onKill;
	public ConfigAbilityAction[] onCrash;
	public ConfigAbilityAction[] onAvatarIn;
	public ConfigAbilityAction[] onAvatarOut;
	public ConfigAbilityAction[] onVehicleIn;
	public ConfigAbilityAction[] onVehicleOut;
	public ConfigAbilityAction[] onZoneEnter;
	public ConfigAbilityAction[] onZoneExit;
	public ConfigAbilityAction[] onReconnect;
	public ConfigAbilityAction[] onChangeAuthority;
	public EntityType[] forbiddenEntities;
	public bool fireEventWhenApply;
	public bool isDurabilityGlobal;
	public bool tickThinkIntervalAfterDie;
	public bool thinkIntervalIgnoreTimeScale;
	public bool reduceDurablityIgnoreTimeScale;
	public bool isLimitedProperties;
	public bool forceSyncToRemote;
	public int buffID;
	public bool retainWhenDurabilityIsZero;
	public ModifierTag[] modifierTags;
	public bool useDummyAbility;
	public ConfigDummyAbilityOption dummyAbilityOption;

	public class ConfigModifierStackingOption
	{
		public string abilitySpecialName;
		public UniqueModifierCond uniqueModifierCondition;
		public object maxModifierNumForMultipleType;
		public bool enableMixedUnique;
	}
	public class ConfigDummyAbilityOption
	{
		public bool disableApplyModifierError;
	}
	public class ConfigAbilityStateOption
	{
		//HMMMMMM
	}
	public async Task Initialize(LocalIdGenerator idGenerator, IDictionary<uint, IInvocation> localIdToInvocationMap)
	{
		ushort configIndex = 0;
		// DO NOT CHANGE THE ORDER
		var tasks = new Task[]
			{
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAdded, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onRemoved, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onBeingHit, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAttackLanded, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onHittingOther, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onThinkInterval, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onKill, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onCrash, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAvatarIn, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onAvatarOut, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onReconnect, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onChangeAuthority, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onVehicleIn, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onVehicleOut, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onZoneEnter, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onZoneExit, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onHeal, localIdToInvocationMap),
				InitializeActionSubCategory(idGenerator.ModifierIndex, configIndex++, onBeingHealed, localIdToInvocationMap),

			};
		await Task.WhenAll(tasks);

		if (modifierMixins == null) return;
		idGenerator.Type = ConfigAbilitySubContainerType.MODIFIER_MIXIN;
		ushort mixinIndex = 0;
		var tasks2 = new List<Task>();
		for (uint i = 0; i < modifierMixins.Length; i++)
		{
			idGenerator = new(ConfigAbilitySubContainerType.MODIFIER_MIXIN) { ConfigIndex = 0, MixinIndex = mixinIndex++ };
			tasks2.Add(modifierMixins[i].Initialize(idGenerator, localIdToInvocationMap));
		}
	}
	private async Task InitializeActionSubCategory(uint modifierIndex, ushort configIndex, ConfigAbilityAction[]? actions, IDictionary<uint, IInvocation> localIdToInvocationMap)
	{
		if (actions == null) return;
		await Task.Yield();
		LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.MODIFIER_ACTION) { ConfigIndex = configIndex, ModifierIndex = modifierIndex };
		idGenerator.InitializeActionLocalIds(actions, localIdToInvocationMap);
	}
}
