﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.Predicates;

public class ByTargetConfigID : ConfigAbilityPredicate
{
	public uint[] configIdArray;
}
