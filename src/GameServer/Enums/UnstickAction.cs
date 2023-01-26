﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum UnstickAction
    {
        Stay,
        Keep,
        Destroy,
        StayAndReturn
    }
}
