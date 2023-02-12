﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Data.BinOut.Shared;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Actions;

public class TriggerAttackTargetMapEvent : ConfigAbilityAction
{
	public ConfigAttackTargetMapEvent attackTargetMapEvent;

	public class ConfigAttackTargetMapEvent
	{
		public ConfigBaseAttackPattern attackPattern;
		public Dictionary<TargetType, ConfigAttackInfo> attackInfoMap;
	}
}
