﻿using Newtonsoft.Json;

namespace Weedwacker.GameServer.Data.BinOut.Ability.Temp.AbilityMixins
{
    internal class OverrideStickElemUIMixin : BaseAbilityMixin
    {
        [JsonProperty] public readonly string effName;
    }
}
