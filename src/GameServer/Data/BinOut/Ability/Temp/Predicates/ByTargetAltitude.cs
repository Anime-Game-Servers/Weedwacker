﻿using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetAltitude : ConfigAbilityPredicate
{
	public object value;
	public TargetAltitudeType TargetAltitudeType;
}
