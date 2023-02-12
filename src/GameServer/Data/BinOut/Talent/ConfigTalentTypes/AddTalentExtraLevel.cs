using Newtonsoft.Json;
using Weedwacker.GameServer.Data.Enums;

namespace Weedwacker.GameServer.Data.BinOut.Talent;

internal class AddTalentExtraLevel : ConfigTalentMixin
{
    public TalentType talentType;
    public uint talentIndex;
    public uint extraLevel;
}
