using System.Collections.Concurrent;
using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;
using Weedwacker.GameServer.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp;

public class ConfigAbility
{
	public string abilityName;
	public ConfigAbilityMixin[] abilityMixins;
	public Dictionary<string, object> abilitySpecials;
	public Dictionary<string, ConfigAbilityModifier> modifiers;
	public ConfigAbilityModifier defaultModifier;
	public ConfigAbilityAction[] onAdded;
	public ConfigAbilityAction[] onRemoved;
	public ConfigAbilityAction[] onAbilityStart;
	public ConfigAbilityAction[] onKill;
	public ConfigAbilityAction[] onFieldEnter;
	public ConfigAbilityAction[] onFieldExit;
	public ConfigAbilityAction[] onAttach;
	public ConfigAbilityAction[] onDetach;
	public ConfigAbilityAction[] onAvatarIn;
	public ConfigAbilityAction[] onAvatarOut;
	public ConfigAbilityAction[] onVehicleIn;
	public ConfigAbilityAction[] onVehicleOut;
	public ConfigAbilityAction[] onTriggerAvatarRay;
	public ConfigAbilityAction[] onZoneEnter;
	public ConfigAbilityAction[] onZoneExit;
	public bool isDynamicAbility;
	public Dictionary<string, ConfigAbilityPropertyEntry> abilityDefinedProperties;
	[JsonIgnore] public ConcurrentDictionary<uint, IInvocation> LocalIdToInvocationMap;
	[JsonIgnore] public SortedList<uint, ConfigAbilityModifier> ModifierList;

	public class ConfigAbilityPropertyEntry
	{
		public PropertyType Type;
		public float DefaultValue;
		public float Ceiling;
		public float Floor;
		public StackMethod Stacking;
		public bool Succeed;
		public bool UseTag;
		public float LimitedTagCeiling;
		public float LimitedTagFloor;
	}
	public async Task Initialize()
	{
		// DO NOT CHANGE THE ORDER
		LocalIdToInvocationMap = new();

		var tasks = new Task[]
		{
			InitializeMixinIds(),
			InitializeModifierIds(),
			InitializeActionIds()
		};

		await Task.WhenAll(tasks);

	}

	private async Task InitializeActionIds()
	{
		await Task.Yield();
		ushort configIndex = 0;
		LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.ACTION);
		idGenerator.InitializeActionLocalIds(onAdded, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onRemoved, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onAbilityStart, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onKill, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onFieldEnter, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onFieldExit, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onAttach, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onDetach, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onAvatarIn, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onAvatarOut, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onTriggerAvatarRay, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onVehicleIn, LocalIdToInvocationMap);
		idGenerator.ConfigIndex++;
		idGenerator.InitializeActionLocalIds(onVehicleOut, LocalIdToInvocationMap);
	}

	private async Task InitializeMixinIds()
	{
		if (abilityMixins != null)
		{
			LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.MIXIN);
			for (uint i = 0; i < abilityMixins.Length; i++)
			{
				idGenerator.ConfigIndex = 0;
				await abilityMixins[i].Initialize(idGenerator, LocalIdToInvocationMap);
				idGenerator.MixinIndex++;
			}
		}
	}

	private async Task InitializeModifierIds()
	{
		if (modifiers != null)
		{
			ModifierList = new();
			var modifierArray = modifiers.ToArray();
			var tasks = new Task[modifierArray.Length];
			ushort modifierIndex = 0;
			for (uint i = 0; i < modifierArray.Length; i++)
			{
				LocalIdGenerator idGenerator = new(ConfigAbilitySubContainerType.NONE) { ModifierIndex = modifierIndex };
				ModifierList[i] = modifierArray[i].Value;
				tasks[i] = modifierArray[i].Value.Initialize(idGenerator, LocalIdToInvocationMap);
				modifierIndex++;
			}

			await Task.WhenAll(tasks);
		}
	}
}
