using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ElementType
    {
        None,
        Fire = 1,
        Water = 2,
        Grass = 3,
        Electric = 4,
        Ice = 5,  
        Frozen = 6,
        Wind = 7,
        Rock = 8,
        AntiFire,
        Default = 255,
        VehicleMuteIce, //wtf
    }
}
