using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Weedwacker.GameServer.Enums
{
	[JsonConverter(typeof(StringEnumConverter))]
	public enum EshaderData
    {
        None,
        CharacterFrozen,
        CharacterPetrification,
        CharacterDie,
        CharacterBurningToAshes,
        CharacterDissolve,
        GadgetFrozen,
        GadgetPetrification,
        GadgetDie,
        AvatarDie,
        MonsterEquipDie,
        MonsterDie,
        CharacterClip
    }
}
